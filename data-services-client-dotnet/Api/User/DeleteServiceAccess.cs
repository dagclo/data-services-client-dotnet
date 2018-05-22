using System.Collections.Generic;
using System.Net.Http;

namespace Quadient.DataServices.Api.User
{
    public class DeleteServiceAccess : IRequest<object, object>
    {
        public string ServicePath { get; }
        public HttpMethod Method { get; } = HttpMethod.Delete;
        public object Content { get; set; }
        public IDictionary<string, string> QueryStringParams { get; }

        public DeleteServiceAccess(string tenantId, string serviceName)
        {
            ServicePath = $"/users/v1/tenants/{tenantId}/{serviceName}";
        }
    }
}
