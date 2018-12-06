using System.Collections.Generic;
using System.Net.Http;
using Quadient.DataServices.Api;
using Quadient.DataServices.System.Model.User;

namespace Quadient.DataServices.System.User
{
    /// <summary>
    /// Get the service access descriptor in place for the tenant for the named service.
    /// </summary>
    public class GetServiceAccess : IRequest<ServiceAccessDescriptor>
    {
        public string ServicePath { get; }
        public HttpMethod Method => HttpMethod.Get;
        public object Content { get; set; }
        public IDictionary<string, string> QueryStringParams { get; }
        public object Body => Content;
        public IDictionary<string, string> Headers { get; }

        /// <summary>
        /// Get the service access descriptor in place for the tenant for the named service.
        /// </summary>
        /// <param name="tenantName">A unique tenant name. Tenant names/hrefs can be discovered via enumeration/querying (GET /users/v1/tenants).</param>
        /// <param name="serviceName">A unique service name. Service names can be discovered via enumeration/querying (GET /services)</param>
        public GetServiceAccess(string tenantName, string serviceName)
        {
            ServicePath = $"users/v1/tenants/{tenantName}/services/{serviceName}";
        }
    }
}
