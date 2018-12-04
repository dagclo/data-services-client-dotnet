using System.Collections.Generic;
using System.Net.Http;

namespace Quadient.DataServices.Api
{
	public class SimpleRequest<T> : IRequest<T>
	{
		public static SimpleRequest<T> Get(string servicePath)
		{
			return new SimpleRequest<T>(HttpMethod.Get, servicePath);
		}
		public static SimpleRequest<T> Post(string servicePath, object body)
		{
			return new SimpleRequest<T>(HttpMethod.Post, servicePath)
			{
				Body = body
			};
		}
		public static SimpleRequest<T> Put(string servicePath, object body)
		{
			return new SimpleRequest<T>(HttpMethod.Put, servicePath)
			{
				Body = body
			};
		}
		public static SimpleRequest<T> Delete(string servicePath)
		{
			return new SimpleRequest<T>(HttpMethod.Delete, servicePath);
		}
		public string ServicePath { get; }
		public HttpMethod Method { get; }
		public object Body { get; set; }
		public IDictionary<string, string> Headers { get; set; }
		public IDictionary<string, string> QueryStringParams { get; set; }
		public SimpleRequest(HttpMethod method, string servicePath)
		{
			Method = method;
			ServicePath = servicePath;
		}
	}
}