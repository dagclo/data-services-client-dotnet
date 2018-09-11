using System.Collections.Generic;
using System.Net.Http;
using Quadient.DataServies.Model.UsBatch;

namespace Quadient.DataServices.Api.UsBatch
{
    public class CreateUsAppendsJob : IRequest<CreateUsAppendsJob, JobSummary>
    {
        public CreateUsAppendsJob(CreateUsAppendsJob request)
        {
            Content = request;
        }

        public string ServicePath { get; } = "services/us-appends/v1/jobs";
        public HttpMethod Method { get; } = HttpMethod.Post;
        public CreateUsAppendsJob Content { get; set; }
        public IDictionary<string, string> QueryStringParams { get; }
    }
}