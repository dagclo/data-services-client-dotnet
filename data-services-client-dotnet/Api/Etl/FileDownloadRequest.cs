using System.Collections.Generic;
using System.IO;
using System.Net.Http;
using Quadient.DataServices.Model.Etl;

namespace Quadient.DataServices.Api.Etl
{
	public class FileDownloadRequest : IRequest<Stream>
	{
		public string ServicePath { get; }
		public HttpMethod Method => HttpMethod.Get;
		public object Body { get; }
		public IDictionary<string, string> QueryStringParams { get; }
		public IDictionary<string, string> Headers => new Dictionary<string, string>() { { "Accept", "application/octet-stream" } };

		public FileDownloadRequest(string fileId)
		{
			ServicePath = $"etl/v1/files/{fileId}/_download";
		}
	}
}
