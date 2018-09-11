using System.Collections.Generic;
using System.Net.Http;
using Quadient.DataServies.Model.UsBatch;

namespace Quadient.DataServices.Api.WalkSequence
{
    public class AddWalkSequenceRecords : IRequest<Records, object>
    {
        public AddWalkSequenceRecords(string jobId, List<List<string>> records)
        {
            ServicePath = $"services/walk-sequence/v1/jobs/{jobId}/records";
            Content = new Records {_Records = records};
        }

        public string ServicePath { get; }

        public HttpMethod Method { get; } = HttpMethod.Post;

        public Records Content { get; set; }

        public IDictionary<string, string> QueryStringParams { get; }
    }
}