using System.Net.Http;
using Quadient.DataServices.Model.Job;

namespace Quadient.DataServices.Api.Job
{
    public class UpdateStatus: IRequest<JobStatusUpdateRequest, JobStatusInformationResponse>
    {
        public string ServicePath {get; private set;} = $"services/jobs/v1/{0}/job_status";
        public HttpMethod Method {get;} = HttpMethod.Put;
        public JobStatusUpdateRequest Content {get; set;}

        public UpdateStatus(string jobId)
        {
            ServicePath = string.Format(ServicePath, jobId);
        }

        public UpdateStatus(string jobId, JobStatus status)
        {
            ServicePath = string.Format(ServicePath, jobId);
            Content = new JobStatusUpdateRequest
            {
                JobStatus = status
            };
        }
    }
}
