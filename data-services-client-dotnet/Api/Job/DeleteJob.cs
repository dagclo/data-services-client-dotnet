using System.Collections.Generic;
using System.Net.Http;

namespace Quadient.DataServices.Api.Job
{
    /// <summary>
    /// Sets the job status to DELETED. This is essentially a convenience shortcut for calling `POST /jobs/v1/{job_id}/job_status` with a payload containing the `DELETED` job status.
    /// </summary>
    public class DeleteJob : IRequest<object, object>
    {
        public string ServicePath { get; }
        public HttpMethod Method { get; } = HttpMethod.Delete;
        public object Content { get; set; }
        public IDictionary<string, string> QueryStringParams { get; }

        /// <summary>
        /// Sets the job status to DELETED. This is essentially a convenience shortcut for calling `POST /jobs/v1/{job_id}/job_status` with a payload containing the `DELETED` job status.
        /// </summary>
        /// <param name="jobId"></param>
        public DeleteJob(string jobId)
        {
            ServicePath = $"jobs/v1/{jobId}";
        }
    }
}
