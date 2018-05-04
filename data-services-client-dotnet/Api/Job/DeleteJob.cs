using System.Collections.Generic;
using System.Net.Http;

namespace Quadient.DataServices.Api.Job
{
    public class DeleteJob : IRequest<object, object>
    {
        public string ServicePath { get; }
        public HttpMethod Method { get; } = HttpMethod.Delete;
        public object Content { get; set; }
        public IDictionary<string, string> QueryStringParams { get; }

        public DeleteJob(string jobId)
        {
            ServicePath = $"jobs/v1/{jobId}";
        }
    }
}
