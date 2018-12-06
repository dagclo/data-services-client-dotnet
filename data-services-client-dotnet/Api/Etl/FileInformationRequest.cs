using System.Collections.Generic;
using System.Net.Http;
using Quadient.DataServices.Model.Etl;

namespace Quadient.DataServices.Api.Etl
{
	internal class FileInformationRequest : IRequest<FileInformation>
	{
		public string ServicePath { get; }
		public HttpMethod Method => HttpMethod.Get;
		public object Body { get; }
		public IDictionary<string, string> QueryStringParams { get; }
		public IDictionary<string, string> Headers { get; }
		public FileInformationRequest(string fileId)
		{
			ServicePath = $"etl/v1/files/{fileId}";
		}
	}
}
