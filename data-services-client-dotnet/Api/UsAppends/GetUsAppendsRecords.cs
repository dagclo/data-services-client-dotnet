using System.Collections.Generic;
using System.Net.Http;
using Quadient.DataServices.Model.UsBatch;

namespace Quadient.DataServices.Api.UsBatch
{
    public class GetUsAppendsRecords : IRequest<Records>
    {
        public GetUsAppendsRecords(string jobId, string pageId)
        {
            ServicePath = $"services/us-appends/v1/jobs/{jobId}/records/{pageId}";
        }

        public string ServicePath { get; }
        public HttpMethod Method { get; } = HttpMethod.Get;
        public object Body { get; }
        public IDictionary<string, string> QueryStringParams { get; }
        public IDictionary<string, string> Headers { get; }
    }
}