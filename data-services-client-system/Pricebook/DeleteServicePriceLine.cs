using System.Collections.Generic;
using System.Net.Http;
using Quadient.DataServices.Api;

namespace Quadient.DataServices.System.Pricebook
{
	/// <summary>
	/// Removes a previously entered price
	/// </summary>
	public class DeleteServicePriceLine : IRequest<object>
	{
		public string ServicePath { get; }
		public HttpMethod Method { get; } = HttpMethod.Delete;
		public object Content { get; set; }
		public IDictionary<string, string> QueryStringParams { get; }
		public object Body => Content;
		public IDictionary<string, string> Headers { get; }

		/// <summary>
		/// Removes a previously entered price
		/// </summary>
		/// <param name="id"></param>
		public DeleteServicePriceLine(string id)
		{
			ServicePath = $"pricebook/v1/prices/pricelines/{id}";
		}
	}
}
