using System.Collections.Generic;
using System.IO;
using System.Net.Http;
using Quadient.DataServices.Model.Etl;

namespace Quadient.DataServices.Api.Etl
{
	public class TableCreationFileUploadRequest : IRequest<TableInformation>
	{
		public string ServicePath => "etl/v1/tables";
		public HttpMethod Method => HttpMethod.Post;
		public object Body { get; }
		public IDictionary<string, string> QueryStringParams { get; }
		public IDictionary<string, string> Headers { get; }

		public TableCreationFileUploadRequest(FileInfo fileInfo) : this(fileInfo.Name, fileInfo.OpenRead()) { }
		public TableCreationFileUploadRequest(string sourceFile) : this(new FileInfo(sourceFile)) { }
		public TableCreationFileUploadRequest(string fileName, Stream stream)
		{
			var formData = new MultipartFormDataContent();
			HttpContent fileContent = new StreamContent(stream);
			formData.Add(fileContent, "upfile", fileName);
			Body = formData;
		}
	}
}
