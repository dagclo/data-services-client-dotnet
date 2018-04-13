using Quadient.DataServices.Model;

namespace Quadient.DataServices.Api
{
    public interface IResponse
    {
        int GetStatus();
        Headers GetHeaders();
        T GetBody<T>();
    }
}
