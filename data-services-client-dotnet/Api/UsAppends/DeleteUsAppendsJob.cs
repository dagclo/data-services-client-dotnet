﻿using System.Collections.Generic;
using System.Net.Http;

namespace Quadient.DataServices.Api.UsBatch
{
    public class DeleteUsAppendsJob : IRequest<object, object>
    {
        public DeleteUsAppendsJob(string jobId)
        {
            ServicePath = $"services/us-appends/v1/jobs/{jobId}";
        }

        public string ServicePath { get; }
        public HttpMethod Method { get; } = HttpMethod.Delete;
        public object Content { get; set; }
        public IDictionary<string, string> QueryStringParams { get; }
    }
}