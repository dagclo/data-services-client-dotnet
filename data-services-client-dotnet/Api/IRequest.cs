using System.Threading.Tasks;

namespace Quadient.DataServices.Api
{
    public interface IRequest
    {
        Task<IResponse> Invoke(IService service);
    }
}
