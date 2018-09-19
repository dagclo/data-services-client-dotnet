using System.Collections.Generic;
using System.Net.Http;
using Quadient.DataServies.Model.UsBatch;

namespace Quadient.DataServices.Api.UsBatch
{
    public class CreateUsAppendsJob : IRequest<USAppendsJobCreationRequest, JobSummary>
    {
        public CreateUsAppendsJob(USAppendsJobCreationRequest request)
        {
            Content = request;
        }

        public string ServicePath { get; } = "services/us-appends/v1/jobs";
        public HttpMethod Method { get; } = HttpMethod.Post;
        public USAppendsJobCreationRequest Content { get; set; }
        public IDictionary<string, string> QueryStringParams { get; } = new Dictionary<string, string>();
    }
}