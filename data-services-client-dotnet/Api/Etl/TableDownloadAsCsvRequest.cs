using System;
using System.Collections.Generic;
using System.IO;
using System.Net.Http;
using Quadient.DataServices.Model.Etl;

namespace Quadient.DataServices.Api.Etl
{
	public class TableDownloadAsCsvRequest : IRequest<Stream>
	{
		public string ServicePath { get; }
		public HttpMethod Method { get; } = HttpMethod.Get;
		public object Body { get; }
		public IDictionary<string, string> QueryStringParams { get; }
		public IDictionary<string, string> Headers { get; }
		public TableDownloadAsCsvRequest(string tableId) : this(tableId, true, ',', '"', '\\') { }
		public TableDownloadAsCsvRequest(string tableId, bool includeHeader, char separator, char quote, char escape)
		{
			ServicePath = $"etl/v1/tables/{tableId}/_csv?includeHeader={includeHeader}&separator={Encode(separator)}&quote={Encode(quote)}&escape={Encode(escape)}";
			Headers = new Dictionary<string, string>() { { "Accept", "text/csv" } };
		}

		private static string Encode(char c)
		{
			return Uri.EscapeUriString(char.ToString(c));
		}
	}
}
