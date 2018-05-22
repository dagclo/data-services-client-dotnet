﻿using Quadient.DataServices.Model.User;
using System.Collections.Generic;
using System.Net.Http;

namespace Quadient.DataServices.Api.User
{
    /// <summary>
    /// Add or overwrite an access descriptor for this tenant for the named service.
    /// </summary>
    public class SaveServiceAccess : IRequest<ServiceAccessRequest, ServiceAccessDescriptor>
    {
        public string ServicePath { get; }
        public HttpMethod Method { get; } = HttpMethod.Put;
        public ServiceAccessRequest Content { get; set; }
        public IDictionary<string, string> QueryStringParams { get; }
        /// <summary>
        /// Add or overwrite an access descriptor for this tenant for the named service.
        /// </summary>
        /// <param name="tenantId">A unique tenant id. Tenant ids/hrefs can be discovered via enumeration/querying (GET /users/v1/tenants).</param>
        /// <param name="serviceName">A unique service name. Service names can be discovered via enumeration/querying (GET /services)</param>
        public SaveServiceAccess(string tenantId, string serviceName)
        {
            ServicePath = $"/users/v1/tenants/{tenantId}/{serviceName}";
        }
    }
}
