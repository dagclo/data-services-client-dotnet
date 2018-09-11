using System.Collections.Generic;
using System.Net.Http;
using Quadient.DataServies.Model.UsBatch;

namespace Quadient.DataServices.Api.UsBatch
{
    public class GetUsAppendsRecordPages : IRequest<object, RecordPages>
    {
        public enum RecordKind
        {
            input,
            output
        }

        public GetUsAppendsRecordPages(string jobId, RecordKind kind)
        {
            ServicePath = $"services/us-appends/v1/jobs/{jobId}/records/pages";
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