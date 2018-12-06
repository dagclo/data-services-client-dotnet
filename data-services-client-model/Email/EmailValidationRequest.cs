/* 
 * Email Validation
 *
 * The Email Validation data service tests whether the data in a record's email address field is a valid email address.  The service determines whether the provided email address is correctly formatted and conforms to email syntax standards, has a domain that is real and accepts email,	and is linked to a proper mail box or addressee.   Key functionality:  * Provides two methods for validation, Fast or Full, to match the processing needs for your business. * Validates that an email address is valid and correctly formatted. * Has built-in white and black lists of addresses and domains to identify addresses that take advantage of typosquatting or disposable email accounts. * Provides flags to indicate whether it is likely that mail to an email address is deliverable. 
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
	/// EmailValidationRequest
	/// </summary>
	[DataContract]
	public partial class EmailValidationRequest : IEquatable<EmailValidationRequest>, IValidatableObject
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="EmailValidationRequest" /> class.
		/// </summary>
		[JsonConstructorAttribute]
		protected EmailValidationRequest() { }
		/// <summary>
		/// Initializes a new instance of the <see cref="EmailValidationRequest" /> class.
		/// </summary>
		/// <param name="Configuration">Configuration.</param>
		/// <param name="EmailRecords">The set of email addresses to be processed for validity. (required).</param>
		public EmailValidationRequest(EmailValidationRequestConfiguration Configuration = default(EmailValidationRequestConfiguration), List<EmailAddress> EmailRecords = default(List<EmailAddress>))
		{
			// to ensure "EmailRecords" is required (not null)
			if (EmailRecords == null)
			{
				throw new InvalidDataException("EmailRecords is a required property for EmailValidationRequest and cannot be null");
			}
			else
			{
				this.EmailRecords = EmailRecords;
			}
			this.Configuration = Configuration;
		}
		
		/// <summary>
		/// Gets or Sets Configuration
		/// </summary>
		[DataMember(Name="configuration", EmitDefaultValue=false)]
		public EmailValidationRequestConfiguration Configuration { get; set; }

		/// <summary>
		/// The set of email addresses to be processed for validity.
		/// </summary>
		/// <value>The set of email addresses to be processed for validity.</value>
		[DataMember(Name="email_records", EmitDefaultValue=false)]
		public List<EmailAddress> EmailRecords { get; set; }

		/// <summary>
		/// Returns the string presentation of the object
		/// </summary>
		/// <returns>String presentation of the object</returns>
		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.Append("class EmailValidationRequest {\n");
			sb.Append("  Configuration: ").Append(Configuration).Append("\n");
			sb.Append("  EmailRecords: ").Append(EmailRecords).Append("\n");
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
			return this.Equals(input as EmailValidationRequest);
		}

		/// <summary>
		/// Returns true if EmailValidationRequest instances are equal
		/// </summary>
		/// <param name="input">Instance of EmailValidationRequest to be compared</param>
		/// <returns>Boolean</returns>
		public bool Equals(EmailValidationRequest input)
		{
			if (input == null)
				return false;

			return 
				(
					this.Configuration == input.Configuration ||
					(this.Configuration != null &&
					this.Configuration.Equals(input.Configuration))
				) && 
				(
					this.EmailRecords == input.EmailRecords ||
					this.EmailRecords != null &&
					this.EmailRecords.SequenceEqual(input.EmailRecords)
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
				if (this.Configuration != null)
					hashCode = hashCode * 59 + this.Configuration.GetHashCode();
				if (this.EmailRecords != null)
					hashCode = hashCode * 59 + this.EmailRecords.GetHashCode();
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
