using System.Collections.Generic;
using System.Globalization;
using System.Net;
using System.Net.Http;
using Newtonsoft.Json;

namespace Quadient.DataServices.Utility
{
    public static class Extensions
    {
        public static HttpResponseMessage EnsureSuccess(this HttpResponseMessage message)
        {
            if (!message.IsSuccessStatusCode)
            {
                try
                {
                    var resultContent = message.Content.ReadAsStringAsync().Result;
                    var errorDetail = JsonConvert.DeserializeObject<IDictionary<string, object>>(resultContent);
                    string serviceMessage = null;
                    IDictionary<string, object> additionalDetails = null;
                    if (errorDetail?.ContainsKey("message") == true)
                    {
                        serviceMessage = errorDetail["message"].ToString();
                    }

                    if (errorDetail?.ContainsKey("additional_details") == true &&
                        errorDetail["additional_details"] != null)
                    {
                        additionalDetails =
                            JsonConvert.DeserializeObject<IDictionary<string, object>>(errorDetail["additional_details"]
                                .ToString());
                    }

                    // assume bad request equates to invalid data provided by the end user
                    if (message.StatusCode == HttpStatusCode.BadRequest)
                    {
                        throw new ApiException(serviceMessage, additionalDetails);
                    }

                    throw new HttpRequestException(string.Format(CultureInfo.InvariantCulture,
                        $"Failed request with status code {message.StatusCode} reason {message.ReasonPhrase} message {serviceMessage}"));
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
