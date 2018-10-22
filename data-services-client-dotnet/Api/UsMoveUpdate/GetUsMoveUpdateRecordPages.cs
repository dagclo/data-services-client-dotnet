using System.Collections.Generic;
using System.Net.Http;
using Quadient.DataServices.Model.UsBatch;

namespace Quadient.DataServices.Api.UsBatch
{
    public class GetUsMoveUpdateRecordPages : IRequest<object, RecordPages>
    {
        public enum RecordKind
        {
            input,
            output
        }

        public GetUsMoveUpdateRecordPages(string jobId, RecordKind kind)
        {
            ServicePath = $"services/us-move-update/v1/jobs/{jobId}/records/pages";
            QueryStringParams = new Dictionary<string, string>
            {
                {"kind", kind.ToString()}
            };
        }

        public string ServicePath { get; }
        public HttpMethod Method { get; } = HttpMethod.Get;
        public object Content { get; set; }
        public IDictionary<string, string> QueryStringParams { get; }
    }
}