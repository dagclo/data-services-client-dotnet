using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using Quadient.DataServices.Model.Phone;

namespace Quadient.DataServices.Api.Phone
{
<<<<<<< HEAD
	/// <summary>
	/// Validates a set of phone numbers
	/// </summary>
	public class PhoneValidation : IRequest<PhoneValidationResponse>
	{
		public string ServicePath { get; } = "services/phone-validation/v1/validate";
		public HttpMethod Method => HttpMethod.Post;
		public PhoneValidationRequest Content { get; set; }
		public IDictionary<string, string> QueryStringParams { get; }
		public object Body => Content;
		public IDictionary<string, string> Headers { get; }
=======
    /// <summary>
    /// Validates a set of phone numbers
    /// </summary>
    public class PhoneValidation : IRequest<PhoneValidationResponse>
    {
        public string ServicePath { get; } = "services/phone-validation/v1/validate";
        public HttpMethod Method => HttpMethod.Post;
        public PhoneValidationRequest Content { get; set; }
        public IDictionary<string, string> QueryStringParams { get; }
        public object Body => Content;
        public IDictionary<string, string> Headers { get; }
>>>>>>> EtlClient

		/// <summary>
		/// Validates a set of phone numbers
		/// </summary>
		public PhoneValidation()
		{
		}

		/// <summary>
		/// Validates a set of phone numbers
		/// </summary>
		/// <param name="content"></param>
		public PhoneValidation(PhoneValidationRequest content)
		{
			Content = content;
		}

		/// <summary>
		/// Validates a set of phone numbers
		/// </summary>
		/// <param name="configuration">Configuration options to set for the data quality engine. Omit if you want to use the default behavior. The default behavior assumes that the phone number includes a country code.</param>
		/// <param name="phoneNumbers"></param>
		public PhoneValidation(PhoneValidationRequestConfiguration configuration,
			List<PhoneValidationRequestRecord> phoneNumbers)
		{
			Content = new PhoneValidationRequest(configuration, phoneNumbers);
		}

		/// <summary>
		/// Validates a set of phone numbers
		/// </summary>
		/// <param name="configuration">Configuration options to set for the data quality engine. Omit if you want to use the default behavior. The default behavior assumes that the phone number includes a country code.</param>
		/// <param name="numbers"></param>
		public PhoneValidation(PhoneValidationRequestConfiguration configuration, IEnumerable<string> numbers)
		{
			var phoneNumbers = numbers.Select(number => new PhoneValidationRequestRecord
			{
				PhoneNumber = number
			})
				.ToList();
			Content = new PhoneValidationRequest(configuration, phoneNumbers);
		}
	}
}
