using Quadient.DataServices.Model.Pricebook;
using System.Collections.Generic;
using System.Net.Http;

namespace Quadient.DataServices.Api.Pricebook
{
    public class UpdateServicePrice : IRequest<PriceLine, Id>
    {
        public string ServicePath { get; }
        public HttpMethod Method { get; } = HttpMethod.Post;
        public PriceLine Content { get; set; }
        public IDictionary<string, string> QueryStringParams { get; }

        public UpdateServicePrice(string id)
        {
            ServicePath = $"pricebook/v1/prices/pricelines/{id}";
        }

        public UpdateServicePrice(string id, PriceLine priceLine) : this(id)
        {
            Content = priceLine;
        }
    }
}
