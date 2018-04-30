using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using Quadient.DataServices.Model.Email;

namespace Quadient.DataServices.Api.Email
{
    public class EmailValidation: IRequest<EmailValidationRequest, EmailValidationResponse>
    {
        public string ServicePath {get;} = "services/email-validation/v1/validate";
        public HttpMethod Method {get;} = HttpMethod.Post;
        public EmailValidationRequest Content { get; set; }

        public EmailValidation() {}

        public EmailValidation(EmailValidationRequest content)
        {
            Content = content;
        }

        public EmailValidation(EmailValidationRequestConfiguration configuration, List<EmailAddress> emails)
        {
            Content = new EmailValidationRequest(configuration, emails);
        }

        public EmailValidation(EmailValidationRequestConfiguration configuration, IEnumerable<string> emails)
        {
            var emailAddresses = emails.Select(email => new EmailAddress
                {
                    Email = email
                })
                .ToList();
            Content = new EmailValidationRequest(configuration, emailAddresses);
        }
    }
}
