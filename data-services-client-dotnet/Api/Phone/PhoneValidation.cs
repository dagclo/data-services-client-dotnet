using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using Quadient.DataServices.Model.Phone;

namespace Quadient.DataServices.Api.Phone
{
    public class PhoneValidation: IRequest<PhoneValidationRequest, PhoneValidationResponse>
    {
        public string ServicePath {get;} = "services/phone-validation/v1/validate";
        public HttpMethod Method {get;} = HttpMethod.Post;
        public PhoneValidationRequest Content { get; set; }
        public IDictionary<string, string> QueryStringParams { get; }

        public PhoneValidation() {}

        public PhoneValidation(PhoneValidationRequest content)
        {
            Content = content;
        }

        public PhoneValidation(PhoneValidationRequestConfiguration configuration, List<PhoneValidationRequestRecord> phoneNumbers)
        {
            Content = new PhoneValidationRequest(configuration, phoneNumbers);
        }

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
