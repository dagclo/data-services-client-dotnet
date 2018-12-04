using System.Collections.Generic;
using System.Net.Http;

namespace Quadient.DataServices.Api.Etl
{
	internal class TablePageDeleteRequest : IRequest<object>
	{
		public string ServicePath { get; }
		public HttpMethod Method { get; } = HttpMethod.Delete;
		public object Body { get; }
		public IDictionary<string, string> QueryStringParams { get; }
		public IDictionary<string, string> Headers { get; }
		public TablePageDeleteRequest(string tableId, string pageId)
		{
			ServicePath = $"etl/v1/tables/{tableId}/{pageId}";
		}
	}
}
