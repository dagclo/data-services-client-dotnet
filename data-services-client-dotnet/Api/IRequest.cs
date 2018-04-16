using System.Threading.Tasks;
using Quadient.DataServices.Model;

namespace Quadient.DataServices.Api
{
    public interface IRequest<T,R>
    {
        Task<IResponse<R>> Invoke();
        void Initialize(ICredentials credentials, IConfiguration configuration);
    }
}
