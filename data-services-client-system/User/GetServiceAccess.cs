﻿using System.Collections.Generic;
using System.Net.Http;
using Quadient.DataServices.System.Model.User;

namespace Quadient.DataServices.Api.System.User
{
    /// <summary>
    /// Get the service access descriptor in place for the tenant for the named service.
    /// </summary>
    public class GetServiceAccess : IRequest<object, ServiceAccessDescriptor>
    {
        public string ServicePath { get; }
        public HttpMethod Method { get; } = HttpMethod.Get;
        public object Content { get; set; }
        public IDictionary<string, string> QueryStringParams { get; }

        /// <summary>
        /// Get the service access descriptor in place for the tenant for the named service.
        /// </summary>
        /// <param name="tenantName">A unique tenant id. Tenant ids/hrefs can be discovered via enumeration/querying (GET /users/v1/tenants).</param>
        /// <param name="serviceName">A unique service name. Service names can be discovered via enumeration/querying (GET /services)</param>
        public GetServiceAccess(string tenantName, string serviceName)
        {
            ServicePath = $"/users/v1/tenants/{tenantName}/services/{serviceName}";
        }
    }
}
