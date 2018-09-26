﻿using System.Collections.Generic;
using System.Net.Http;
using Quadient.DataServices.Model.UsBatch;

namespace Quadient.DataServices.Api.WalkSequence
{
    public class GetWalkSequenceRecords : IRequest<object, Records>
    {
        public GetWalkSequenceRecords(string jobId, string pageId)
        {
            ServicePath = $"services/walk-sequence/v1/jobs/{jobId}/records/{pageId}";
        }

        public string ServicePath { get; }

        public HttpMethod Method { get; } = HttpMethod.Get;

        public object Content { get; set; }

        public IDictionary<string, string> QueryStringParams { get; }
    }
}