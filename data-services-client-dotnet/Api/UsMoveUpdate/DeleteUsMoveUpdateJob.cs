﻿using System.Collections.Generic;
using System.Net.Http;

namespace Quadient.DataServices.Api.UsBatch
{
	public class DeleteUsMoveUpdateJob : IRequest<object>
	{
		public DeleteUsMoveUpdateJob(string jobId)
		{
			ServicePath = $"services/us-move-update/v1/jobs/{jobId}";
		}

		public string ServicePath { get; }
		public HttpMethod Method => HttpMethod.Delete;
		public object Content { get; set; }
		public IDictionary<string, string> QueryStringParams { get; }
		public object Body => Content;
		public IDictionary<string, string> Headers { get; }
	}
}
