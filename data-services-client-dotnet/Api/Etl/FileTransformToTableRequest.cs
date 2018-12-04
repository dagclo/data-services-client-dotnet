using System.Collections.Generic;
using System.Net.Http;
using Quadient.DataServices.Model.Etl;

namespace Quadient.DataServices.Api.Etl
{
	internal class FileTransformToTableRequest : IRequest<TransformResponse>
	{
		public string ServicePath { get; }
		public HttpMethod Method { get; } = HttpMethod.Post;
		public object Body { get; }
		public IDictionary<string, string> QueryStringParams { get; }
		public IDictionary<string, string> Headers { get; }
		public FileTransformToTableRequest(string fileId) : this(fileId, new TransformRequest()) { }
		public FileTransformToTableRequest(string fileId, TransformRequest req)
		{
			ServicePath = $"etl/v1/files/{fileId}/_transform";
			Body = req;

			if (req.SrcTableIndex == null)
				req.SrcTableIndex = 0;
		}
	}
}
