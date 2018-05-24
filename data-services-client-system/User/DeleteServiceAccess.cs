using System.Collections.Generic;
using System.Net.Http;

namespace Quadient.DataServices.Api.System.User
{
    /// <summary>
    /// Remove the service access descriptor for the named service.
    /// </summary>
    public class DeleteServiceAccess : IRequest<object, object>
    {
        public string ServicePath { get; }
        public HttpMethod Method { get; } = HttpMethod.Delete;
        public object Content { get; set; }
        public IDictionary<string, string> QueryStringParams { get; }

        /// <summary>
        /// Remove the service access descriptor for the named service.
        /// </summary>
        /// <param name="tenantId">A unique tenant id. Tenant ids/hrefs can be discovered via enumeration/querying (GET /users/v1/tenants).</param>
        /// <param name="serviceName">A unique service name. Service names can be discovered via enumeration/querying (GET /services)</param>
        public DeleteServiceAccess(string tenantId, string serviceName)
        {
            ServicePath = $"/users/v1/tenants/{tenantId}/{serviceName}";
        }
    }
}
