using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Quadient.DataServices.Api.Job;
using Quadient.DataServices.Model;
using Quadient.DataServices.Model.Job;

namespace Quadient.DataServices.Api
{
    public class JobSession: IDisposable
    {
        private IDictionary<string, string> Headers {get; set;}
        public string JobId {get; set;}
        private string Origin {get; set;}
        private readonly Service _service;

        public JobSession (ICredentials credentials, IConfiguration configuration, string origin)
        {
            Origin = origin;
            _service = new Service(credentials, configuration);
        }

        public JobSession(ISessionToken token, IConfiguration configuration, string origin)
        {
            Origin = origin;
            _service = new Service(token, configuration);
        }

        internal JobSession(Service service, string origin)
        {
            Origin = origin;
            _service = service;
        }

        public async Task<JobInformationResponse> Initialize()
        {
            var request = new CreateJob(Origin);
            var job = await Execute(request);
            JobId = job.JobId;
            Origin = job.Origin;
            Headers = new Dictionary<string, string>
            {
                { "Job-ID", JobId },
                { "Origin", Origin }
            };
            return job;
        }

        public async Task<R> Execute<T,R>(IRequest<T,R> request)
        {
            return await _service.Execute(request, Headers);
        }

        public async void Dispose()
        {
            await _service.Execute(new UpdateStatus(JobId, JobStatus.SUCCESS));
        }
    }
}
