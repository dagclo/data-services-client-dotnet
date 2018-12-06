using System.Collections.Generic;
using System.Net.Http;
using Quadient.DataServices.Api;
using Quadient.DataServices.System.Model.User;

namespace Quadient.DataServices.System.User
{
	/// <summary>
	/// Get the list of enabled and disabled services for this tenant.
	/// </summary>
	public class GetServicesAccess : IRequest<ServiceAccessDescriptorListing>
	{
		public string ServicePath { get; }
		public HttpMethod Method => HttpMethod.Get;
		public object Content { get; set; }
		public IDictionary<string, string> QueryStringParams { get; }
		public object Body => Content;
		public IDictionary<string, string> Headers { get; }

		/// <summary>
		/// Get the list of enabled and disabled services for this tenant.
		/// </summary>
		/// <param name="tenantName">A unique tenant name. Tenant names/hrefs can be discovered via enumeration/querying (GET /users/v1/tenants).</param>
		public GetServicesAccess(string tenantName)
		{
			ServicePath = $"users/v1/tenants/{tenantName}/services";
		}
	}
}
