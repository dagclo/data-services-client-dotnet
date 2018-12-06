using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using Quadient.DataServices.Model.Etl;

namespace Quadient.DataServices.Api.Etl
{
	public class TableCreationSchemaRequest : IRequest<TableInformation>
	{
		public string ServicePath => "etl/v1/tables";
		public HttpMethod Method => HttpMethod.Post;
		public object Body { get; }
		public IDictionary<string, string> QueryStringParams { get; }
		public IDictionary<string, string> Headers { get; }
		public TableCreationSchemaRequest(IList<string> columnNames) : this(new TableCreationRequest()
		{
			ColumnNames = columnNames.ToList()
		})
		{ }
		public TableCreationSchemaRequest(TableCreationRequest req)
		{
			Body = req;
		}
	}
}
