using System.Collections.Generic;
using System.Net.Http;
using Quadient.DataServices.Model.UsBatch;

namespace Quadient.DataServices.Api.UsBatch
{
    public class GetUsAppendsJob : IRequest<object, USAppendsJob>
    {
        public GetUsAppendsJob(string jobId)
        {
            ServicePath = $"services/us-appends/v1/jobs/{jobId}";
        }

        public string ServicePath { get; }
        public HttpMethod Method { get; } = HttpMethod.Get;
        public object Content { get; set; }
        public IDictionary<string, string> QueryStringParams { get; }
    }
}