using System.Threading.Tasks;
using Quadient.DataServices.Model;
using Quadient.DataServices.Model.Job;

namespace Quadient.DataServices.Api
{
    public class JobSession: Service
    {
        private JobInformationResponse JobInformation {get; set;}
        public string JobId {get; set;}

        public JobSession (ICredentials credentials, IConfiguration configuration): base(credentials, configuration)
        {}

        public async Task<JobInformationResponse> Initialize()
        {
            var request = new Job.Job();
            var job = await Execute(request);
            JobInformation = job;
            JobId = job.JobId;
            return job;
        }
    }
}
