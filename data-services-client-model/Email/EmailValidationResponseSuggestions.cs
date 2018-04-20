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
    /// EmailValidationResponseSuggestions
    /// </summary>
    [DataContract]
    public partial class EmailValidationResponseSuggestions :  IEquatable<EmailValidationResponseSuggestions>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EmailValidationResponseSuggestions" /> class.
        /// </summary>
        /// <param name="Email">A suggested email address to replace the input email address..</param>
        public EmailValidationResponseSuggestions(string Email = default(string))
        {
            this.Email = Email;
        }
        
        /// <summary>
        /// A suggested email address to replace the input email address.
        /// </summary>
        /// <value>A suggested email address to replace the input email address.</value>
        [DataMember(Name="email", EmitDefaultValue=false)]
        public string Email { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class EmailValidationResponseSuggestions {\n");
            sb.Append("  Email: ").Append(Email).Append("\n");
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
            return this.Equals(input as EmailValidationResponseSuggestions);
        }

        /// <summary>
        /// Returns true if EmailValidationResponseSuggestions instances are equal
        /// </summary>
        /// <param name="input">Instance of EmailValidationResponseSuggestions to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(EmailValidationResponseSuggestions input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Email == input.Email ||
                    (this.Email != null &&
                    this.Email.Equals(input.Email))
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
