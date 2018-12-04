/* 
 * Phone Validation
 *
 * The Phone Validation data service parses, standardizes, and reformats phone numbers.  The service validates that a phone number is valid when considered against a set of  rules, including range of numbers in use, and formats. In addition, the service indicates what type of line the phone number is attached to, for example, fixed (land) line. ## Key functionality: * Parses and formats phone numbers in accordance with international and national standards. * Identifies the type of phone number, for example, Mobile, VoIP, Toll free, and so forth. * Provides easy-to-understand correction status, codes, and messages.
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

namespace Quadient.DataServices.Model.Phone
{
	/// <summary>
	/// PhoneValidationRequest
	/// </summary>
	[DataContract]
	public partial class PhoneValidationRequest : IEquatable<PhoneValidationRequest>, IValidatableObject
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="PhoneValidationRequest" /> class.
		/// </summary>
		[JsonConstructorAttribute]
		protected PhoneValidationRequest() { }
		/// <summary>
		/// Initializes a new instance of the <see cref="PhoneValidationRequest" /> class.
		/// </summary>
		/// <param name="Configuration">Configuration.</param>
		/// <param name="PhoneNumbers">The set of phone numbers to be processed for validity (required).</param>
		public PhoneValidationRequest(PhoneValidationRequestConfiguration Configuration = default(PhoneValidationRequestConfiguration), List<PhoneValidationRequestRecord> PhoneNumbers = default(List<PhoneValidationRequestRecord>))
		{
			// to ensure "PhoneNumbers" is required (not null)
			if (PhoneNumbers == null)
			{
				throw new InvalidDataException("PhoneNumbers is a required property for PhoneValidationRequest and cannot be null");
			}
			else
			{
				this.PhoneNumbers = PhoneNumbers;
			}
			this.Configuration = Configuration;
		}
		
		/// <summary>
		/// Gets or Sets Configuration
		/// </summary>
		[DataMember(Name="configuration", EmitDefaultValue=false)]
		public PhoneValidationRequestConfiguration Configuration { get; set; }

		/// <summary>
		/// The set of phone numbers to be processed for validity
		/// </summary>
		/// <value>The set of phone numbers to be processed for validity</value>
		[DataMember(Name="phone_numbers", EmitDefaultValue=false)]
		public List<PhoneValidationRequestRecord> PhoneNumbers { get; set; }

		/// <summary>
		/// Returns the string presentation of the object
		/// </summary>
		/// <returns>String presentation of the object</returns>
		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.Append("class PhoneValidationRequest {\n");
			sb.Append("  Configuration: ").Append(Configuration).Append("\n");
			sb.Append("  PhoneNumbers: ").Append(PhoneNumbers).Append("\n");
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
			return this.Equals(input as PhoneValidationRequest);
		}

		/// <summary>
		/// Returns true if PhoneValidationRequest instances are equal
		/// </summary>
		/// <param name="input">Instance of PhoneValidationRequest to be compared</param>
		/// <returns>Boolean</returns>
		public bool Equals(PhoneValidationRequest input)
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
					this.PhoneNumbers == input.PhoneNumbers ||
					this.PhoneNumbers != null &&
					this.PhoneNumbers.SequenceEqual(input.PhoneNumbers)
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
				if (this.PhoneNumbers != null)
					hashCode = hashCode * 59 + this.PhoneNumbers.GetHashCode();
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
