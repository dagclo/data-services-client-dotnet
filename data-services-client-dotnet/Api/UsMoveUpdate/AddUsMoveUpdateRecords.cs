using System.Collections.Generic;
using System.Net.Http;
using Quadient.DataServies.Model.UsBatch;

namespace Quadient.DataServices.Api.UsBatch
{
    public class AddUsMoveUpdateRecords : IRequest<Records, object>
    {
        public AddUsMoveUpdateRecords(Records records)
        {
            Content = records;
        }

        public string ServicePath { get; } = "services/us-move-update/v1/records";
        public HttpMethod Method { get; } = HttpMethod.Post;
        public Records Content { get; set; }
        public IDictionary<string, string> QueryStringParams { get; }
    }
}