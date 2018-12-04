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
	/// Results from country standardization.
	/// </summary>
	[DataContract]
	public partial class CountryStandardizationResponse : IEquatable<CountryStandardizationResponse>, IValidatableObject
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="CountryStandardizationResponse" /> class.
		/// </summary>
		/// <param name="Language">Output localization of country name.</param>
		/// <param name="Countries">Countries.</param>
		public CountryStandardizationResponse(string Language = default(string), List<OutputCountry> Countries = default(List<OutputCountry>))
		{
			this.Language = Language;
			this.Countries = Countries;
		}
		
		/// <summary>
		/// Output localization of country name
		/// </summary>
		/// <value>Output localization of country name</value>
		[DataMember(Name="language", EmitDefaultValue=false)]
		public string Language { get; set; }

		/// <summary>
		/// Gets or Sets Countries
		/// </summary>
		[DataMember(Name="countries", EmitDefaultValue=false)]
		public List<OutputCountry> Countries { get; set; }

		/// <summary>
		/// Returns the string presentation of the object
		/// </summary>
		/// <returns>String presentation of the object</returns>
		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.Append("class CountryStandardizationResponse {\n");
			sb.Append("  Language: ").Append(Language).Append("\n");
			sb.Append("  Countries: ").Append(Countries).Append("\n");
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
			return this.Equals(input as CountryStandardizationResponse);
		}

		/// <summary>
		/// Returns true if CountryStandardizationResponse instances are equal
		/// </summary>
		/// <param name="input">Instance of CountryStandardizationResponse to be compared</param>
		/// <returns>Boolean</returns>
		public bool Equals(CountryStandardizationResponse input)
		{
			if (input == null)
				return false;

			return 
				(
					this.Language == input.Language ||
					(this.Language != null &&
					this.Language.Equals(input.Language))
				) && 
				(
					this.Countries == input.Countries ||
					this.Countries != null &&
					this.Countries.SequenceEqual(input.Countries)
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
				if (this.Language != null)
					hashCode = hashCode * 59 + this.Language.GetHashCode();
				if (this.Countries != null)
					hashCode = hashCode * 59 + this.Countries.GetHashCode();
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
