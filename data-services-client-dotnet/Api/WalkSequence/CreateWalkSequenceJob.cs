using Quadient.DataServies.Model.WalkSequence;
using System.Collections.Generic;
using System.Net.Http;

namespace Quadient.DataServices.Api.WalkSequence
{
	public class CreateWalkSequenceJob : IRequest<JobCreationRequest, JobSummary>
	{
		public string ServicePath { get; } = "services/walk-sequence/v1/jobs";

		public HttpMethod Method { get; } = HttpMethod.Post;

		public JobCreationRequest Content { get; set; }

		public IDictionary<string, string> QueryStringParams { get; }

		public CreateWalkSequenceJob(JobCreationRequest request)
		{
			Content = request;
		}
	}
}
