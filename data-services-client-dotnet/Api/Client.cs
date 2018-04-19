using System.Threading.Tasks;
using Quadient.DataServices.Api.Job;
using Quadient.DataServices.Model;
using Quadient.DataServices.Model.Job;

namespace Quadient.DataServices.Api
{
    public class Client: Service
    {
        public Client(ICredentials credentials): base (credentials)
        {}

        public Client(ICredentials credentials, IConfiguration configuration): base(credentials, configuration)
        {}

        public async Task<JobSession> CreateJob()
        {
            var session = new JobSession(Credentials, Configuration);
            await session.Initialize();
            return session;
        }

        public JobSession ResumeJob(string jobId)
        {
            return new JobSession(Credentials, Configuration)
            {
                JobId = jobId
            };
        }

        public async Task<R> Execute<T,R>(IRequest<T,R> request)
        {
            return await base.Execute(request);
        }
    }
}
