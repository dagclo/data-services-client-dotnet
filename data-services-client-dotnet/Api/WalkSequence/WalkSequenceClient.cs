using System.Threading.Tasks;
using Quadient.DataServices.Model.UsBatch;

namespace Quadient.DataServices.Api.WalkSequence
{
	public class WalkSequenceClient : IWalkSequenceClient
	{
		public const string BASE_PATH = "services/walk-sequence/v1";
		private readonly IClient _client;
		public WalkSequenceClient(IClient client)
		{
			_client = client;
		}
		public async Task<IWalkSequenceJobSession> CreateJob(WalkSequenceJobCreationRequest req)
		{
			var resp = await _client.Execute(new CreateWalkSequenceJob(req));
			return new WalkSequenceJobSession(resp);
		}
		public async Task<IWalkSequenceJobSession> GetJob(string jobId)
		{
			var resp = await _client.Execute(new GetWalkSequenceJob(jobId));
			return new WalkSequenceJobSession(resp);
		}
		public Task<JobSummaryCollection> GetJobs()
		{
			return _client.Execute(SimpleRequest<JobSummaryCollection>.Get($"{BASE_PATH}/jobs"));
		}
	}
}
