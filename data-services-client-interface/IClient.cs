using System.Threading;
using System.Threading.Tasks;
using Quadient.DataServices.Utility;

namespace Quadient.DataServices.Api
{
    public interface IClient: IServiceCaller
    {
        Task<IJobSession> CreateJob(JobCreationDetails details = null);
        IJobSession ResumeJob(string jobId);
    }
}