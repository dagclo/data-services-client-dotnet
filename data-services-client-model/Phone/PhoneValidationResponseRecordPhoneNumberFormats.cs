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
	/// PhoneValidationResponseRecordPhoneNumberFormats
	/// </summary>
	[DataContract]
	public partial class PhoneValidationResponseRecordPhoneNumberFormats : IEquatable<PhoneValidationResponseRecordPhoneNumberFormats>, IValidatableObject
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="PhoneValidationResponseRecordPhoneNumberFormats" /> class.
		/// </summary>
		/// <param name="International">The &#x60;International&#x60; formatted phone number, which is consistent with the definition in ITU-T Recommendation E123..</param>
		/// <param name="National">The &#x60;National&#x60; formatted phone number, which is consistent with the definition in ITU-T Recommendation E123..</param>
		/// <param name="E164">The &#x60;E164&#x60; formatted phone number, which is similar to the &#x60;International&#x60;, but does not have any formatting..</param>
		/// <param name="RFC3966">The &#x60;RFC3966&#x60; formatted phone number, which is similar to the &#x60;International&#x60; format, but has all spaces and other separating symbols replaced with hyphens and has any phone number extension appended with \&quot;;ext&#x3D;\&quot;. It also has a prefix of &#x60;tel:&#x60; added..</param>
		public PhoneValidationResponseRecordPhoneNumberFormats(string International = default(string), string National = default(string), string E164 = default(string), string RFC3966 = default(string))
		{
			this.International = International;
			this.National = National;
			this.E164 = E164;
			this.RFC3966 = RFC3966;
		}
		
		/// <summary>
		/// The &#x60;International&#x60; formatted phone number, which is consistent with the definition in ITU-T Recommendation E123.
		/// </summary>
		/// <value>The &#x60;International&#x60; formatted phone number, which is consistent with the definition in ITU-T Recommendation E123.</value>
		[DataMember(Name="International", EmitDefaultValue=false)]
		public string International { get; set; }

		/// <summary>
		/// The &#x60;National&#x60; formatted phone number, which is consistent with the definition in ITU-T Recommendation E123.
		/// </summary>
		/// <value>The &#x60;National&#x60; formatted phone number, which is consistent with the definition in ITU-T Recommendation E123.</value>
		[DataMember(Name="National", EmitDefaultValue=false)]
		public string National { get; set; }

		/// <summary>
		/// The &#x60;E164&#x60; formatted phone number, which is similar to the &#x60;International&#x60;, but does not have any formatting.
		/// </summary>
		/// <value>The &#x60;E164&#x60; formatted phone number, which is similar to the &#x60;International&#x60;, but does not have any formatting.</value>
		[DataMember(Name="E164", EmitDefaultValue=false)]
		public string E164 { get; set; }

		/// <summary>
		/// The &#x60;RFC3966&#x60; formatted phone number, which is similar to the &#x60;International&#x60; format, but has all spaces and other separating symbols replaced with hyphens and has any phone number extension appended with \&quot;;ext&#x3D;\&quot;. It also has a prefix of &#x60;tel:&#x60; added.
		/// </summary>
		/// <value>The &#x60;RFC3966&#x60; formatted phone number, which is similar to the &#x60;International&#x60; format, but has all spaces and other separating symbols replaced with hyphens and has any phone number extension appended with \&quot;;ext&#x3D;\&quot;. It also has a prefix of &#x60;tel:&#x60; added.</value>
		[DataMember(Name="RFC3966", EmitDefaultValue=false)]
		public string RFC3966 { get; set; }

		/// <summary>
		/// Returns the string presentation of the object
		/// </summary>
		/// <returns>String presentation of the object</returns>
		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.Append("class PhoneValidationResponseRecordPhoneNumberFormats {\n");
			sb.Append("  International: ").Append(International).Append("\n");
			sb.Append("  National: ").Append(National).Append("\n");
			sb.Append("  E164: ").Append(E164).Append("\n");
			sb.Append("  RFC3966: ").Append(RFC3966).Append("\n");
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
			return this.Equals(input as PhoneValidationResponseRecordPhoneNumberFormats);
		}

		/// <summary>
		/// Returns true if PhoneValidationResponseRecordPhoneNumberFormats instances are equal
		/// </summary>
		/// <param name="input">Instance of PhoneValidationResponseRecordPhoneNumberFormats to be compared</param>
		/// <returns>Boolean</returns>
		public bool Equals(PhoneValidationResponseRecordPhoneNumberFormats input)
		{
			if (input == null)
				return false;

			return 
				(
					this.International == input.International ||
					(this.International != null &&
					this.International.Equals(input.International))
				) && 
				(
					this.National == input.National ||
					(this.National != null &&
					this.National.Equals(input.National))
				) && 
				(
					this.E164 == input.E164 ||
					(this.E164 != null &&
					this.E164.Equals(input.E164))
				) && 
				(
					this.RFC3966 == input.RFC3966 ||
					(this.RFC3966 != null &&
					this.RFC3966.Equals(input.RFC3966))
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
				if (this.International != null)
					hashCode = hashCode * 59 + this.International.GetHashCode();
				if (this.National != null)
					hashCode = hashCode * 59 + this.National.GetHashCode();
				if (this.E164 != null)
					hashCode = hashCode * 59 + this.E164.GetHashCode();
				if (this.RFC3966 != null)
					hashCode = hashCode * 59 + this.RFC3966.GetHashCode();
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
