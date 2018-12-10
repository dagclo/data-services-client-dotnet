using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using Quadient.DataServices.Model.Url;
namespace Quadient.DataServices.Api.Url
{
	public class UrlValidation : IRequest<UrlValidationResponse>
	{
		public string ServicePath => "services/url-validation/v1/validate";
		public HttpMethod Method => HttpMethod.Post;
		public UrlValidationRequest Content { get; set; }
		public IDictionary<string, string> QueryStringParams { get; }
		public object Body => Content;
		public IDictionary<string, string> Headers { get; }

		/// <summary>
		/// Validates a set of urls
		/// </summary>
		public UrlValidation()
		{
		}

		/// <summary>
		/// Validates a set of urls
		/// </summary>
		/// <param name="content"></param>
		public UrlValidation(UrlValidationRequest content)
		{
			Content = content;
		}

		/// <summary>
		/// Validates a set of urls
		/// </summary>
		/// <param name="configuration">Configuration options to set for the data quality engine. Omit if you want to use the default behavior. The default behavior assumes that the protocol is http</param>
		/// <param name="urls"></param>
		public UrlValidation(UrlValidationRequestConfiguration configuration,
			List<UrlValidationRequestRecord> records)
		{
			Content = new UrlValidationRequest(configuration, records);
		}

		/// <summary>
		/// Validates a set of urls
		/// </summary>
		/// <param name="configuration">Configuration options to set for the data quality engine. Omit if you want to use the default behavior. The default behavior assumes that the protocol is http</param>
		/// <param name="urls"></param>
		public UrlValidation(UrlValidationRequestConfiguration configuration, IEnumerable<string> urls)
		{
			var records = urls.Select(url => new UrlValidationRequestRecord
			{
				Url = url
			})
				.ToList();
			Content = new UrlValidationRequest(configuration, records);
		}

	}
}
