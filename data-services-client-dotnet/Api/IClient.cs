using System.Threading;
using System.Threading.Tasks;
using Quadient.DataServices.Utility;

namespace Quadient.DataServices.Api
{
    public interface IClient
    {
        Task<JobSession> CreateJob(string origin = Constants.Origin);
        JobSession ResumeJob(string jobId, string origin = Constants.Origin);
        Task<R> Execute<T, R>(IRequest<T, R> request);
        Task<R> Execute<T, R>(IRequest<T, R> request, CancellationToken cancellationToken);
    }
}