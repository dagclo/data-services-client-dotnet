using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Web;
using Newtonsoft.Json;
using Quadient.DataServices.Api.User;
using Quadient.DataServices.Model;
using Quadient.DataServices.Utility;

namespace Quadient.DataServices.Api
{
	internal class BaseServiceCaller : IServiceCaller
	{
		private const int TokenExpiration = 8 * 60 * 1000;
		private const string TokenType = "Bearer";
		private HttpClient _httpClient;
		private HttpClient _authClient;
		protected ICredentials Credentials { get; }
		protected IConfiguration Configuration { get; }
		protected ISessionToken SessionToken { get; }

		public BaseServiceCaller(ICredentials credentials, IConfiguration configuration)
		{
			if (_httpClient != null)
			{
				return;
			}

			if (configuration == null)
			{
				configuration = new Configuration();
			}

			Credentials = credentials;
			Configuration = configuration;

			InitializeHttpClients(configuration);
		}

		public BaseServiceCaller(ISessionToken sessionToken, IConfiguration configuration = null)
		{
			SessionToken = sessionToken;
			if (configuration == null)
			{
				configuration = new Configuration();
			}

			Configuration = configuration;

			_session = new Session { Token = SessionToken.Token };
			_expiration = DateTime.MaxValue;
			InitializeHttpClients(configuration);
		}

		private void InitializeHttpClients(IConfiguration configuration)
		{
			var handler = new HttpClientHandler
			{
				PreAuthenticate = true,
				ClientCertificateOptions = ClientCertificateOption.Automatic
			};

			var timeout =
				 TimeSpan.FromSeconds(configuration.Timeout > 0
					  ? configuration.Timeout.Value
					  : Constants.ServiceTimeout);
			_httpClient = new HttpClient(handler)
			{
				Timeout = timeout,
				BaseAddress = GetBaseAddress()
			};
			_httpClient.DefaultRequestHeaders.Add("User-Agent", configuration.UserAgent);

			_authClient = new HttpClient(handler)
			{
				Timeout = timeout,
				BaseAddress = GetBaseAddress(true)
			};
			_authClient.DefaultRequestHeaders.Add("User-Agent", configuration.UserAgent);
		}

		private ISession _session;
		private DateTime _expiration;

		private async Task<ISession> GetSession(CancellationToken cancellationToken)
		{
			if (_session != null && _expiration > DateTime.Now) return _session;
			var request = GetAuthToken(Credentials);
			using (var httpRequest = new HttpRequestMessage(request.Method, request.ServicePath))
			{
				httpRequest.Content = request.GetHttpContent() ??
											 new StringContent(SerializeObject(request.Content), Encoding.UTF8,
												  "application/json");
				using (var result = await _authClient.SendAsync(httpRequest, cancellationToken))
				{
					await result.EnsureSuccessAsync();
					var resultContent = await result.Content.ReadAsStringAsync();
					_session = DeserializeObject<Session>(resultContent);
				}
			}

			if (!(Credentials is QuadientCloudCredentials)) _session.Token = _session.AccessToken;
			_expiration = DateTime.Now.AddMilliseconds(TokenExpiration);
			return _session;
		}

		private static AuthToken GetAuthToken(ICredentials credentials)
		{
			switch (credentials)
			{
				case QuadientCloudCredentials cloudCredentials:
					return new QuadientCloudToken(cloudCredentials);
				case AdminCredentials adminCredentials:
					return new DataServicesToken(adminCredentials);
				case AdminApiKey apiKey:
					return new DataServicesApiKeyToken(apiKey);
			}

			throw new NotSupportedException();
		}

		/// <summary>
		/// Execute the service call.
		/// </summary>
		/// <typeparam name="R">The return type from the service request.</typeparam>
		/// <param name="request"></param>
		/// <param name="headers"></param>
		/// <returns></returns>
		/// <exception cref="BadRequestRestException"></exception>
		/// <exception cref="InsufficientCreditsRestException"></exception>
		/// <exception cref="HttpRequestException">The request failed due to an underlying issue such as network connectivity, DNS failure, server certificate validation or timeout.</exception>
		public async Task<R> Execute<R>(IRequest<R> request)
		{
			return await Execute(request, CancellationToken.None);
		}

		/// <summary>
		/// Execute the service call.
		/// </summary>
		/// <typeparam name="R">The return type from the service request.</typeparam>
		/// <param name="request"></param>
		/// <param name="cancellationToken"></param>
		/// <returns></returns>
		/// <exception cref="BadRequestRestException"></exception>
		/// <exception cref="InsufficientCreditsRestException"></exception>
		/// <exception cref="HttpRequestException">The request failed due to an underlying issue such as network connectivity, DNS failure, server certificate validation or timeout.</exception>
		public async Task<R> Execute<R>(IRequest<R> request, CancellationToken cancellationToken)
		{
			var session = await GetSession(cancellationToken);
			using (var httpRequest = new HttpRequestMessage(request.Method, GetRequestUri(request)))
			{
				httpRequest.Headers.Authorization = new AuthenticationHeaderValue(TokenType, session.Token);
				var headers = request.Headers;
				if (headers != null)
				{
					foreach (var key in headers.Keys)
					{
						httpRequest.Headers.TryAddWithoutValidation(key, headers[key]);
					}
				}

				if (request.Method == HttpMethod.Post || request.Method == HttpMethod.Put)
				{
					httpRequest.Content = new StringContent(SerializeObject(request.Body), Encoding.UTF8,
						 "application/json");
				}

				using (var result = await _httpClient.SendAsync(httpRequest, cancellationToken))
				{
					await result.EnsureSuccessAsync();
					var resultContent = await result.Content.ReadAsStringAsync();
					return DeserializeObject<R>(resultContent);
				}
			}
		}

		private Uri GetBaseAddress(bool isCloud = false)
		{
			var address = string.IsNullOrWhiteSpace(Configuration?.DataServicesAddress)
				 ? $"https://data.quadientcloud.{(Configuration?.Region == Region.US ? "com" : "eu")}/"
				 : Configuration?.DataServicesAddress;
			if (isCloud && Credentials is QuadientCloudCredentials cloudCredentials)
			{
				if (!string.IsNullOrWhiteSpace(Configuration?.QuadientCloudAddress))
				{
					address = Configuration?.QuadientCloudAddress;
				}
				else if (!string.IsNullOrWhiteSpace(cloudCredentials.Company))
				{
					address =
						 $"https://{cloudCredentials.Company}.quadientcloud.{(Configuration?.Region == Region.US ? "com" : "eu")}/";
				}
			}

			return new Uri(address);
		}

		private static string SerializeObject(object value)
		{
			return JsonConvert.SerializeObject(value);
		}

		private static T DeserializeObject<T>(string value)
		{
			return JsonConvert.DeserializeObject<T>(value);
		}

		private static string GetRequestUri<R>(IRequest<R> request)
		{
			return request.QueryStringParams?.Count > 0
				 ? string.Format(
					  $"{request.ServicePath}?{string.Join("&", request.QueryStringParams?.Where(p => !string.IsNullOrEmpty(p.Value)).Select(p => $"{p.Key}={HttpUtility.UrlEncode(p.Value)}"))}")
				 : request.ServicePath;
		}
	}
}
