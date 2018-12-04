using System.Collections.Generic;
using System.Net.Http;

namespace Quadient.DataServices.Api.WalkSequence
{
	public class DeleteWalkSequenceJob : IRequest<object>
	{
		public DeleteWalkSequenceJob(string jobId)
		{
			ServicePath = $"services/walk-sequence/v1/jobs/{jobId}";
		}

		public string ServicePath { get; }

		public HttpMethod Method { get; } = HttpMethod.Delete;

		public object Content { get; set; }

		public IDictionary<string, string> QueryStringParams { get; }
		public object Body => Content;
		public IDictionary<string, string> Headers { get; }
	}
}