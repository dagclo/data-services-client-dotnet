using System.Collections.Generic;
using System.Net.Http;

namespace Quadient.DataServices.Api.WalkSequence
{
	public class RunWalkSequenceJob : IRequest<object>
	{
		public RunWalkSequenceJob(string jobId)
		{
			ServicePath = $"{WalkSequenceClient.BASE_PATH}/jobs/{jobId}/_run";
		}

		public string ServicePath { get; }
		public HttpMethod Method => HttpMethod.Post;
		public object Content { get; set; }
		public IDictionary<string, string> QueryStringParams { get; }
		public object Body => Content;
		public IDictionary<string, string> Headers { get; }
	}
}
