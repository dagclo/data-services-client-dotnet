using System.Collections.Generic;
using System.IO;
using System.Net.Http;
using Quadient.DataServices.Model.Etl;

namespace Quadient.DataServices.Api.Etl
{
	public class TableCreationFileUploadRequest : IRequest<TableInformation>
	{
		public string ServicePath { get; }
		public HttpMethod Method { get; } = HttpMethod.Post;
		public object Body { get; }
		public IDictionary<string, string> QueryStringParams { get; }
		public IDictionary<string, string> Headers { get; }

		public TableCreationFileUploadRequest(FileInfo fileInfo) : this(fileInfo.OpenRead()) { }
		public TableCreationFileUploadRequest(string file) : this(new FileStream(file, FileMode.Open)) { }
		public TableCreationFileUploadRequest(Stream stream)
		{
			ServicePath = "etl/v1/tables";
			var formData = new MultipartFormDataContent();
			HttpContent fileContent = new StreamContent(stream);
			formData.Add(fileContent, "upfile");
			Body = formData;
		}
	}
}
