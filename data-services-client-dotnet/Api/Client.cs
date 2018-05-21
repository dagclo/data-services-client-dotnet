using System.Threading.Tasks;
using Quadient.DataServices.Model;
using Quadient.DataServices.Utility;

namespace Quadient.DataServices.Api
{
    public class Client: Service, IClient
    {
        public Client(ICredentials credentials): base (credentials)
        {}

        public Client(ICredentials credentials, IConfiguration configuration): base(credentials, configuration)
        {}

        public Client(ISessionToken token, IConfiguration configuration = null) : base(token, configuration)
        { }

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
            return await base.Execute(request);
        }

        private JobSession CreateJobSession(string origin)
        {
            return SessionToken == null
                ? new JobSession(Credentials, Configuration, origin)
                : new JobSession(SessionToken, Configuration, origin);
        }
    }
}
