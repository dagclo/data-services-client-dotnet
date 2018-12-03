using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using Quadient.DataServices.Model.Job;
using Quadient.DataServices.Utility;

namespace Quadient.DataServices.Api.Job
{
	/// <summary>
	/// Creates a new job. By default the `owner` will be the currently authenticated user, and the `job_status` will be `CREATED`.
	/// </summary>
	public class CreateJob : IRequest<JobInformationResponse>
	{
		public string ServicePath { get; } = "jobs/v1";
		public HttpMethod Method { get; } = HttpMethod.Post;
		public IDictionary<string, string> QueryStringParams { get; }
		public object Body { get; }
		public IDictionary<string, string> Headers { get; }

		/// <summary>
		/// Creates a new job. By default the `owner` will be the currently authenticated user, and the `job_status` will be `CREATED`.
		/// </summary>
		public CreateJob()
		{
			Body = new JobCreationRequest(Constants.Origin);
		}

		/// <summary>
		/// Creates a new job. By default the `owner` will be the currently authenticated user, and the `job_status` will be `CREATED`.
		/// </summary>
		/// <param name="origin">The originating product/application/service for which this job is being created.</param>
		public CreateJob(string origin)
		{
			Body = new JobCreationRequest(origin);
		}

		public CreateJob(JobCreationDetails details)
		{
			Body = new JobCreationRequest()
			{
				Origin = details.Origin ?? Constants.Origin,
				ParentJob = details.ParentJob,
				AdditionalDetails = details.AdditionalDetails,
				ExpectedServices = details.ExpectedServices?.ToList(),
				ExpectedRecordCount = details.ExpectedRecordCount
			};
		}
	}
}
