using Quadient.DataServices.Model.Pricebook;
using System.Collections.Generic;
using System.Net.Http;

namespace Quadient.DataServices.Api.Pricebook
{
    public class SaveServicePrices : IRequest<PriceSettingRequest, PricesResult>
    {
        public string ServicePath { get; } = "pricebook/v1/prices/";
        public HttpMethod Method { get; } = HttpMethod.Post;
        public PriceSettingRequest Content { get; set; }
        public IDictionary<string, string> QueryStringParams { get; }

        public SaveServicePrices(PriceSettingRequest request)
        {
            Content = request;
        }
    }
}
