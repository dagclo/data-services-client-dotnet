using System.Net.Http;
using System.Threading;
using Quadient.DataServices.Model;
using Quadient.DataServices.Utility;
using System.Threading.Tasks;

namespace Quadient.DataServices.Api
{
    public class Client : IClient
    {
        private readonly Service _service;

        public Client(ICredentials credentials, IConfiguration configuration = null)
        {
            _service = new Service(credentials, configuration);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="token">A unique token, a JSON Web Token (JWT), valid for a limited period of time, typically an hour. Used to provide in the 'Authorization' header of forthcoming requests.</param>
        /// <param name="configuration"></param>
        public Client(ISessionToken token, IConfiguration configuration = null)
        {
            _service = new Service(token, configuration);
        }

        /// <summary>
        /// Creates a new job. By default the `owner` will be the currently authenticated user, and the `job_status` will be `CREATED`.
        /// </summary>
        /// <param name="origin">The originating product/application/service for which this job is being created.</param>
        /// <returns></returns>
        public async Task<JobSession> CreateJob(string origin = Constants.Origin)
        {
            var session = CreateJobSession(origin);
            await session.Initialize();
            return session;
        }

        public JobSession ResumeJob(string jobId, string origin = Constants.Origin)
        {
            var jobSession = CreateJobSession(origin);
            jobSession.JobId = jobId;
            return jobSession;
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
            return await _service.Execute(request);
        }

        /// <summary>
        /// Execute the service call.
        /// </summary>
        /// <typeparam name="T">The input type for the service request.</typeparam>
        /// <typeparam name="R">The return type from the service request.</typeparam>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        /// <exception cref="BadRequestRestException"></exception>
        /// <exception cref="InsufficientCreditsRestException"></exception>
        /// <exception cref="HttpRequestException">The request failed due to an underlying issue such as network connectivity, DNS failure, server certificate validation or timeout.</exception>
        public async Task<R> Execute<T, R>(IRequest<T, R> request, CancellationToken cancellationToken)
        {
            return await _service.Execute(request, cancellationToken);
        }

        private JobSession CreateJobSession(string origin)
        {
            return new JobSession(_service, origin);
        }
    }
}
