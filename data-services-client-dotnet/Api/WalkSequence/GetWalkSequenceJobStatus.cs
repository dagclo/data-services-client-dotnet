using System.Collections.Generic;
using System.Net.Http;
using Quadient.DataServices.Model.UsBatch;

namespace Quadient.DataServices.Api.WalkSequence
{
	public class GetWalkSequenceJobStatus : IRequest<JobSummary>
	{
		public GetWalkSequenceJobStatus(string jobId)
		{
			ServicePath = $"services/walk-sequence/v1/jobs/{jobId}/status";
		}

		public string ServicePath { get; }

		public HttpMethod Method { get; } = HttpMethod.Get;

		public object Content { get; set; }

		public IDictionary<string, string> QueryStringParams { get; }
		public object Body => Content;
		public IDictionary<string, string> Headers { get; }
	}
}