using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using Quadient.DataServices.Model.Etl;

namespace Quadient.DataServices.Api.Etl
{
	public class TableAppendRecordsRequest : IRequest<TableUpdateResponse>
	{
		public string ServicePath { get; }
		public HttpMethod Method => HttpMethod.Post;
		public object Body { get; }
		public IDictionary<string, string> QueryStringParams { get; }
		public IDictionary<string, string> Headers { get; }
		public TableAppendRecordsRequest(string tableId, IEnumerable<IList<string>> records) : this(tableId, CreateRequest(records)) { }

		public TableAppendRecordsRequest(string tableId, TableUpdateRequest req)
		{
			Body = req;
		}
		private static TableUpdateRequest CreateRequest(IEnumerable<IList<string>> records)
		{
			var list = records.Select(r => r.ToList()).ToList();
			return new TableUpdateRequest()
			{
				Records = list
			};
		}
	}
}
