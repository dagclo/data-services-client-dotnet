using Quadient.DataServies.Model.WalkSequence;
using System.Collections.Generic;
using System.Net.Http;

namespace Quadient.DataServices.Api.WalkSequence
{
	public class CreateWalkSequenceJob : IRequest<JobRequest, JobSummary>
	{
		public string ServicePath { get; } = "/services/walk-sequence/v1/jobs";

		public HttpMethod Method { get; } = HttpMethod.Post;

		public JobRequest Content { get; set; }

		public IDictionary<string, string> QueryStringParams { get; }

		public CreateWalkSequenceJob(JobRequest request)
		{
			Content = request;
		}
	}
}
