using Quadient.DataServices.Model.UsBatch;

namespace Quadient.DataServices.Api.WalkSequence
{
	internal class WalkSequenceJobSession : IWalkSequenceJobSession
	{
		private JobSummary resp;

		public WalkSequenceJobSession(string jobId)
		{
			JobId = jobId;
		}
		public WalkSequenceJobSession(WalkSequenceJob job)
		{
			JobId = job.JobId;
		}

		public WalkSequenceJobSession(JobSummary resp)
		{
			JobId = resp.JobId;
		}

		public string JobId { get; }

	}
}