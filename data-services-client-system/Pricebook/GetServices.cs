using System.Collections.Generic;
using System.Net.Http;
using Quadient.DataServices.Api;
using Quadient.DataServices.System.Model.Pricebook;

namespace Quadient.DataServices.System.Pricebook
{
    /// <summary>
    /// Returns an object with a `services` key that contains an array of valid service names 
    /// </summary>
    public class GetServices : IRequest<object, ServicesEnumeration>
    {
        public string ServicePath { get; } = "pricebook/v1/services";
        public HttpMethod Method { get; } = HttpMethod.Get;
        public object Content { get; set; }
        public IDictionary<string, string> QueryStringParams { get; }
    }
}
