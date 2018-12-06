using System.Collections.Generic;
using System.Net.Http;
using Quadient.DataServices.Model.UsBatch;

namespace Quadient.DataServices.Api.UsBatch
{
<<<<<<< HEAD
	public class GetUsAppendsJob : IRequest<USAppendsJob>
	{
		public GetUsAppendsJob(string jobId)
		{
			ServicePath = $"services/us-appends/v1/jobs/{jobId}";
		}
		public string ServicePath { get; }
		public HttpMethod Method => HttpMethod.Get;
		public object Body { get; }
		public IDictionary<string, string> QueryStringParams { get; }
		public IDictionary<string, string> Headers { get; }
	}
}
=======
    public class GetUsAppendsJob : IRequest<USAppendsJob>
    {
        public GetUsAppendsJob(string jobId)
        {
            ServicePath = $"services/us-appends/v1/jobs/{jobId}";
        }
        public string ServicePath { get; }
        public HttpMethod Method => HttpMethod.Get;
        public object Body { get; }
        public IDictionary<string, string> QueryStringParams { get; }
        public IDictionary<string, string> Headers { get; }
    }
}
>>>>>>> EtlClient
