using Quadient.DataServices.Model.Pricebook;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Net.Http;

namespace Quadient.DataServices.Api.Pricebook
{
    public class GetPrices : IRequest<object, Pricesheet>
    {
        public string ServicePath { get; }
        public HttpMethod Method { get; } = HttpMethod.Get;
        public object Content { get; set; }
        public IDictionary<string, string> QueryStringParams { get; }

        public GetPrices(GetPricesRequest request)
        {
            ServicePath = $"pricebook/v1/prices/{request.Service}";
            QueryStringParams = new Dictionary<string, string>
            {
                {"valid_from", request.ValidFrom?.ToUniversalTime().ToString(CultureInfo.InvariantCulture) },
                {"valid_to", request.ValidTo?.ToUniversalTime().ToString(CultureInfo.InvariantCulture) },
                {"tenant", request.Tenant },
                {"user_id", request.UserId },
                {"service", request.Service },
                {"include_disabled_prices", request.IncludeDisabledPrices ? bool.TrueString : bool.FalseString },
                {"include_deleted_prices", request.IncludeDeletedPrices ? bool.TrueString : bool.FalseString }
            };
        }
    }

    public class GetPricesRequest
    {
        /// <summary>
        /// An optional date for the start of the time frame of interest. Prices in effect after this date will be included. If not present, the earliest items will be part of the result.
        /// </summary>
        public DateTime? ValidFrom { get; set; }
        /// <summary>
        /// An optional date for the end of the time frame of interest. Prices in effect before this date (and after the valid_from date) will be included. If not present, all items after the starting time will be returned.
        /// </summary>
        public DateTime? ValidTo { get; set; }
        /// <summary>
        /// The service to get pricing history for. (optional)
        /// </summary>
        public string Service { get; set; }
        /// <summary>
        /// The tenant to get pricing for (optional).
        /// </summary>
        public string Tenant { get; set; }
        /// <summary>
        /// The user to get pricing for (optional). The user must belong to the tenant if used in conjunction with a tenant parameter.
        /// </summary>
        public string UserId { get; set; }

        /// <summary>
        /// Receive a sheet that includes disabled price lines?
        /// </summary>
        public bool IncludeDisabledPrices { get; set; } = false;
        /// <summary>
        /// Receive a sheet that includes deleted price lines?
        /// </summary>
        public bool IncludeDeletedPrices { get; set; } = false;
    }
}
