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
	/// Configuration options to set for the data quality engine. Omit if you want to use the default behavior. The default behavior assumes that the phone number includes a country code.
	/// </summary>
	[DataContract]
	public partial class PhoneValidationRequestConfiguration : IEquatable<PhoneValidationRequestConfiguration>, IValidatableObject
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="PhoneValidationRequestConfiguration" /> class.
		/// </summary>
		/// <param name="DefaultCountry">The default &#x60;country&#x60; value to apply to phone numbers where no country is supplied.	The ISO 3166-2 two-letter country code is preferred..</param>
		public PhoneValidationRequestConfiguration(string DefaultCountry = default(string))
		{
			this.DefaultCountry = DefaultCountry;
		}
		
		/// <summary>
		/// The default &#x60;country&#x60; value to apply to phone numbers where no country is supplied.  The ISO 3166-2 two-letter country code is preferred.
		/// </summary>
		/// <value>The default &#x60;country&#x60; value to apply to phone numbers where no country is supplied.  The ISO 3166-2 two-letter country code is preferred.</value>
		[DataMember(Name="default_country", EmitDefaultValue=false)]
		public string DefaultCountry { get; set; }

		/// <summary>
		/// Returns the string presentation of the object
		/// </summary>
		/// <returns>String presentation of the object</returns>
		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.Append("class PhoneValidationRequestConfiguration {\n");
			sb.Append("  DefaultCountry: ").Append(DefaultCountry).Append("\n");
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
			return this.Equals(input as PhoneValidationRequestConfiguration);
		}

		/// <summary>
		/// Returns true if PhoneValidationRequestConfiguration instances are equal
		/// </summary>
		/// <param name="input">Instance of PhoneValidationRequestConfiguration to be compared</param>
		/// <returns>Boolean</returns>
		public bool Equals(PhoneValidationRequestConfiguration input)
		{
			if (input == null)
				return false;

			return 
				(
					this.DefaultCountry == input.DefaultCountry ||
					(this.DefaultCountry != null &&
					this.DefaultCountry.Equals(input.DefaultCountry))
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
				if (this.DefaultCountry != null)
					hashCode = hashCode * 59 + this.DefaultCountry.GetHashCode();
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
