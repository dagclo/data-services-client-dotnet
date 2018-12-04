using System.Collections.Generic;
using System.Net.Http;
using Quadient.DataServices.Model.Etl;

namespace Quadient.DataServices.Api.Etl
{
	internal class TablePageRequest : IRequest<TablePage>
	{
		public string ServicePath { get; }
		public HttpMethod Method { get; } = HttpMethod.Get;
		public object Body { get; }
		public IDictionary<string, string> QueryStringParams { get; }
		public IDictionary<string, string> Headers { get; }
		public TablePageRequest(string tableId, string pageId)
		{
			ServicePath = $"etl/v1/tables/{tableId}/{pageId}";
		}
	}
}