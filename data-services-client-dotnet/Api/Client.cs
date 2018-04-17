using System.Threading.Tasks;
using Quadient.DataServices.Model;

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
    }
}
