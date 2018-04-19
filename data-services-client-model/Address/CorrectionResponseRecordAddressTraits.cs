/* 
 * Address Correction
 *
 * The Address Correction data service validates and corrects postal addresses from around the world.  The service is currently available for the following countries: United States, United Kingdom, and Canada. Address correction standardizes address spellings, abbreviations, and formats, adds additional delivery information, such as geocodes, and verifies the deliverability of each address.  It improves your delivery success odds by correcting incorrect information, such as postal codes and typos in street names, and verifying delivery target names.  Key functionality: * Corrects the spelling of street names and cities. * Standardizes address formats and abbreviations, based on country ID. * Enriches output with deliverability information for an address, such as USPS DPV® confirmation and geocoding coordinates. * Provides easy-to-understand correction status, codes, and messages.
 *
 * OpenAPI spec version: 1.0.12
 * 
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using System.Text;
using Newtonsoft.Json;

namespace Quadient.DataServices.Model.Address
{
    /// <summary>
    /// Defines an output group that contains additional address elements, enabled using the &#x60;output_groups&#x60; configuration setting. The availability of individual properties of this group varies depending on country.
    /// </summary>
    [DataContract]
    public partial class CorrectionResponseRecordAddressTraits :  IEquatable<CorrectionResponseRecordAddressTraits>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CorrectionResponseRecordAddressTraits" /> class.
        /// </summary>
        /// <param name="CityAbbreviated">Abbreviated version of city name when applicable. Currently available for United States addresses only..</param>
        /// <param name="CountyCode">Unique county code. Currently available for United States addresses only..</param>
        /// <param name="Dpc">Unique delivery point code. Currently available for United States addresses only..</param>
        public CorrectionResponseRecordAddressTraits(string CityAbbreviated = default(string), string CountyCode = default(string), string Dpc = default(string))
        {
            this.CityAbbreviated = CityAbbreviated;
            this.CountyCode = CountyCode;
            this.Dpc = Dpc;
        }
        
        /// <summary>
        /// Abbreviated version of city name when applicable. Currently available for United States addresses only.
        /// </summary>
        /// <value>Abbreviated version of city name when applicable. Currently available for United States addresses only.</value>
        [DataMember(Name="city_abbreviated", EmitDefaultValue=false)]
        public string CityAbbreviated { get; set; }

        /// <summary>
        /// Unique county code. Currently available for United States addresses only.
        /// </summary>
        /// <value>Unique county code. Currently available for United States addresses only.</value>
        [DataMember(Name="county_code", EmitDefaultValue=false)]
        public string CountyCode { get; set; }

        /// <summary>
        /// Unique delivery point code. Currently available for United States addresses only.
        /// </summary>
        /// <value>Unique delivery point code. Currently available for United States addresses only.</value>
        [DataMember(Name="dpc", EmitDefaultValue=false)]
        public string Dpc { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CorrectionResponseRecordAddressTraits {\n");
            sb.Append("  CityAbbreviated: ").Append(CityAbbreviated).Append("\n");
            sb.Append("  CountyCode: ").Append(CountyCode).Append("\n");
            sb.Append("  Dpc: ").Append(Dpc).Append("\n");
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
            return this.Equals(input as CorrectionResponseRecordAddressTraits);
        }

        /// <summary>
        /// Returns true if CorrectionResponseRecordAddressTraits instances are equal
        /// </summary>
        /// <param name="input">Instance of CorrectionResponseRecordAddressTraits to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CorrectionResponseRecordAddressTraits input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.CityAbbreviated == input.CityAbbreviated ||
                    (this.CityAbbreviated != null &&
                    this.CityAbbreviated.Equals(input.CityAbbreviated))
                ) && 
                (
                    this.CountyCode == input.CountyCode ||
                    (this.CountyCode != null &&
                    this.CountyCode.Equals(input.CountyCode))
                ) && 
                (
                    this.Dpc == input.Dpc ||
                    (this.Dpc != null &&
                    this.Dpc.Equals(input.Dpc))
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
                if (this.CityAbbreviated != null)
                    hashCode = hashCode * 59 + this.CityAbbreviated.GetHashCode();
                if (this.CountyCode != null)
                    hashCode = hashCode * 59 + this.CountyCode.GetHashCode();
                if (this.Dpc != null)
                    hashCode = hashCode * 59 + this.Dpc.GetHashCode();
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
