using System.Collections.Generic;
using System.Net.Http;
using Quadient.DataServices.Model.Etl;

namespace Quadient.DataServices.Api.Etl
{
	internal class TableInformationRequest : IRequest<TableInformation>
	{
		public string ServicePath { get; }
		public HttpMethod Method => HttpMethod.Get;
		public object Body { get; }
		public IDictionary<string, string> QueryStringParams { get; }
		public IDictionary<string, string> Headers { get; }
		public TableInformationRequest(string tableId)
		{
			ServicePath = $"etl/v1/tables/{tableId}";
		}
		public TableInformationRequest(string tableId, bool retrieveColumns, bool retrievePages)
		{
			ServicePath = $"etl/v1/tables/{tableId}?retrieveColumns={retrieveColumns}&retrievePages={retrievePages}";
		}
	}
}
