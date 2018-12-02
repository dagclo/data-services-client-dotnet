using System.Threading;
using System.Threading.Tasks;

namespace Quadient.DataServices.Api
{
    public interface IClient: IServiceCaller
    {
        Task<IJobSession> CreateJob(JobCreationDetails details = null);
        IJobSession ResumeJob(string jobId);
    }
}