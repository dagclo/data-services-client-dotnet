﻿using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;

namespace Quadient.DataServices.Utility
{
	public static class Extensions
	{
		/// <summary>
		/// 
		/// </summary>
		/// <param name="message"></param>
		/// <returns></returns>
		/// <exception cref="BadRequestRestException"></exception>
		/// <exception cref="InsufficientCreditsRestException"></exception>
		/// <exception cref="HttpRequestException">The request failed due to an underlying issue such as network connectivity, DNS failure, server certificate validation or timeout.</exception>
		public static HttpResponseMessage EnsureSuccess(this HttpResponseMessage message)
		{
			return EnsureSuccessAsync(message).GetAwaiter().GetResult();
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="message"></param>
		/// <returns></returns>
		/// <exception cref="BadRequestRestException"></exception>
		/// <exception cref="InsufficientCreditsRestException"></exception>
		/// <exception cref="HttpRequestException">The request failed due to an underlying issue such as network connectivity, DNS failure, server certificate validation or timeout.</exception>
		public static async Task<HttpResponseMessage> EnsureSuccessAsync(this HttpResponseMessage message)
		{
			if (!message.IsSuccessStatusCode)
			{
				try
				{
					IDictionary<string, object> additionalDetails = null;
					string serviceMessage = null;
					var resultContent = await message.Content.ReadAsStringAsync();
					try
					{
						var errorDetail = resultContent != null
							? JsonConvert.DeserializeObject<IDictionary<string, object>>(resultContent)
							: null;
						if (errorDetail?.ContainsKey("message") == true)
						{
							serviceMessage = errorDetail["message"].ToString();
						}

						if (errorDetail?.ContainsKey("additional_details") == true &&
							errorDetail["additional_details"] != null)
						{
							additionalDetails =
								JsonConvert.DeserializeObject<IDictionary<string, object>>(
									errorDetail["additional_details"]
										.ToString());
						}
					}
					catch (JsonException)
					{
						// response did not contain valid Json
						serviceMessage = resultContent;
					}

					// assume bad request equates to invalid data provided by the end user
					switch (message.StatusCode)
					{
						case HttpStatusCode.BadRequest:
							throw new BadRequestRestException(serviceMessage, message, additionalDetails);
						case HttpStatusCode.Forbidden:
							object reason = null;
							if (additionalDetails?.TryGetValue("reason", out reason) == true &&
								(reason as string)?.Equals("Billing: credit balance",
									StringComparison.OrdinalIgnoreCase) == true)
							{
								throw new InsufficientCreditsRestException(serviceMessage, message, additionalDetails);
							}

							break;
					}

					throw new RestException(
						serviceMessage ??
						$"Failed request with status code {message.StatusCode} reason {message.ReasonPhrase}", message,
						additionalDetails);
				}
				finally
				{
					message.Content?.Dispose();
				}
			}

			return message;
		}
	}
}
