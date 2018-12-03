using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace Quadient.DataServices.Api
{
    public interface IJobSession : IServiceCaller
    {
        string JobId { get; }

        void UpdateJobStatus(JobStatus status, IDictionary<string, object> JobStatusDetails = null);

        void CloseJob(FiniteJobStatus status, IDictionary<string, object> JobStatusDetails = null);
    }
}