/* 
 * Country Standardization
 *
 * Country Standardization
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

namespace Quadient.DataServices.Model.Country
{
	/// <summary>
	/// CountryOutcome
	/// </summary>
	[DataContract]
	public partial class CountryOutcome : IEquatable<CountryOutcome>, IValidatableObject
	{
		/// <summary>
		/// The final status of the object
		/// </summary>
		/// <value>The final status of the object</value>
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
		/// The final status of the object
		/// </summary>
		/// <value>The final status of the object</value>
		[DataMember(Name="category", EmitDefaultValue=false)]
		public CategoryEnum Category { get; set; }
		/// <summary>
		/// Initializes a new instance of the <see cref="CountryOutcome" /> class.
		/// </summary>
		[JsonConstructorAttribute]
		protected CountryOutcome() { }
		/// <summary>
		/// Initializes a new instance of the <see cref="CountryOutcome" /> class.
		/// </summary>
		/// <param name="Category">The final status of the object (required).</param>
		/// <param name="Codes">An object containing distinct correction codes as keys. The values may be either a string message or another object containing additional information.</param>
		public CountryOutcome(CategoryEnum Category = default(CategoryEnum), Dictionary<string, string> Codes = default(Dictionary<string, string>)) : base()
		{
			// to ensure "Category" is required (not null)
			if (Category == null)
			{
				throw new InvalidDataException("Category is a required property for CountryOutcome and cannot be null");
			}
			else
			{
				this.Category = Category;
			}
			this.Codes = Codes;
		}
		

		/// <summary>
		/// An object containing distinct correction codes as keys. The values may be either a string message or another object containing additional information
		/// </summary>
		/// <value>An object containing distinct correction codes as keys. The values may be either a string message or another object containing additional information</value>
		[DataMember(Name="codes", EmitDefaultValue=false)]
		public Dictionary<string, string> Codes { get; set; }

		/// <summary>
		/// Returns the string presentation of the object
		/// </summary>
		/// <returns>String presentation of the object</returns>
		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.Append("class CountryOutcome {\n");
			sb.Append("  ").Append(base.ToString().Replace("\n", "\n  ")).Append("\n");
			sb.Append("  Category: ").Append(Category).Append("\n");
			sb.Append("  Codes: ").Append(Codes).Append("\n");
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
			return this.Equals(input as CountryOutcome);
		}

		/// <summary>
		/// Returns true if CountryOutcome instances are equal
		/// </summary>
		/// <param name="input">Instance of CountryOutcome to be compared</param>
		/// <returns>Boolean</returns>
		public bool Equals(CountryOutcome input)
		{
			if (input == null)
				return false;

			return base.Equals(input) && 
				(
					this.Category == input.Category ||
					(this.Category != null &&
					this.Category.Equals(input.Category))
				) && base.Equals(input) && 
				(
					this.Codes == input.Codes ||
					this.Codes != null &&
					this.Codes.SequenceEqual(input.Codes)
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
				int hashCode = base.GetHashCode();
				if (this.Category != null)
					hashCode = hashCode * 59 + this.Category.GetHashCode();
				if (this.Codes != null)
					hashCode = hashCode * 59 + this.Codes.GetHashCode();
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
