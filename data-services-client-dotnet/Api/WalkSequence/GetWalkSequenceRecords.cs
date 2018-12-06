using System.Collections.Generic;
using System.Net.Http;
using Quadient.DataServices.Model.UsBatch;

namespace Quadient.DataServices.Api.WalkSequence
{
	public class GetWalkSequenceRecords : IRequest<Records>
	{
		public GetWalkSequenceRecords(string jobId, string pageId)
		{
			ServicePath = $"{WalkSequenceClient.BASE_PATH}/jobs/{jobId}/records/{pageId}";
		}

		public string ServicePath { get; }
		public HttpMethod Method => HttpMethod.Get;
		public object Content { get; set; }
		public IDictionary<string, string> QueryStringParams { get; }
		public object Body => Content;
		public IDictionary<string, string> Headers { get; }
	}
}
