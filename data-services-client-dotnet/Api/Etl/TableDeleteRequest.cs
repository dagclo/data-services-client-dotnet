using System.Collections.Generic;
using System.Net.Http;

namespace Quadient.DataServices.Api.Etl
{
	internal class TableDeleteRequest : IRequest<object>
	{
		public string ServicePath { get; }
		public HttpMethod Method { get; } = HttpMethod.Delete;
		public object Body { get; }
		public IDictionary<string, string> QueryStringParams { get; }
		public IDictionary<string, string> Headers { get; }
		public TableDeleteRequest(string tableId)
		{
			ServicePath = $"etl/v1/tables/{tableId}";
		}
	}
}