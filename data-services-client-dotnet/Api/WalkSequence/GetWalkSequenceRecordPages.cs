using Quadient.DataServies.Model.WalkSequence;
using System.Collections.Generic;
using System.Net.Http;

namespace Quadient.DataServices.Api.WalkSequence
{
    public class GetWalkSequenceRecordPages : IRequest<object, RecordPages>
    {
        public enum RecordKind
        {
            input,
            output
        }

        public string ServicePath { get; }

        public HttpMethod Method { get; } = HttpMethod.Get;

        public object Content { get; set; }

        public IDictionary<string, string> QueryStringParams { get; }

        public GetWalkSequenceRecordPages(string jobId, RecordKind kind)
        {
            ServicePath = $"services/walk-sequence/v1/jobs/{jobId}/records/pages";
            QueryStringParams = new Dictionary<string, string>
            {
                {"kind", kind.ToString()}
            };
        }
    }
}
