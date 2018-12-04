using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using Quadient.DataServices.Model.Email;

namespace Quadient.DataServices.Api.Email
{
    /// <summary>
    /// Updates the collection of input records for email validation
    /// </summary>
    public class EmailValidation : IRequest<EmailValidationResponseBody>
    {
        public string ServicePath { get; } = "services/email-validation/v1/validate";
        public HttpMethod Method { get; } = HttpMethod.Post;
        private EmailValidationRequest Content { get; set; }
        public IDictionary<string, string> QueryStringParams { get; }
        public object Body => Content;
        public IDictionary<string, string> Headers { get; }

        public EmailValidation()
        {
        }

        /// <summary>
        /// Updates the collection of input records for email validation
        /// </summary>
        /// <param name="content"></param>
        public EmailValidation(EmailValidationRequest content)
        {
            Content = content;
        }

        /// <summary>
        /// Updates the collection of input records for email validation
        /// </summary>
        /// <param name="configuration">Configuration of the correction request.</param>
        /// <param name="emails">The set of email addresses to be processed for validity.</param>
        public EmailValidation(EmailValidationRequestConfiguration configuration, List<EmailAddress> emails)
        {
            Content = new EmailValidationRequest(configuration, emails);
        }

        /// <summary>
        /// Updates the collection of input records for email validation
        /// </summary>
        /// <param name="configuration">Configuration of the correction request.</param>
        /// <param name="emails">The set of email addresses to be processed for validity.</param>
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
