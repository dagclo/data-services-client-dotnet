using System.Collections.Generic;
using System.Net.Http;
using Quadient.DataServices.Api;
using Quadient.DataServices.System.Model.Pricebook;

namespace Quadient.DataServices.System.Pricebook
{
    public class UpdateServicePriceLine : IRequest<PriceUpdate, object>
    {
        public string ServicePath { get; }
        public HttpMethod Method { get; } = HttpMethod.Put;
        public PriceUpdate Content { get; set; }
        public IDictionary<string, string> QueryStringParams { get; }

        public UpdateServicePriceLine(string id)
        {
            ServicePath = $"pricebook/v1/prices/pricelines/{id}";
        }

        public UpdateServicePriceLine(string id, PriceUpdate priceUpdate) : this(id)
        {
            Content = priceUpdate;
        }
    }
}
