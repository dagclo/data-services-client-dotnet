using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Net.Http;
using Quadient.DataServices.Model.Job;
using Quadient.DataServices.Model.UsBatch;

namespace Quadient.DataServices.Api.WalkSequence
{
	public class CreateWalkSequenceJob : IRequest<JobSummary>
	{
		public CreateWalkSequenceJob(WalkSequenceJobCreationRequest request)
		{
			Content = request;
		}

		public string ServicePath => "services/walk-sequence/v1/jobs";

		public HttpMethod Method => HttpMethod.Post;

		public WalkSequenceJobCreationRequest Content { get; set; }

		public IDictionary<string, string> QueryStringParams { get; } = new Dictionary<string, string>();
		public object Body => Content;
		public IDictionary<string, string> Headers { get; }
	}
}
