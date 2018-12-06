using System.Collections.Generic;
using System.Net.Http;
using Quadient.DataServices.Model.UsBatch;

namespace Quadient.DataServices.Api.UsBatch
{
    public class GetUsAppendsJobStatus : IRequest<JobSummary>
    {
        public GetUsAppendsJobStatus(string jobId)
        {
            ServicePath = $"services/us-appends/v1/jobs/{jobId}/status";
        }
        public string ServicePath { get; }
        public HttpMethod Method => HttpMethod.Get;
        public object Body { get; }
        public IDictionary<string, string> QueryStringParams { get; }
        public IDictionary<string, string> Headers { get; }
    }
}