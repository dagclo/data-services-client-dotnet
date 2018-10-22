using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Http;

namespace Quadient.DataServices.Utility
{
    [Serializable]
    public class BadRequestRestException : RestException
    {
        public BadRequestRestException(string message, HttpResponseMessage responseMessage,
            IDictionary<string, object> additionalDetails) : base(message, responseMessage, additionalDetails)
        {
        }
    }

    [Serializable]
    public class InsufficientCreditsRestException : RestException
    {
        public InsufficientCreditsRestException(string message, HttpResponseMessage responseMessage,
            IDictionary<string, object> additionalDetails) : base(message, responseMessage, additionalDetails)
        {
        }
    }

    [Serializable]
    public class RestException : HttpRequestException
    {
        public HttpStatusCode StatusCode { get; }
        public string ReasonPhrase { get; }

        public RestException(string message, HttpResponseMessage responseMessage,
            IDictionary<string, object> additionalDetails) : base(message)
        {
            StatusCode = responseMessage.StatusCode;
            ReasonPhrase = responseMessage.ReasonPhrase;
            if (additionalDetails != null)
            {
                foreach (var keyValuePair in additionalDetails)
                {
                    if (!Data.Contains(keyValuePair.Key) && keyValuePair.Value?.GetType().IsSerializable == true)
                    {
                        Data.Add(keyValuePair.Key, keyValuePair.Value);
                    }
                }
            }
        }
    }
}
