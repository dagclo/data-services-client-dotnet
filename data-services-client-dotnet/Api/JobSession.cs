using Quadient.DataServices.Api.Job;
using Quadient.DataServices.Model;
using Quadient.DataServices.Model.Job;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using Quadient.DataServices.Utility;

namespace Quadient.DataServices.Api
{
    public class JobSession : IDisposable
    {
        private IDictionary<string, string> Headers { get; set; }
        public string JobId { get; set; }
        private string Origin { get; set; }
        private readonly Service _service;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="credentials"></param>
        /// <param name="configuration"></param>
        /// <param name="origin">The originating product/application/service for which this job is being created.</param>
        public JobSession(ICredentials credentials, IConfiguration configuration, string origin)
        {
            Origin = origin;
            _service = new Service(credentials, configuration);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="token">A unique token, a JSON Web Token (JWT), valid for a limited period of time, typically an hour. Used to provide in the 'Authorization' header of forthcoming requests.</param>
        /// <param name="configuration"></param>
        /// <param name="origin">The originating product/application/service for which this job is being created.</param>
        public JobSession(ISessionToken token, IConfiguration configuration, string origin)
        {
            Origin = origin;
            _service = new Service(token, configuration);
        }

        internal JobSession(Service service, string origin)
        {
            Origin = origin;
            _service = service;
        }

        /// <summary>
        /// Creates a new job. By default the `owner` will be the currently authenticated user, and the `job_status` will be `CREATED`.
        /// </summary>
        /// <returns></returns>
        public async Task<JobInformationResponse> Initialize()
        {
            var request = new CreateJob(Origin);
            var job = await Execute(request);
            JobId = job.JobId;
            Origin = job.Origin;
            Headers = new Dictionary<string, string>
            {
                {"Job-ID", JobId},
                {"Origin", Origin}
            };
            return job;
        }

        /// <summary>
        /// Execute the service call.
        /// </summary>
        /// <typeparam name="T">The input type for the service request.</typeparam>
        /// <typeparam name="R">The return type from the service request.</typeparam>
        /// <param name="request"></param>
        /// <returns></returns>
        /// <exception cref="BadRequestRestException"></exception>
        /// <exception cref="InsufficientCreditsRestException"></exception>
        /// <exception cref="HttpRequestException">The request failed due to an underlying issue such as network connectivity, DNS failure, server certificate validation or timeout.</exception>
        public async Task<R> Execute<T, R>(IRequest<T, R> request)
        {
            return await _service.Execute(request, Headers);
        }

        public async void Dispose()
        {
            await _service.Execute(new UpdateStatus(JobId, JobStatus.SUCCESS));
        }
    }
}
