using System.Collections.Generic;
using System.Net.Http;
using Quadient.DataServices.Model.UsBatch;

namespace Quadient.DataServices.Api.WalkSequence
{
    public class GetWalkSequenceRecordPages : IRequest<RecordPages>
    {
        public enum RecordKind
        {
            input,
            output
        }

        public GetWalkSequenceRecordPages(string jobId, RecordKind kind)
        {
            ServicePath = $"services/walk-sequence/v1/jobs/{jobId}/records/pages";
            QueryStringParams = new Dictionary<string, string>
                {
                     {"kind", kind.ToString()}
                };
        }

        public string ServicePath { get; }
        public HttpMethod Method { get; } = HttpMethod.Get;
        public object Content { get; set; }
        public IDictionary<string, string> QueryStringParams { get; }
        public object Body => Content;
        public IDictionary<string, string> Headers { get; }
    }
}