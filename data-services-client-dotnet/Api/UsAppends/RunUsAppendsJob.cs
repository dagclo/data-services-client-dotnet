using System.Collections.Generic;
using System.Net.Http;

namespace Quadient.DataServices.Api.UsBatch
{
    public class RunUsAppendsJob : IRequest<object, object>
    {
        public RunUsAppendsJob(string jobId)
        {
            ServicePath = $"services/us-appends/v1/jobs/{jobId}/_run";
        }

        public string ServicePath { get; }
        public HttpMethod Method { get; } = HttpMethod.Post;
        public object Content { get; set; }
        public IDictionary<string, string> QueryStringParams { get; }
    }
}