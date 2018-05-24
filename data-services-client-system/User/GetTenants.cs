using Quadient.DataServices.Api;
using Quadient.DataServices.System.Model.User;
using System.Collections.Generic;
using System.Net.Http;

namespace Quadient.DataServices.System.User
{
    public class GetTenants : IRequest<object, TenantCollection>
    {
        public string ServicePath { get; } = "users/v1/tenants";
        public HttpMethod Method { get; } = HttpMethod.Get;
        public object Content { get; set; }
        public IDictionary<string, string> QueryStringParams { get; }
    }
}
