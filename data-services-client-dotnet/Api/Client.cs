﻿using System.Net.Http;
using System.Threading;
using Quadient.DataServices.Model;
using Quadient.DataServices.Utility;
using System.Threading.Tasks;

namespace Quadient.DataServices.Api
{
	public class Client : IClient
	{
		private readonly IServiceCaller _service;

		public Client(ICredentials credentials, IConfiguration configuration = null)
		{
			_service = new BaseServiceCaller(credentials, configuration);
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="token">A unique token, a JSON Web Token (JWT), valid for a limited period of time, typically an hour. Used to provide in the 'Authorization' header of forthcoming requests.</param>
		/// <param name="configuration"></param>
		public Client(ISessionToken token, IConfiguration configuration = null)
		{
			_service = new BaseServiceCaller(token, configuration);
		}

		Task<IJobSession> IClient.CreateJob(JobCreationDetails details)
		{
			throw new System.NotImplementedException();
		}

		IJobSession IClient.ResumeJob(string jobId)
		{
			return new JobSession(_service, jobId);
		}

		Task<R> IServiceCaller.Execute<R>(IRequest<R> request)
		{
			return _service.Execute(request);
		}

		Task<R> IServiceCaller.Execute<R>(IRequest<R> request, CancellationToken cancellationToken)
		{
			return _service.Execute(request, cancellationToken);
		}
	}
}
