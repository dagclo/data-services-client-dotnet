using System.Collections.Generic;
using System.Net.Http;

namespace Quadient.DataServices.Api.Etl
{
	internal class FileDeleteRequest : IRequest<object>
	{
		public string ServicePath { get; }
		public HttpMethod Method { get; } = HttpMethod.Delete;
		public object Body { get; }
		public IDictionary<string, string> QueryStringParams { get; }
		public IDictionary<string, string> Headers { get; }
		public FileDeleteRequest(string fileId)
		{
			ServicePath = $"etl/v1/files/{fileId}";
		}
	}
}
