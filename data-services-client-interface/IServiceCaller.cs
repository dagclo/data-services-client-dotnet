using System.Threading;
using System.Threading.Tasks;

namespace Quadient.DataServices.Api
{
	public interface IServiceCaller
	{
		Task<R> Execute<R>(IRequest<R> request);
		Task<R> Execute<R>(IRequest<R> request, CancellationToken cancellationToken);
	}
}