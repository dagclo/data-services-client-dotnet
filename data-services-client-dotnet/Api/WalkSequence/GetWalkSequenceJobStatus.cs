﻿using System.Collections.Generic;
using System.Net.Http;
using Quadient.DataServies.Model.UsBatch;

namespace Quadient.DataServices.Api.WalkSequence
{
    public class GetWalkSequenceJobStatus : IRequest<object, JobSummary>
    {
        public GetWalkSequenceJobStatus(string jobId)
        {
            ServicePath = $"services/walk-sequence/v1/jobs/{jobId}/status";
        }

        public string ServicePath { get; }

        public HttpMethod Method { get; } = HttpMethod.Get;

        public object Content { get; set; }

        public IDictionary<string, string> QueryStringParams { get; }
    }
}