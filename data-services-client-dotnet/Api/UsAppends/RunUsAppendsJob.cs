using System.Collections.Generic;
using System.Net.Http;

namespace Quadient.DataServices.Api.UsBatch
{
	public class RunUsAppendsJob : IRequest<object>
	{
		public RunUsAppendsJob(string jobId)
		{
			ServicePath = $"services/us-appends/v1/jobs/{jobId}/_run";
		}

		public string ServicePath { get; }
		public HttpMethod Method { get; } = HttpMethod.Post;
		public object Body { get; }
		public IDictionary<string, string> QueryStringParams { get; }
		public IDictionary<string, string> Headers { get; }
	}
}