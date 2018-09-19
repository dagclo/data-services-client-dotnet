﻿using System.Collections.Generic;
using System.Net.Http;
using Quadient.DataServies.Model.UsBatch;

namespace Quadient.DataServices.Api.UsBatch
{
    public class AddUsMoveUpdateRecords : IRequest<Records, object>
    {
        public AddUsMoveUpdateRecords(string jobId, List<List<string>> records)
        {
            ServicePath = $"services/us-move-update/v1/jobs/{jobId}/records";
            Content = new Records {_Records = records};
        }

        public string ServicePath { get; }
        public HttpMethod Method { get; } = HttpMethod.Post;
        public Records Content { get; set; }
        public IDictionary<string, string> QueryStringParams { get; }
    }
}