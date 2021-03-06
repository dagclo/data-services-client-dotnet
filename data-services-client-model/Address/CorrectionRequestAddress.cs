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
	/// CorrectionRequestAddress
	/// </summary>
	[DataContract]
	public partial class CorrectionRequestAddress : IEquatable<CorrectionRequestAddress>, IValidatableObject
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="CorrectionRequestAddress" /> class.
		/// </summary>
		[JsonConstructorAttribute]
		protected CorrectionRequestAddress() { }
		/// <summary>
		/// Initializes a new instance of the <see cref="CorrectionRequestAddress" /> class.
		/// </summary>
		/// <param name="Organization">The name of the organization associated with the address..</param>
		/// <param name="AddressLines">The address lines, which contain street address information such as street name, house number, apartment number, and so forth. (required).</param>
		/// <param name="City">The name of the city or post town..</param>
		/// <param name="County">The name of the county..</param>
		/// <param name="ProvinceOrState">The name or code of the state or province. For the United States and Canada, the 2-letter state  or province code is preferred and is returned in corrected responses..</param>
		/// <param name="PostalCode">The postal code of the address..</param>
		/// <param name="Country">The country code or name. The ISO 3166 2-letter country code is preferred and is returned in corrected responses. (required).</param>
		public CorrectionRequestAddress(string Organization = default(string), List<string> AddressLines = default(List<string>), string City = default(string), string County = default(string), string ProvinceOrState = default(string), string PostalCode = default(string), string Country = default(string))
		{
			// to ensure "AddressLines" is required (not null)
			if (AddressLines == null)
			{
				throw new InvalidDataException("AddressLines is a required property for CorrectionRequestAddress and cannot be null");
			}
			else
			{
				this.AddressLines = AddressLines;
			}
			// to ensure "Country" is required (not null)
			if (Country == null)
			{
				throw new InvalidDataException("Country is a required property for CorrectionRequestAddress and cannot be null");
			}
			else
			{
				this.Country = Country;
			}
			this.Organization = Organization;
			this.City = City;
			this.County = County;
			this.ProvinceOrState = ProvinceOrState;
			this.PostalCode = PostalCode;
		}
		
		/// <summary>
		/// The name of the organization associated with the address.
		/// </summary>
		/// <value>The name of the organization associated with the address.</value>
		[DataMember(Name="organization", EmitDefaultValue=false)]
		public string Organization { get; set; }

		/// <summary>
		/// The address lines, which contain street address information such as street name, house number, apartment number, and so forth.
		/// </summary>
		/// <value>The address lines, which contain street address information such as street name, house number, apartment number, and so forth.</value>
		[DataMember(Name="address_lines", EmitDefaultValue=false)]
		public List<string> AddressLines { get; set; }

		/// <summary>
		/// The name of the city or post town.
		/// </summary>
		/// <value>The name of the city or post town.</value>
		[DataMember(Name="city", EmitDefaultValue=false)]
		public string City { get; set; }

		/// <summary>
		/// The name of the county.
		/// </summary>
		/// <value>The name of the county.</value>
		[DataMember(Name="county", EmitDefaultValue=false)]
		public string County { get; set; }

		/// <summary>
		/// The name or code of the state or province. For the United States and Canada, the 2-letter state  or province code is preferred and is returned in corrected responses.
		/// </summary>
		/// <value>The name or code of the state or province. For the United States and Canada, the 2-letter state	or province code is preferred and is returned in corrected responses.</value>
		[DataMember(Name="province_or_state", EmitDefaultValue=false)]
		public string ProvinceOrState { get; set; }

		/// <summary>
		/// The postal code of the address.
		/// </summary>
		/// <value>The postal code of the address.</value>
		[DataMember(Name="postal_code", EmitDefaultValue=false)]
		public string PostalCode { get; set; }

		/// <summary>
		/// The country code or name. The ISO 3166 2-letter country code is preferred and is returned in corrected responses.
		/// </summary>
		/// <value>The country code or name. The ISO 3166 2-letter country code is preferred and is returned in corrected responses.</value>
		[DataMember(Name="country", EmitDefaultValue=false)]
		public string Country { get; set; }

		/// <summary>
		/// Returns the string presentation of the object
		/// </summary>
		/// <returns>String presentation of the object</returns>
		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.Append("class CorrectionRequestAddress {\n");
			sb.Append("  Organization: ").Append(Organization).Append("\n");
			sb.Append("  AddressLines: ").Append(AddressLines).Append("\n");
			sb.Append("  City: ").Append(City).Append("\n");
			sb.Append("  County: ").Append(County).Append("\n");
			sb.Append("  ProvinceOrState: ").Append(ProvinceOrState).Append("\n");
			sb.Append("  PostalCode: ").Append(PostalCode).Append("\n");
			sb.Append("  Country: ").Append(Country).Append("\n");
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
			return this.Equals(input as CorrectionRequestAddress);
		}

		/// <summary>
		/// Returns true if CorrectionRequestAddress instances are equal
		/// </summary>
		/// <param name="input">Instance of CorrectionRequestAddress to be compared</param>
		/// <returns>Boolean</returns>
		public bool Equals(CorrectionRequestAddress input)
		{
			if (input == null)
				return false;

			return 
				(
					this.Organization == input.Organization ||
					(this.Organization != null &&
					this.Organization.Equals(input.Organization))
				) && 
				(
					this.AddressLines == input.AddressLines ||
					this.AddressLines != null &&
					this.AddressLines.SequenceEqual(input.AddressLines)
				) && 
				(
					this.City == input.City ||
					(this.City != null &&
					this.City.Equals(input.City))
				) && 
				(
					this.County == input.County ||
					(this.County != null &&
					this.County.Equals(input.County))
				) && 
				(
					this.ProvinceOrState == input.ProvinceOrState ||
					(this.ProvinceOrState != null &&
					this.ProvinceOrState.Equals(input.ProvinceOrState))
				) && 
				(
					this.PostalCode == input.PostalCode ||
					(this.PostalCode != null &&
					this.PostalCode.Equals(input.PostalCode))
				) && 
				(
					this.Country == input.Country ||
					(this.Country != null &&
					this.Country.Equals(input.Country))
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
				if (this.Organization != null)
					hashCode = hashCode * 59 + this.Organization.GetHashCode();
				if (this.AddressLines != null)
					hashCode = hashCode * 59 + this.AddressLines.GetHashCode();
				if (this.City != null)
					hashCode = hashCode * 59 + this.City.GetHashCode();
				if (this.County != null)
					hashCode = hashCode * 59 + this.County.GetHashCode();
				if (this.ProvinceOrState != null)
					hashCode = hashCode * 59 + this.ProvinceOrState.GetHashCode();
				if (this.PostalCode != null)
					hashCode = hashCode * 59 + this.PostalCode.GetHashCode();
				if (this.Country != null)
					hashCode = hashCode * 59 + this.Country.GetHashCode();
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
