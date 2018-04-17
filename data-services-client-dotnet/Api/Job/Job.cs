using System.Net.Http;
using Quadient.DataServices.Model.Job;

namespace Quadient.DataServices.Api.Job
{
    public class Job: IRequest<JobCreationRequest, JobInformationResponse>
    {
        public string ServicePath {get;} = "services/jobs/v1";
        public HttpMethod Method {get;} = HttpMethod.Post;
        public JobCreationRequest Content {get; set;}
    }
}
