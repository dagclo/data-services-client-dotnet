using System.Net.Http;
using Quadient.DataServices.Model.Job;
using Quadient.DataServices.Utility;

namespace Quadient.DataServices.Api.Job
{
    public class CreateJob: IRequest<JobCreationRequest, JobInformationResponse>
    {
        public string ServicePath {get;} = "jobs/v1";
        public HttpMethod Method {get;} = HttpMethod.Post;
        public JobCreationRequest Content {get; set;}

        public CreateJob()
        {
            Content = new JobCreationRequest(Constants.Origin);
        }
    }
}
