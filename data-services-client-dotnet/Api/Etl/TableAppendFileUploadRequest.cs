using System.Collections.Generic;
using System.IO;
using System.Net.Http;
using Quadient.DataServices.Model.Etl;

namespace Quadient.DataServices.Api.Etl
{
	public class TableAppendFileUploadRequest : IRequest<TableUpdateResponse>
	{
		public string ServicePath { get; }
		public HttpMethod Method => HttpMethod.Post;
		public object Body { get; }
		public IDictionary<string, string> QueryStringParams { get; }
		public IDictionary<string, string> Headers { get; }

		public TableAppendFileUploadRequest(string tableId, FileInfo fileInfo) : this(tableId, fileInfo.OpenRead()) { }
		public TableAppendFileUploadRequest(string tableId, string file) : this(tableId, new FileStream(file, FileMode.Open)) { }
		public TableAppendFileUploadRequest(string tableId, Stream stream)
		{
			ServicePath = $"etl/v1/tables/{tableId}";
			var formData = new MultipartFormDataContent();
			HttpContent fileContent = new StreamContent(stream);
			FileStream fs = stream as FileStream;
			formData.Add(fileContent, "upfile", fs.Name);
			Body = formData;
		}
	}
}
