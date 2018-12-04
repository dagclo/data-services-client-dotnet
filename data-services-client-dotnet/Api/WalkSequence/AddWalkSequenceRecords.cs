﻿using System.Collections.Generic;
using System.Net.Http;
using Quadient.DataServices.Model.UsBatch;

namespace Quadient.DataServices.Api.WalkSequence
{
	public class AddWalkSequenceRecords : IRequest<object>
	{
		public AddWalkSequenceRecords(string jobId, List<List<string>> records)
		{
			ServicePath = $"{WalkSequenceClient.BASE_PATH}/jobs/{jobId}/records";
			Content = new Records { _Records = records };
		}

		public string ServicePath { get; }
		public HttpMethod Method { get; } = HttpMethod.Post;
		public Records Content { get; set; }
		public IDictionary<string, string> QueryStringParams { get; }
		public object Body => Content;
		public IDictionary<string, string> Headers { get; }
	}
}