using Quadient.DataServies.Model.WalkSequence;
using System.Collections.Generic;
using System.Net.Http;

namespace Quadient.DataServices.Api.WalkSequence
{
    public class GetWalkSequenceJobStatus : IRequest<object, JobSummary>
    {
        public string ServicePath { get; }

        public HttpMethod Method { get; } = HttpMethod.Get;

        public object Content { get; set; }

        public IDictionary<string, string> QueryStringParams { get; }

        public GetWalkSequenceJobStatus(string jobId)
        {
            ServicePath = $"services/walk-sequence/v1/jobs/{jobId}/status";
        }
    }
}
