using System.Collections.Generic;
using System.Net.Http;

namespace Quadient.DataServices.Api.UsBatch
{
    public class DeleteUsMoveUpdateJob : IRequest<object, object>
    {
        public DeleteUsMoveUpdateJob(string jobId)
        {
            ServicePath = $"services/us-move-update/v1/jobs/{jobId}";
        }

        public string ServicePath { get; }
        public HttpMethod Method { get; } = HttpMethod.Delete;
        public object Content { get; set; }
        public IDictionary<string, string> QueryStringParams { get; }
    }
}