using System.Collections.Generic;
using System.Net.Http;
using Quadient.DataServices.Model.UsBatch;

namespace Quadient.DataServices.Api.UsBatch
{
	public class GetUsMoveUpdateRecordPages : IRequest<RecordPages>
	{
		public enum RecordKind
		{
			input,
			output
		}

		public GetUsMoveUpdateRecordPages(string jobId, RecordKind kind)
		{
			ServicePath = $"services/us-move-update/v1/jobs/{jobId}/records/pages";
			QueryStringParams = new Dictionary<string, string>
			{
				{"kind", kind.ToString()}
			};
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
