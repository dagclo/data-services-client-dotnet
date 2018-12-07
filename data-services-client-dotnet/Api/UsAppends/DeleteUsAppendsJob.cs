using System.Collections.Generic;
using System.Net.Http;

namespace Quadient.DataServices.Api.UsBatch
{
	public class DeleteUsAppendsJob : IRequest<object>
	{
		public DeleteUsAppendsJob(string jobId)
		{
			ServicePath = $"services/us-appends/v1/jobs/{jobId}";
		}
		public string ServicePath { get; }
		public HttpMethod Method => HttpMethod.Delete;
		public object Body { get; }
		public IDictionary<string, string> QueryStringParams { get; }
		public IDictionary<string, string> Headers { get; }
	}
}
