using Quadient.DataServices.Model.Job;
using System.Collections.Generic;
using System.Net.Http;

namespace Quadient.DataServices.Api.Job
{
    /// <summary>
    /// Gets information about a job, referred to by it's job_id.
    /// </summary>
    public class GetJob : IRequest<JobDetailedResponse>
    {
        public string ServicePath { get; }
        public HttpMethod Method => HttpMethod.Get;
        public object Body { get; }
        public IDictionary<string, string> QueryStringParams { get; }
        public IDictionary<string, string> Headers { get; }

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
