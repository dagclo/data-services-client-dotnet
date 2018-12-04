using System.Threading.Tasks;
using Quadient.DataServices.Model.UsBatch;

namespace Quadient.DataServices.Api.WalkSequence
{
	public interface IWalkSequenceClient
	{
		Task<IWalkSequenceJobSession> CreateJob(WalkSequenceJobCreationRequest req);
		Task<IWalkSequenceJobSession> GetJob(string jobId);
		Task<JobSummaryCollection> GetJobs();
	}
}