using System.Collections.Generic;
using System.Net.Http;
using Quadient.DataServices.Model.UsBatch;

namespace Quadient.DataServices.Api.UsBatch
{
    public class AddUsMoveUpdateRecords : IRequest<object>
    {
        public AddUsMoveUpdateRecords(string jobId, List<List<string>> records)
        {
            ServicePath = $"services/us-move-update/v1/jobs/{jobId}/records";
            Content = new Records { _Records = records };
        }
        public string ServicePath { get; }
        public HttpMethod Method { get; } = HttpMethod.Post;
        public Records Content { get; }
        public IDictionary<string, string> QueryStringParams { get; }
        public object Body => Content;
        public IDictionary<string, string> Headers { get; }
    }
}