/* 
 * Email Validation
 *
 * The Email Validation data service tests whether the data in a record's email address field is a valid email address.  The service determines whether the provided email address is correctly formatted and conforms to email syntax standards, has a domain that is real and accepts email,  and is linked to a proper mail box or addressee.   Key functionality:  * Provides two methods for validation, Fast or Full, to match the processing needs for your business. * Validates that an email address is valid and correctly formatted. * Has built-in white and black lists of addresses and domains to identify addresses that take advantage of typosquatting or disposable email accounts. * Provides flags to indicate whether it is likely that mail to an email address is deliverable. 
 *
 * OpenAPI spec version: v1
 * 
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */

using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.ComponentModel.DataAnnotations;
using SwaggerDateConverter = Quadient.DataServices.Model.Client.SwaggerDateConverter;

namespace Quadient.DataServices.Model.Email
{
    /// <summary>
    /// EmailValidationResponse
    /// </summary>
    [DataContract]
    public partial class EmailValidationResponse : IEquatable<EmailValidationResponse>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EmailValidationResponse" /> class.
        /// </summary>
        /// <param name="Email">Email.</param>
        /// <param name="Suggestions">Suggestions.</param>
        /// <param name="Outcome">Outcome.</param>
        public EmailValidationResponse(EmailValidationResponseEmail Email = default(EmailValidationResponseEmail), List<EmailValidationResponseSuggestions> Suggestions = default(List<EmailValidationResponseSuggestions>), EmailValidationOutcome Outcome = default(EmailValidationOutcome))
        {
            this.Email = Email;
            this.Suggestions = Suggestions;
            this.Outcome = Outcome;
        }
        
        /// <summary>
        /// Gets or Sets Email
        /// </summary>
        [DataMember(Name="email", EmitDefaultValue=false)]
        public EmailValidationResponseEmail Email { get; set; }

        /// <summary>
        /// Gets or Sets Suggestions
        /// </summary>
        [DataMember(Name="suggestions", EmitDefaultValue=false)]
        public List<EmailValidationResponseSuggestions> Suggestions { get; set; }

        /// <summary>
        /// Gets or Sets Outcome
        /// </summary>
        [DataMember(Name="outcome", EmitDefaultValue=false)]
        public EmailValidationOutcome Outcome { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class EmailValidationResponse {\n");
            sb.Append("  Email: ").Append(Email).Append("\n");
            sb.Append("  Suggestions: ").Append(Suggestions).Append("\n");
            sb.Append("  Outcome: ").Append(Outcome).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as EmailValidationResponse);
        }

        /// <summary>
        /// Returns true if EmailValidationResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of EmailValidationResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(EmailValidationResponse input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Email == input.Email ||
                    (this.Email != null &&
                    this.Email.Equals(input.Email))
                ) && 
                (
                    this.Suggestions == input.Suggestions ||
                    this.Suggestions != null &&
                    this.Suggestions.SequenceEqual(input.Suggestions)
                ) && 
                (
                    this.Outcome == input.Outcome ||
                    (this.Outcome != null &&
                    this.Outcome.Equals(input.Outcome))
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = 41;
                if (this.Email != null)
                    hashCode = hashCode * 59 + this.Email.GetHashCode();
                if (this.Suggestions != null)
                    hashCode = hashCode * 59 + this.Suggestions.GetHashCode();
                if (this.Outcome != null)
                    hashCode = hashCode * 59 + this.Outcome.GetHashCode();
                return hashCode;
            }
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }

}
