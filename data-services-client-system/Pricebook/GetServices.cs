using System.Collections.Generic;
using System.Net.Http;
using Quadient.DataServices.Api;
using Quadient.DataServices.System.Model.Pricebook;

namespace Quadient.DataServices.System.Pricebook
{
    /// <summary>
    /// Returns an object with a `services` key that contains an array of valid service names 
    /// </summary>
    public class GetServices : IRequest<ServicesEnumeration>
    {
        public string ServicePath { get; } = "pricebook/v1/services";
        public HttpMethod Method { get; } = HttpMethod.Get;
        public object Body { get; }
        public IDictionary<string, string> QueryStringParams { get; }
        public IDictionary<string, string> Headers { get; }
    }
}
