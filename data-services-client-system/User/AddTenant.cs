using Quadient.DataServices.Api;
using Quadient.DataServices.System.Model.User;
using System.Collections.Generic;
using System.Net.Http;

namespace Quadient.DataServices.System.User
{
	public class AddTenant : IRequest<TenantDefinition>
	{
		public string ServicePath { get; } = "users/v1/tenants";
		public HttpMethod Method { get; } = HttpMethod.Post;
		public TenantDefinition Content { get; set; }
		public IDictionary<string, string> QueryStringParams { get; }
		public object Body => Content;
		public IDictionary<string, string> Headers { get; }

		public AddTenant(TenantDefinition tenant)
		{
			Content = tenant;
		}
	}
}
