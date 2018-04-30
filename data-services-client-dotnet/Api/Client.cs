using System.Threading.Tasks;
using Quadient.DataServices.Model;
using Quadient.DataServices.Utility;

namespace Quadient.DataServices.Api
{
    public class Client: Service
    {
        public Client(ICredentials credentials): base (credentials)
        {}

        public Client(ICredentials credentials, IConfiguration configuration): base(credentials, configuration)
        {}

        public async Task<JobSession> CreateJob(string origin = Constants.Origin)
        {
            var session = new JobSession(Credentials, Configuration, origin);
            await session.Initialize();
            return session;
        }

        public JobSession ResumeJob(string jobId, string origin = Constants.Origin)
        {
            return new JobSession(Credentials, Configuration, origin)
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
