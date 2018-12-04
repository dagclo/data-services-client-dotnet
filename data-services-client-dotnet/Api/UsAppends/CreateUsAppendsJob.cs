using System.Collections.Generic;
using System.Net.Http;
using Quadient.DataServices.Model.UsBatch;

namespace Quadient.DataServices.Api.UsBatch
{
	public class CreateUsAppendsJob : IRequest<JobSummary>
	{
		public CreateUsAppendsJob(USAppendsJobCreationRequest request)
		{
			Body = request;
		}
		public string ServicePath { get; } = "services/us-appends/v1/jobs";
		public HttpMethod Method { get; } = HttpMethod.Post;
		public object Body { get; }
		public IDictionary<string, string> QueryStringParams { get; } = new Dictionary<string, string>();
		public IDictionary<string, string> Headers { get; }
	}
}
