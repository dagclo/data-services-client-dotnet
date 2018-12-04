using Quadient.DataServices.Api;
using Quadient.DataServices.System.Model.User;
using System.Collections.Generic;
using System.Net.Http;

namespace Quadient.DataServices.System.User
{
    public class GetTenant : IRequest<TenantInformation>
    {
        public string ServicePath { get; }
        public HttpMethod Method { get; } = HttpMethod.Get;
        public object Content { get; set; }
        public IDictionary<string, string> QueryStringParams { get; }
        public object Body => Content;
        public IDictionary<string, string> Headers { get; }

        public GetTenant(string tenantName)
        {
            ServicePath = $"users/v1/tenants/{tenantName}";
        }
    }
}
