using System.Threading.Tasks;
using Quadient.DataServices.Model;
using Quadient.DataServices.Utility;

namespace Quadient.DataServices.Api
{
    public class Client
    {
        private ICredentials Credentials {get; set;}
        private IConfiguration Configuration {get; set;}

        public Client(ICredentials credentials)
        {
            Credentials = credentials ;
            Configuration = new Configuration();
        }

        public Client(ICredentials credentials, IConfiguration configuration)
        {
            Credentials = credentials ;
            Configuration = configuration;
        }

        public async Task<IResponse<R>> Execute<T,R>(IRequest<T,R> request)
        {
            request.Initialize(Credentials, Configuration);
            return await request.Invoke();
        }
    }
}
