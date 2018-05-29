using Quadient.DataServices.Model.Job;
using System.Collections.Generic;
using System.Net.Http;

namespace Quadient.DataServices.Api.Job
{
    /// <summary>
    /// Gets information about a job, referred to by it's job_id.
    /// </summary>
    public class GetJob : IRequest<object, JobDetailedResponse>
    {
        public string ServicePath { get; }
        public HttpMethod Method { get; } = HttpMethod.Get;
        public object Content { get; set; }
        public IDictionary<string, string> QueryStringParams { get; }

        /// <summary>
        /// Gets information about a job, referred to by it's job_id.
        /// </summary>
        /// <param name="jobId"></param>
        public GetJob(string jobId)
        {
            ServicePath = $"jobs/v1/{jobId}";
        }
    }
}
