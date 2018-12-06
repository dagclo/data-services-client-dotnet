using System.Collections.Generic;
using System.Net.Http;
using Quadient.DataServices.Model.UsBatch;

namespace Quadient.DataServices.Api.UsBatch
{
<<<<<<< HEAD
	public class AddUsAppendsRecords : IRequest<object>
	{
		public AddUsAppendsRecords(string jobId, List<List<string>> records)
		{
			ServicePath = $"services/us-appends/v1/jobs/{jobId}/records";
			Body = new Records { _Records = records };
		}
		public string ServicePath { get; }
		public HttpMethod Method => HttpMethod.Post;
		public IDictionary<string, string> QueryStringParams { get; }
		public object Body { get; }
		public IDictionary<string, string> Headers { get; }
	}
}
=======
    public class AddUsAppendsRecords : IRequest<object>
    {
        public AddUsAppendsRecords(string jobId, List<List<string>> records)
        {
            ServicePath = $"services/us-appends/v1/jobs/{jobId}/records";
            Body = new Records { _Records = records };
        }
        public string ServicePath { get; }
        public HttpMethod Method => HttpMethod.Post;
        public IDictionary<string, string> QueryStringParams { get; }
        public object Body { get; }
        public IDictionary<string, string> Headers { get; }
    }
}
>>>>>>> EtlClient
