using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using Quadient.DataServices.Model.UsBatch;

namespace Quadient.DataServices.Api.WalkSequence
{
	public class AddWalkSequenceRecords : IRequest<object>
	{
		public AddWalkSequenceRecords(string jobId, IEnumerable<IList<string>> records) : this(jobId, CreateRequest(records)) {}
		public AddWalkSequenceRecords(string jobId, List<List<string>> records) : this(jobId, new Records(records)) {}
		public AddWalkSequenceRecords(string jobId, Records records)
		{
			ServicePath = $"{WalkSequenceClient.BASE_PATH}/jobs/{jobId}/records";
			Content = records;
		}

		public string ServicePath { get; }
		public HttpMethod Method { get; } = HttpMethod.Post;
		public Records Content { get; set; }
		public IDictionary<string, string> QueryStringParams { get; }
		public object Body => Content;
		public IDictionary<string, string> Headers { get; }
		private static Records CreateRequest(IEnumerable<IList<string>> records)
		{
			var list = new List<List<string>>(); // the request class requires a List
			foreach (IList<string> record in records)
			{
				list.Add(record.ToList());
			}
			return new Records(list);
		}
	}
}
