﻿using System.Collections.Generic;
using System.Net.Http;

namespace Quadient.DataServices.Api.WalkSequence
{
	public class RunWalkSequenceJob : IRequest<object>
	{
		public RunWalkSequenceJob(string jobId)
		{
			ServicePath = $"services/walk-sequence/v1/jobs/{jobId}/_run";
		}

		public string ServicePath { get; }
		public HttpMethod Method { get; } = HttpMethod.Post;
		public object Content { get; set; }
		public IDictionary<string, string> QueryStringParams { get; }
		public object Body => Content;
		public IDictionary<string, string> Headers { get; }
	}
}