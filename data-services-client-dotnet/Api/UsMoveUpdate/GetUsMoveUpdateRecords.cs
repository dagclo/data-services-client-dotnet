using System.Collections.Generic;
using System.Net.Http;
using Quadient.DataServices.Model.UsBatch;

namespace Quadient.DataServices.Api.UsBatch
{
	public class GetUsMoveUpdateRecords : IRequest<Records>
	{
		public GetUsMoveUpdateRecords(string jobId, string pageId)
		{
			ServicePath = $"services/us-move-update/v1/jobs/{jobId}/records/{pageId}";
		}

<<<<<<< HEAD
		public string ServicePath { get; }
		public HttpMethod Method => HttpMethod.Get;
		public object Content { get; set; }
		public IDictionary<string, string> QueryStringParams { get; }
		public object Body => Content;
		public IDictionary<string, string> Headers { get; }
	}
}
=======
        public string ServicePath { get; }
        public HttpMethod Method => HttpMethod.Get;
        public object Content { get; set; }
        public IDictionary<string, string> QueryStringParams { get; }
        public object Body => Content;
        public IDictionary<string, string> Headers { get; }
    }
}
>>>>>>> EtlClient
