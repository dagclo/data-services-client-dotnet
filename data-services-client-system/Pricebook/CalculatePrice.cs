using System.Collections.Generic;
using System.Net.Http;
using Quadient.DataServices.Api;
using Quadient.DataServices.System.Model.Pricebook;

namespace Quadient.DataServices.System.Pricebook
{
	/// <summary>
	/// Returns a pricing estimate for a job, session or other activity that involves Data Services.
	/// </summary>
	public class CalculatePrice : IRequest<CalculateResponse>
	{
		public string ServicePath { get; } = "pricebook/v1/calculate";
		public HttpMethod Method => HttpMethod.Post;
		public MeteringDetails Content { get; set; }
		public IDictionary<string, string> QueryStringParams { get; }
		public object Body => Content;
		public IDictionary<string, string> Headers { get; }

		/// <summary>
		/// Returns a pricing estimate for a job, session or other activity that involves Data Services.
		/// </summary>
		public CalculatePrice()
		{

		}

		/// <summary>
		/// Returns a pricing estimate for a job, session or other activity that involves Data Services.
		/// </summary>
		/// <param name="meteringDetails">The details of the job, session or other activity for which the calculation is requested.</param>
		public CalculatePrice(MeteringDetails meteringDetails)
		{
			Content = meteringDetails;
		}
	}
}
