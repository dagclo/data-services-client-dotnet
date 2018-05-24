using System.Collections.Generic;
using System.Net.Http;
using Quadient.DataServices.System.Model.User;

namespace Quadient.DataServices.Api.System.User
{
    /// <summary>
    /// Get the list of enabled and disabled services for this tenant.
    /// </summary>
    public class GetServicesAccess : IRequest<object, ServiceAccessDescriptorListing>
    {
        public string ServicePath { get; }
        public HttpMethod Method { get; } = HttpMethod.Get;
        public object Content { get; set; }
        public IDictionary<string, string> QueryStringParams { get; }

        /// <summary>
        /// Get the list of enabled and disabled services for this tenant.
        /// </summary>
        /// <param name="tenantId">A unique tenant id. Tenant ids/hrefs can be discovered via enumeration/querying (GET /users/v1/tenants).</param>
        public GetServicesAccess(string tenantId)
        {
            ServicePath = $"/users/v1/tenants/{tenantId}/services";
        }
    }
}
