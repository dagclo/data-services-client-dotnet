/* 
 * Email Validation
 *
 * The Email Validation data service tests whether the data in a record's email address field is a valid email address.  The service determines whether the provided email address is correctly formatted and conforms to email syntax standards, has a domain that is real and accepts email,  and is linked to a proper mail box or addressee.   Key functionality:  * Provides two methods for validation, Fast or Full, to match the processing needs for your business. * Validates that an email address is valid and correctly formatted. * Has built-in white and black lists of addresses and domains to identify addresses that take advantage of typosquatting or disposable email accounts. * Provides flags to indicate whether it is likely that mail to an email address is deliverable. 
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
    /// EmailValidationResponseEmail
    /// </summary>
    [DataContract]
    public partial class EmailValidationResponseEmail : IEquatable<EmailValidationResponseEmail>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EmailValidationResponseEmail" /> class.
        /// </summary>
        /// <param name="Id">User-specified reference string as passed in..</param>
        /// <param name="Email">The processed email address, adjusted as necessary..</param>
        /// <param name="IsEmailFlagged">The email address exists, but deliverability is unlikely..</param>
        public EmailValidationResponseEmail(string Id = default(string), string Email = default(string), bool? IsEmailFlagged = default(bool?))
        {
            this.Id = Id;
            this.Email = Email;
            this.IsEmailFlagged = IsEmailFlagged;
        }
        
        /// <summary>
        /// User-specified reference string as passed in.
        /// </summary>
        /// <value>User-specified reference string as passed in.</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; set; }

        /// <summary>
        /// The processed email address, adjusted as necessary.
        /// </summary>
        /// <value>The processed email address, adjusted as necessary.</value>
        [DataMember(Name="email", EmitDefaultValue=false)]
        public string Email { get; set; }

        /// <summary>
        /// The email address exists, but deliverability is unlikely.
        /// </summary>
        /// <value>The email address exists, but deliverability is unlikely.</value>
        [DataMember(Name="is_email_flagged", EmitDefaultValue=false)]
        public bool? IsEmailFlagged { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class EmailValidationResponseEmail {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Email: ").Append(Email).Append("\n");
            sb.Append("  IsEmailFlagged: ").Append(IsEmailFlagged).Append("\n");
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
            return this.Equals(input as EmailValidationResponseEmail);
        }

        /// <summary>
        /// Returns true if EmailValidationResponseEmail instances are equal
        /// </summary>
        /// <param name="input">Instance of EmailValidationResponseEmail to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(EmailValidationResponseEmail input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
                (
                    this.Email == input.Email ||
                    (this.Email != null &&
                    this.Email.Equals(input.Email))
                ) && 
                (
                    this.IsEmailFlagged == input.IsEmailFlagged ||
                    (this.IsEmailFlagged != null &&
                    this.IsEmailFlagged.Equals(input.IsEmailFlagged))
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
                if (this.Id != null)
                    hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.Email != null)
                    hashCode = hashCode * 59 + this.Email.GetHashCode();
                if (this.IsEmailFlagged != null)
                    hashCode = hashCode * 59 + this.IsEmailFlagged.GetHashCode();
                return hashCode;
            }
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        IEnumerable<ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }

}
