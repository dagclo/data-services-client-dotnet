using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Net.Http;
using Quadient.DataServices.Model.Job;
using Quadient.DataServies.Model.UsBatch;

namespace Quadient.DataServices.Api.WalkSequence
{
    public class CreateWalkSequenceJob : IRequest<JobCreationRequest, JobSummary>
    {
        public CreateWalkSequenceJob(JobCreationRequest request)
        {
            Content = request;
        }

        public string ServicePath { get; } = "services/walk-sequence/v1/jobs";

        public HttpMethod Method { get; } = HttpMethod.Post;

        public JobCreationRequest Content { get; set; }

        public IDictionary<string, string> QueryStringParams { get; } = new Dictionary<string, string>();
    }
}