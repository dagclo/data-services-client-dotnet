using System.Collections.Generic;
using System.Net.Http;
using Quadient.DataServies.Model.UsBatch;

namespace Quadient.DataServices.Api.UsBatch
{
    public class GetUsAppendsJobStatus : IRequest<object, JobSummary>
    {
        public GetUsAppendsJobStatus(string jobId)
        {
            ServicePath = $"services/us-appends/v1/jobs/{jobId}/status";
        }

        public string ServicePath { get; }
        public HttpMethod Method { get; } = HttpMethod.Get;
        public object Content { get; set; }
        public IDictionary<string, string> QueryStringParams { get; }
    }
}