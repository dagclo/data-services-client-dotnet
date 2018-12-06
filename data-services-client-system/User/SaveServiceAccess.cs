using System.Collections.Generic;
using System.Net.Http;
using Quadient.DataServices.Api;
using Quadient.DataServices.System.Model.User;

namespace Quadient.DataServices.System.User
{
    /// <summary>
    /// Add or overwrite an access descriptor for this tenant for the named service.
    /// </summary>
    public class SaveServiceAccess : IRequest<ServiceAccessDescriptor>
    {
        public string ServicePath { get; }
        public HttpMethod Method => HttpMethod.Put;
        public ServiceAccessRequest Content { get; set; }
        public IDictionary<string, string> QueryStringParams { get; }
        public object Body => Content;
        public IDictionary<string, string> Headers { get; }
        /// <summary>
        /// Add or overwrite an access descriptor for this tenant for the named service.
        /// </summary>
        /// <param name="tenantName">A unique tenant name. Tenant names/hrefs can be discovered via enumeration/querying (GET /users/v1/tenants).</param>
        /// <param name="serviceName">A unique service name. Service names can be discovered via enumeration/querying (GET /services)</param>
        /// <param name="request"></param>
        public SaveServiceAccess(string tenantName, string serviceName, ServiceAccessRequest request)
        {
            ServicePath = $"users/v1/tenants/{tenantName}/services/{serviceName}";
            Content = request;
        }
    }
}
