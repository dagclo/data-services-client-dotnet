using System.Collections.Generic;
using System.Net.Http;

namespace Quadient.DataServices.Api.Job
{
<<<<<<< HEAD
	/// <summary>
	/// Sets the job status to DELETED. This is essentially a convenience shortcut for calling `POST /jobs/v1/{job_id}/job_status` with a payload containing the `DELETED` job status.
	/// </summary>
	public class DeleteJob : IRequest<object>
	{
		public string ServicePath { get; }
		public HttpMethod Method => HttpMethod.Delete;
		public object Body { get; }
		public IDictionary<string, string> Headers { get; }
		public IDictionary<string, string> QueryStringParams { get; }
=======
    /// <summary>
    /// Sets the job status to DELETED. This is essentially a convenience shortcut for calling `POST /jobs/v1/{job_id}/job_status` with a payload containing the `DELETED` job status.
    /// </summary>
    public class DeleteJob : IRequest<object>
    {
        public string ServicePath { get; }
        public HttpMethod Method => HttpMethod.Delete;
        public object Body { get; }
        public IDictionary<string, string> Headers { get; }
        public IDictionary<string, string> QueryStringParams { get; }
>>>>>>> EtlClient

		/// <summary>
		/// Sets the job status to DELETED. This is essentially a convenience shortcut for calling `POST /jobs/v1/{job_id}/job_status` with a payload containing the `DELETED` job status.
		/// </summary>
		/// <param name="jobId"></param>
		public DeleteJob(string jobId)
		{
			ServicePath = $"jobs/v1/{jobId}";
		}
	}
}
