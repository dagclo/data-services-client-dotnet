using System.Collections.Generic;
using System.Net.Http;
using Quadient.DataServices.Model.Job;

namespace Quadient.DataServices.Api.Job
{
    /// <summary>
    /// Updates the status of a job. Only certain job status transitions are possible. You cannot go back from a finite state like `SUCCESS` or `FAILURE`, and you cannot go back to an initial state like `CREATED` once the job has started.
    /// </summary>
    public class UpdateStatus : IRequest<JobStatusInformationResponse>
    {
        public string ServicePath { get; private set; }
        public HttpMethod Method { get; } = HttpMethod.Put;
        public IDictionary<string, string> QueryStringParams { get; }
        public object Body => Content;
        public IDictionary<string, string> Headers { get; }
        private JobStatusUpdateRequest Content { get; set; }

        /// <summary>
        /// Updates the status of a job. Only certain job status transitions are possible. You cannot go back from a finite state like `SUCCESS` or `FAILURE`, and you cannot go back to an initial state like `CREATED` once the job has started.
        /// </summary>
        /// <param name="jobId"></param>
        /// <param name="status"></param>
        /// <param name="jobStatusDetails"></param>
        public UpdateStatus(string jobId, Model.Job.JobStatus status, IDictionary<string, object> jobStatusDetails)
        {
            ServicePath = $"jobs/v1/{jobId}/job_status";
            Content = new JobStatusUpdateRequest
            {
                JobStatus = status,
                JobStatusDetails = jobStatusDetails
            };
        }
    }
}
