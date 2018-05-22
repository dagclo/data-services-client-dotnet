using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Quadient.DataServices.Utility
{
    [Serializable]
    public class ApiException : Exception
    {
        public ApiException(string message) : base(message)
        {
        }

        public ApiException(string message, IDictionary<string, object> additionalDetails) :
            base(message)
        {
            if (additionalDetails != null)
            {
                foreach (var keyValuePair in additionalDetails)
                {
                    if (!Data.Contains(keyValuePair.Key))
                    {
                        Data.Add(keyValuePair.Key, keyValuePair.Value);
                    }
                }
            }
        }

        protected ApiException(
            SerializationInfo info,
            StreamingContext context) : base(info, context)
        {
        }
    }
}
