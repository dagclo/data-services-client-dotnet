using System.Collections.Generic;
using System.Net.Http;
using Quadient.DataServices.Model.UsBatch;

namespace Quadient.DataServices.Api.WalkSequence
{
    public class GetWalkSequenceJob : IRequest<object, WalkSequenceJob>
    {
        public GetWalkSequenceJob(string jobId)
        {
            ServicePath = $"services/walk-sequence/v1/jobs/{jobId}";
        }

        public string ServicePath { get; }

        public HttpMethod Method { get; } = HttpMethod.Get;

        public object Content { get; set; }

        public IDictionary<string, string> QueryStringParams { get; }
    }
}