using System.Collections.Generic;
using System.Net.Http;

namespace Quadient.DataServices.Api
{
	public interface IRequest<R>
	{
		string ServicePath { get; }
		HttpMethod Method { get; }
		object Body { get; set; }
		IDictionary<string, string> Headers { get; }
		IDictionary<string, string> QueryStringParams { get; }
	}
}
