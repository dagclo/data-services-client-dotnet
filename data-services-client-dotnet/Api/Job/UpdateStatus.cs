using System.Collections.Generic;
using System.Net.Http;
using Quadient.DataServices.Model.Job;

namespace Quadient.DataServices.Api.Job
{
    public class UpdateStatus: IRequest<JobStatusUpdateRequest, JobStatusInformationResponse>
    {
        public string ServicePath {get; private set;}
        public HttpMethod Method {get;} = HttpMethod.Put;
        public JobStatusUpdateRequest Content {get; set;}
        public IDictionary<string, string> QueryStringParams { get; }

        public UpdateStatus(string jobId)
        {
            ServicePath = string.Format(ServicePath, jobId);
        }

        public UpdateStatus(string jobId, JobStatus status)
        {
            ServicePath = $"jobs/v1/{jobId}/job_status";
            Content = new JobStatusUpdateRequest
            {
                JobStatus = status
            };
        }
    }
}
