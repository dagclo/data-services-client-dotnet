using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using Quadient.DataServices.Model.Phone;

namespace Quadient.DataServices.Api.Phone
{
    public class PhoneValidation: IRequest<PhoneValidationRequest, PhoneValidationResponse>
    {
        public string ServicePath {get;} = "/services/phone-validation/v1/validate";
        public HttpMethod Method {get;} = HttpMethod.Post;
        public PhoneValidationRequest Content { get; set; }

        public PhoneValidation() {}

        public PhoneValidation(PhoneValidationRequest content)
        {
            Content = content;
        }

        public PhoneValidation(PhoneValidationRequestConfiguration configuration, List<PhoneValidationRequestRecord> records)
        {
            Content = new PhoneValidationRequest
            {
                Configuration = configuration,
                PhoneNumbers = records
            };
        }

        public PhoneValidation(PhoneValidationRequestConfiguration configuration, IEnumerable<string> numbers)
        {
            var records = numbers.Select(number => new PhoneValidationRequestRecord
                {
                    PhoneNumber = number
                })
                .ToList();
            Content = new PhoneValidationRequest
            {
                Configuration = configuration,
                PhoneNumbers = records
            };
        }
    }
}
