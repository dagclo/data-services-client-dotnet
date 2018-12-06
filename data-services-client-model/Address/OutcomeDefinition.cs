/* 
 * Address Correction
 *
 * The Address Correction data service validates and corrects postal addresses from around the world.  The service is currently available for the following countries: United States, United Kingdom, and Canada. Address correction standardizes address spellings, abbreviations, and formats, adds additional delivery information, such as geocodes, and verifies the deliverability of each address.  It improves your delivery success odds by correcting incorrect information, such as postal codes and typos in street names, and verifying delivery target names.  Key functionality: * Corrects the spelling of street names and cities. * Standardizes address formats and abbreviations, based on country ID. * Enriches output with deliverability information for an address, such as USPS DPV® confirmation and geocoding coordinates. * Provides easy-to-understand correction status, codes, and messages.
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

namespace Quadient.DataServices.Model.Address
{
	/// <summary>
	/// OutcomeDefinition
	/// </summary>
	[DataContract]
	public partial class OutcomeDefinition : IEquatable<OutcomeDefinition>, IValidatableObject
	{
		/// <summary>
		/// The final status of the object.
		/// </summary>
		/// <value>The final status of the object.</value>
		[JsonConverter(typeof(StringEnumConverter))]
		public enum CategoryEnum
		{
			
			/// <summary>
			/// Enum Valid for value: Valid
			/// </summary>
			[EnumMember(Value = "Valid")]
			Valid = 1,
			
			/// <summary>
			/// Enum Corrected for value: Corrected
			/// </summary>
			[EnumMember(Value = "Corrected")]
			Corrected = 2,
			
			/// <summary>
			/// Enum Invalid for value: Invalid
			/// </summary>
			[EnumMember(Value = "Invalid")]
			Invalid = 3,
			
			/// <summary>
			/// Enum Skipped for value: Skipped
			/// </summary>
			[EnumMember(Value = "Skipped")]
			Skipped = 4,
			
			/// <summary>
			/// Enum Doubtful for value: Doubtful
			/// </summary>
			[EnumMember(Value = "Doubtful")]
			Doubtful = 5
		}

		/// <summary>
		/// The final status of the object.
		/// </summary>
		/// <value>The final status of the object.</value>
		[DataMember(Name="category", EmitDefaultValue=false)]
		public CategoryEnum Category { get; set; }
		/// <summary>
		/// Initializes a new instance of the <see cref="OutcomeDefinition" /> class.
		/// </summary>
		[JsonConstructorAttribute]
		protected OutcomeDefinition() { }
		/// <summary>
		/// Initializes a new instance of the <see cref="OutcomeDefinition" /> class.
		/// </summary>
		/// <param name="Codes">An object that contains correction codes as keys. Codes prefixed with C describe a correction. Codes prefixed with E describe an error with input. These records are skipped or are invalid. The values may be either a string message or another object that contains additional information. More than one code may be returned. * &#x60;C10&#x60; - Street corrected. * &#x60;C11&#x60; - House number appended or corrected. * &#x60;C12&#x60; - Postal code appended or corrected. * &#x60;C13&#x60; - City appended or corrected. * &#x60;C14&#x60; - Province or state appended or corrected. * &#x60;C15&#x60; - County appended or corrected. * &#x60;C16&#x60; - Country standardized. * &#x60;C17&#x60; - Building corrected. * &#x60;C18&#x60; - Organization corrected. * &#x60;C19&#x60; - Converted to new address. * &#x60;C20&#x60; - Geocode appended. * &#x60;C21&#x60; - Post Office Box updated or appended. * &#x60;E10&#x60; - Country unsupported; record is skipped. * &#x60;E11&#x60; - No address lines. * &#x60;E12&#x60; - Too many address lines. * &#x60;E13&#x60; - No country specified. * &#x60;E14&#x60; - Could not identify country. * &#x60;E15&#x60; - Street invalid or missing. * &#x60;E16&#x60; - House number invalid or missing. * &#x60;E17&#x60; - Postal code invalid. * &#x60;E18&#x60; - City invalid. * &#x60;E19&#x60; - Province or state invalid. * &#x60;E20&#x60; - Unit number invalid. * &#x60;E21&#x60; - Unit number missing. * &#x60;E22&#x60; - Input value(s) too long. * &#x60;E23&#x60; - Address is not applicable for mail delivery. * &#x60;E24&#x60; - Urbanization invalid or missing. * &#x60;E25&#x60; - No geocode available. * &#x60;E26&#x60; - Locality invalid or missing. * &#x60;E27&#x60; - Building invalid or missing. * &#x60;E28&#x60; - Post Office Box invalid or missing. * &#x60;E29&#x60; - Skipped due to unexpected error. * &#x60;E30&#x60; - Country access restricted.  (required).</param>
		/// <param name="Category">The final status of the object. (required).</param>
		public OutcomeDefinition(Dictionary<string, string> Codes = default(Dictionary<string, string>), CategoryEnum Category = default(CategoryEnum))
		{
			// to ensure "Codes" is required (not null)
			if (Codes == null)
			{
				throw new InvalidDataException("Codes is a required property for OutcomeDefinition and cannot be null");
			}
			else
			{
				this.Codes = Codes;
			}
			// to ensure "Category" is required (not null)
			if (Category == null)
			{
				throw new InvalidDataException("Category is a required property for OutcomeDefinition and cannot be null");
			}
			else
			{
				this.Category = Category;
			}
		}
		
		/// <summary>
		/// An object that contains correction codes as keys. Codes prefixed with C describe a correction. Codes prefixed with E describe an error with input. These records are skipped or are invalid. The values may be either a string message or another object that contains additional information. More than one code may be returned. * &#x60;C10&#x60; - Street corrected. * &#x60;C11&#x60; - House number appended or corrected. * &#x60;C12&#x60; - Postal code appended or corrected. * &#x60;C13&#x60; - City appended or corrected. * &#x60;C14&#x60; - Province or state appended or corrected. * &#x60;C15&#x60; - County appended or corrected. * &#x60;C16&#x60; - Country standardized. * &#x60;C17&#x60; - Building corrected. * &#x60;C18&#x60; - Organization corrected. * &#x60;C19&#x60; - Converted to new address. * &#x60;C20&#x60; - Geocode appended. * &#x60;C21&#x60; - Post Office Box updated or appended. * &#x60;E10&#x60; - Country unsupported; record is skipped. * &#x60;E11&#x60; - No address lines. * &#x60;E12&#x60; - Too many address lines. * &#x60;E13&#x60; - No country specified. * &#x60;E14&#x60; - Could not identify country. * &#x60;E15&#x60; - Street invalid or missing. * &#x60;E16&#x60; - House number invalid or missing. * &#x60;E17&#x60; - Postal code invalid. * &#x60;E18&#x60; - City invalid. * &#x60;E19&#x60; - Province or state invalid. * &#x60;E20&#x60; - Unit number invalid. * &#x60;E21&#x60; - Unit number missing. * &#x60;E22&#x60; - Input value(s) too long. * &#x60;E23&#x60; - Address is not applicable for mail delivery. * &#x60;E24&#x60; - Urbanization invalid or missing. * &#x60;E25&#x60; - No geocode available. * &#x60;E26&#x60; - Locality invalid or missing. * &#x60;E27&#x60; - Building invalid or missing. * &#x60;E28&#x60; - Post Office Box invalid or missing. * &#x60;E29&#x60; - Skipped due to unexpected error. * &#x60;E30&#x60; - Country access restricted. 
		/// </summary>
		/// <value>An object that contains correction codes as keys. Codes prefixed with C describe a correction. Codes prefixed with E describe an error with input. These records are skipped or are invalid. The values may be either a string message or another object that contains additional information. More than one code may be returned. * &#x60;C10&#x60; - Street corrected. * &#x60;C11&#x60; - House number appended or corrected. * &#x60;C12&#x60; - Postal code appended or corrected. * &#x60;C13&#x60; - City appended or corrected. * &#x60;C14&#x60; - Province or state appended or corrected. * &#x60;C15&#x60; - County appended or corrected. * &#x60;C16&#x60; - Country standardized. * &#x60;C17&#x60; - Building corrected. * &#x60;C18&#x60; - Organization corrected. * &#x60;C19&#x60; - Converted to new address. * &#x60;C20&#x60; - Geocode appended. * &#x60;C21&#x60; - Post Office Box updated or appended. * &#x60;E10&#x60; - Country unsupported; record is skipped. * &#x60;E11&#x60; - No address lines. * &#x60;E12&#x60; - Too many address lines. * &#x60;E13&#x60; - No country specified. * &#x60;E14&#x60; - Could not identify country. * &#x60;E15&#x60; - Street invalid or missing. * &#x60;E16&#x60; - House number invalid or missing. * &#x60;E17&#x60; - Postal code invalid. * &#x60;E18&#x60; - City invalid. * &#x60;E19&#x60; - Province or state invalid. * &#x60;E20&#x60; - Unit number invalid. * &#x60;E21&#x60; - Unit number missing. * &#x60;E22&#x60; - Input value(s) too long. * &#x60;E23&#x60; - Address is not applicable for mail delivery. * &#x60;E24&#x60; - Urbanization invalid or missing. * &#x60;E25&#x60; - No geocode available. * &#x60;E26&#x60; - Locality invalid or missing. * &#x60;E27&#x60; - Building invalid or missing. * &#x60;E28&#x60; - Post Office Box invalid or missing. * &#x60;E29&#x60; - Skipped due to unexpected error. * &#x60;E30&#x60; - Country access restricted. </value>
		[DataMember(Name="codes", EmitDefaultValue=false)]
		public Dictionary<string, string> Codes { get; set; }


		/// <summary>
		/// Returns the string presentation of the object
		/// </summary>
		/// <returns>String presentation of the object</returns>
		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.Append("class OutcomeDefinition {\n");
			sb.Append("  Codes: ").Append(Codes).Append("\n");
			sb.Append("  Category: ").Append(Category).Append("\n");
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
			return this.Equals(input as OutcomeDefinition);
		}

		/// <summary>
		/// Returns true if OutcomeDefinition instances are equal
		/// </summary>
		/// <param name="input">Instance of OutcomeDefinition to be compared</param>
		/// <returns>Boolean</returns>
		public bool Equals(OutcomeDefinition input)
		{
			if (input == null)
				return false;

			return 
				(
					this.Codes == input.Codes ||
					this.Codes != null &&
					this.Codes.SequenceEqual(input.Codes)
				) && 
				(
					this.Category == input.Category ||
					(this.Category != null &&
					this.Category.Equals(input.Category))
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
				if (this.Codes != null)
					hashCode = hashCode * 59 + this.Codes.GetHashCode();
				if (this.Category != null)
					hashCode = hashCode * 59 + this.Category.GetHashCode();
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
