using System.Threading.Tasks;
using Quadient.DataServices.Model;
using Quadient.DataServices.Utility;

namespace Quadient.DataServices.Api
{
    public class Client
    {
        readonly IService _service;

        public Client(ICredentials credentials)
        {
            _service = new Service(credentials, new Configuration());
        }

        public Client(ICredentials credentials, IConfiguration configuration)
        {
            _service = new Service(credentials, configuration);
        }

        public async Task<IResponse> Execute(IRequest request)
        {
            return await request.Invoke(_service);
        }
    }
}
