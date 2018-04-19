using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Quadient.DataServices.Api.Job;
using Quadient.DataServices.Model;
using Quadient.DataServices.Model.Job;

namespace Quadient.DataServices.Api
{
    public class JobSession: Service, IDisposable
    {
        private JobInformationResponse JobInformation {get; set;}
        private IDictionary<string, string> Headers {get; set;}
        public string JobId {get; set;}

        public JobSession (ICredentials credentials, IConfiguration configuration): base(credentials, configuration)
        {}

        public async Task<JobInformationResponse> Initialize()
        {
            var request = new CreateJob();
            var job = await Execute(request);
            JobInformation = job;
            JobId = job.JobId;
            Headers = new Dictionary<string, string>
            {
                { "Job-ID", JobId }
            };
            return job;
        }

        public async Task<R> Execute<T,R>(IRequest<T,R> request)
        {
            return await Execute(request, Headers);
        }

        public async void Dispose()
        {
            await Execute(new UpdateStatus(JobId, JobStatus.SUCCESS));
        }
    }
}
