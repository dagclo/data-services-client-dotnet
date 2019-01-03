using System.Collections.Generic;
using System.IO;
using System.Net.Http;
using Quadient.DataServices.Model.Etl;

namespace Quadient.DataServices.Api.Etl
{
	public class FileUploadRequest : IRequest<FileInformation>
	{
		public string ServicePath { get; }
		public HttpMethod Method => HttpMethod.Post;
		public object Body { get; }
		public IDictionary<string, string> QueryStringParams { get; }
		public IDictionary<string, string> Headers { get; }

		public FileUploadRequest(FileInfo fileInfo) : this(fileInfo.OpenRead()) { }
		public FileUploadRequest(string file) : this(new FileStream(file, FileMode.Open)) { }
		public FileUploadRequest(Stream stream)
		{
			ServicePath = "etl/v1/files";
			var formData = new MultipartFormDataContent();
			HttpContent fileContent = new StreamContent(stream);
			FileStream fs = stream as FileStream;
			formData.Add(fileContent, "upfile", fs.Name);
			Body = formData;
		}
	}
}
