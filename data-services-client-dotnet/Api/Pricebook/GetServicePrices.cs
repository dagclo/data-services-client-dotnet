using System;
using System.Collections.Generic;
using System.Globalization;
using System.Net.Http;
using Quadient.DataServices.Model.Pricebook;

namespace Quadient.DataServices.Api.Pricebook
{
    public class GetServicePrices : IRequest<object, Prices>
    {
        public string ServicePath { get; } = "pricebook/v1/prices/{0}";
        public HttpMethod Method { get; } = HttpMethod.Get;
        public object Content { get; set; }
        public IEnumerable<string> PathParams { get; }
        public IDictionary<string, string> QueryStringParams { get; }

        public GetServicePrices(GetServiceRequest request)
        {
            PathParams = new []{ request.Service };
            QueryStringParams = new Dictionary<string, string>
            {
                {"date", request.PriceDate?.ToUniversalTime().ToString(CultureInfo.InvariantCulture) },
                {"tenant", request.Tenant },
                {"user_id", request.UserId }
            };
        }
    }

    public class GetServiceRequest
    {
        /// <summary>
        /// The service to get pricing details for.
        /// </summary>
        public string Service { get; set; }
        /// <summary>
        /// The date the prices should apply to. Defaults to current pricing if missing.
        /// </summary>
        public DateTime? PriceDate { get; set; }
        /// <summary>
        /// The tenant to get pricing for. Base pricing will be returned if no tenant specific pricing exists.
        /// </summary>
        public string Tenant { get; set; }
        /// <summary>
        /// The user to get pricing for. The user must belong to the tenant if used in conjunction with a tenant parameter. Base pricing will be returned if no user specific pricing exists.
        /// </summary>
        public string UserId { get; set; }
    }
}
