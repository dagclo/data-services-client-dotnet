using System;
using System.Threading;
using System.Threading.Tasks;

namespace Quadient.DataServices.Api
{
	public interface IJobSession : IServiceCaller
	{
		string getJobId();

		void updateJobStatus(JobStatus status);

		void closeJob(FiniteJobStatus status);
	}
}