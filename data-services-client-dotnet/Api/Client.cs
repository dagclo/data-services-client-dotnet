using System.Threading.Tasks;
using Quadient.DataServices.Model;
using Quadient.DataServices.Utility;

namespace Quadient.DataServices.Api
{
    public class Client: IClient
    {
        private readonly Service _service;

        public Client(ICredentials credentials, IConfiguration configuration = null)
        {
            _service = new Service(credentials, configuration);
        }

        public Client(ISessionToken token, IConfiguration configuration = null)
        {
            _service = new Service(token, configuration);
        }

        public async Task<JobSession> CreateJob(string origin = Constants.Origin)
        {
            var session = CreateJobSession(origin);
            await session.Initialize();
            return session;
        }

        public JobSession ResumeJob(string jobId, string origin = Constants.Origin)
        {
            var jobSession = CreateJobSession(origin);
            jobSession.JobId = jobId;
            return jobSession;
        }

        public async Task<R> Execute<T,R>(IRequest<T,R> request)
        {
            return await _service.Execute(request);
        }

        private JobSession CreateJobSession(string origin)
        {
            return new JobSession(_service, origin);
        }
    }
}
