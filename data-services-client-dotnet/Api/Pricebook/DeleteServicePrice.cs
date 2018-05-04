using System.Collections.Generic;
using System.Net.Http;

namespace Quadient.DataServices.Api.Pricebook
{
    public class DeleteServicePrice : IRequest<object, object>
    {
        public string ServicePath { get; }
        public HttpMethod Method { get; } = HttpMethod.Delete;
        public object Content { get; set; }
        public IDictionary<string, string> QueryStringParams { get; }

        public DeleteServicePrice(string id)
        {
            ServicePath = $"pricebook/v1/prices/pricelines/{id}";
        }
    }
}
