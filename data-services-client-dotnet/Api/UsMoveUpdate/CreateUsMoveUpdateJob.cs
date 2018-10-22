using System.Collections.Generic;
using System.Net.Http;
using Quadient.DataServices.Model.UsBatch;

namespace Quadient.DataServices.Api.UsBatch
{
    public class CreateUsMoveUpdateJob : IRequest<MoveUpdateJobCreationRequest, JobSummary>
    {
        public CreateUsMoveUpdateJob(MoveUpdateJobCreationRequest request)
        {
            Content = request;
        }

        public string ServicePath { get; } = "services/us-move-update/v1/jobs";
        public HttpMethod Method { get; } = HttpMethod.Post;
        public MoveUpdateJobCreationRequest Content { get; set; }
        public IDictionary<string, string> QueryStringParams { get; } = new Dictionary<string, string>();
    }
}