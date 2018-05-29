using System.Collections.Generic;
using System.Net.Http;
using Quadient.DataServices.Api;

namespace Quadient.DataServices.System.User
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
        /// <param name="tenantName">A unique tenant name. Tenant names/hrefs can be discovered via enumeration/querying (GET /users/v1/tenants).</param>
        /// <param name="serviceName">A unique service name. Service names can be discovered via enumeration/querying (GET /services)</param>
        public DeleteServiceAccess(string tenantName, string serviceName)
        {
            ServicePath = $"users/v1/tenants/{tenantName}/services/{serviceName}";
        }
    }
}
