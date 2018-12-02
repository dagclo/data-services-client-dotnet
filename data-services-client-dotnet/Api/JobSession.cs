using Quadient.DataServices.Api.Job;
using Quadient.DataServices.Model;
using Quadient.DataServices.Model.Job;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using Quadient.DataServices.Utility;
using System.Threading;

namespace Quadient.DataServices.Api
{
	internal class JobSession : IJobSession
	{
		public string JobId { get; }

		private readonly IServiceCaller _serviceCaller;

		public JobSession(IServiceCaller serviceCaller, string jobId)
		{
			_serviceCaller = serviceCaller;
			JobId = jobId;
		}

		void IJobSession.UpdateJobStatus(JobStatus jobStatus, IDictionary<string, object> JobStatusDetails)
		{
			Model.Job.JobStatus status;
			switch (jobStatus)
			{
				case JobStatus.CANCELLED:
					status = Model.Job.JobStatus.CANCELLED;
					break;
				case JobStatus.CREATED:
					status = Model.Job.JobStatus.CREATED;
					break;
				case JobStatus.DELETED:
					status = Model.Job.JobStatus.DELETED;
					break;
				case JobStatus.FAILURE:
					status = Model.Job.JobStatus.FAILURE;
					break;
				case JobStatus.READY_TO_RUN:
					status = Model.Job.JobStatus.READYTORUN;
					break;
				case JobStatus.STARTED:
					status = Model.Job.JobStatus.STARTED;
					break;
				case JobStatus.SUCCESS:
					status = Model.Job.JobStatus.SUCCESS;
					break;
				case JobStatus.WAITING:
					status = Model.Job.JobStatus.WAITING;
					break;
				default:
					throw new ArgumentException("Unsupported job status: " + Enum.GetName(typeof(JobStatus), jobStatus));
			}
			_serviceCaller.Execute(new UpdateStatus(JobId, status, JobStatusDetails));
		}

		void IJobSession.CloseJob(FiniteJobStatus jobStatus, IDictionary<string, object> JobStatusDetails)
		{
			Model.Job.JobStatus status;
			switch (jobStatus)
			{
				case FiniteJobStatus.FAILURE:
					status = Model.Job.JobStatus.FAILURE;
					break;
				case FiniteJobStatus.CANCELLED:
					status = Model.Job.JobStatus.CANCELLED;
					break;
				case FiniteJobStatus.DELETED:
					status = Model.Job.JobStatus.DELETED;
					break;
				case FiniteJobStatus.SUCCESS:
					status = Model.Job.JobStatus.SUCCESS;
					break;
				default:
					throw new ArgumentException("Unsupported job status: " + Enum.GetName(typeof(FiniteJobStatus), jobStatus));
			}
			_serviceCaller.Execute(new UpdateStatus(JobId, status, JobStatusDetails));
		}

		Task<R> IServiceCaller.Execute<R>(IRequest<R> request)
		{
			return _serviceCaller.Execute(request);
		}

		Task<R> IServiceCaller.Execute<R>(IRequest<R> request, CancellationToken cancellationToken)
		{
			return _serviceCaller.Execute(request, cancellationToken);
		}
	}
}
