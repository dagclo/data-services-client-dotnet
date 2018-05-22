using System.Collections.Generic;
using System.Net.Http;
using Quadient.DataServices.Api;

namespace Quadient.DataServices.System.Pricebook
{
    public class DeleteServicePriceLine : IRequest<object, object>
    {
        public string ServicePath { get; }
        public HttpMethod Method { get; } = HttpMethod.Delete;
        public object Content { get; set; }
        public IDictionary<string, string> QueryStringParams { get; }

        public DeleteServicePriceLine(string id)
        {
            ServicePath = $"pricebook/v1/prices/pricelines/{id}";
        }
    }
}
