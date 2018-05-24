using System.Collections.Generic;
using System.Net.Http;
using Quadient.DataServices.Api;
using Quadient.DataServices.System.Model.Pricebook;

namespace Quadient.DataServices.System.Pricebook
{
    public class SaveServicePrices : IRequest<PriceSettingRequest, Prices>
    {
        public string ServicePath { get; }
        public HttpMethod Method { get; } = HttpMethod.Post;
        public PriceSettingRequest Content { get; set; }
        public IDictionary<string, string> QueryStringParams { get; }

        public SaveServicePrices(string service, PriceSettingRequest request)
        {
            ServicePath = $"pricebook/v1/prices/{service}";
            Content = request;
        }
    }
}
