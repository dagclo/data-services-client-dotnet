using Quadient.DataServices.Model.Pricebook;
using System.Collections.Generic;
using System.Net.Http;

namespace Quadient.DataServices.Api.Pricebook
{
    public class GetServices : IRequest<object, ServicesEnumeration>
    {
        public string ServicePath { get; } = "pricebook/v1/services";
        public HttpMethod Method { get; } = HttpMethod.Get;
        public object Content { get; set; }
        public IDictionary<string, string> QueryStringParams { get; }
    }
}
