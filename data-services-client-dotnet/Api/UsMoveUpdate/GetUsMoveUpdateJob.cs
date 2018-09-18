﻿using System.Collections.Generic;
using System.Net.Http;
using Quadient.DataServies.Model.UsBatch;

namespace Quadient.DataServices.Api.UsBatch
{
    public class GetUsMoveUpdateJob : IRequest<object, MoveUpdateJob>
    {
        public GetUsMoveUpdateJob(string jobId)
        {
            ServicePath = $"services/us-move-update/v1/jobs/{jobId}";
        }

        public string ServicePath { get; }
        public HttpMethod Method { get; } = HttpMethod.Get;
        public object Content { get; set; }
        public IDictionary<string, string> QueryStringParams { get; }
    }
}