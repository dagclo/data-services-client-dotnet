/* 
 * Data Quality Assessment
 *
 * Allows users to assess the Quadient Data Services before buying. This service runs assessment jobs based on real data, but does not give back the records that have been corrected. Rather, it provides \"assessment metrics\" which can be used to determine and explain the value of using Data Services. 
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

namespace Quadient.DataServices.Model.Assessment
{
    /// <summary>
    /// JobInformationResponseAssessmentMetricsAddresscorrectionGeocodes
    /// </summary>
    [DataContract]
    public partial class JobInformationResponseAssessmentMetricsAddresscorrectionGeocodes : IEquatable<JobInformationResponseAssessmentMetricsAddresscorrectionGeocodes>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="JobInformationResponseAssessmentMetricsAddresscorrectionGeocodes" /> class.
        /// </summary>
        /// <param name="AddressGeocode">Number of geocode matches at the precision of the concrete address.</param>
        /// <param name="StreetGeocode">Number of geocode matches at the precision of the street.</param>
        /// <param name="PostalCodeGeocode">Number of geocode matches at the precision of the postal code.</param>
        /// <param name="CountyGeocode">Number of geocode matches at the precision of the county.</param>
        /// <param name="NoMatch">Number of addresses where geocodes could not be resolved.</param>
        public JobInformationResponseAssessmentMetricsAddresscorrectionGeocodes(int? AddressGeocode = default(int?), int? StreetGeocode = default(int?), int? PostalCodeGeocode = default(int?), int? CountyGeocode = default(int?), int? NoMatch = default(int?))
        {
            this.AddressGeocode = AddressGeocode;
            this.StreetGeocode = StreetGeocode;
            this.PostalCodeGeocode = PostalCodeGeocode;
            this.CountyGeocode = CountyGeocode;
            this.NoMatch = NoMatch;
        }
        
        /// <summary>
        /// Number of geocode matches at the precision of the concrete address
        /// </summary>
        /// <value>Number of geocode matches at the precision of the concrete address</value>
        [DataMember(Name="address_geocode", EmitDefaultValue=false)]
        public int? AddressGeocode { get; set; }

        /// <summary>
        /// Number of geocode matches at the precision of the street
        /// </summary>
        /// <value>Number of geocode matches at the precision of the street</value>
        [DataMember(Name="street_geocode", EmitDefaultValue=false)]
        public int? StreetGeocode { get; set; }

        /// <summary>
        /// Number of geocode matches at the precision of the postal code
        /// </summary>
        /// <value>Number of geocode matches at the precision of the postal code</value>
        [DataMember(Name="postal_code_geocode", EmitDefaultValue=false)]
        public int? PostalCodeGeocode { get; set; }

        /// <summary>
        /// Number of geocode matches at the precision of the county
        /// </summary>
        /// <value>Number of geocode matches at the precision of the county</value>
        [DataMember(Name="county_geocode", EmitDefaultValue=false)]
        public int? CountyGeocode { get; set; }

        /// <summary>
        /// Number of addresses where geocodes could not be resolved
        /// </summary>
        /// <value>Number of addresses where geocodes could not be resolved</value>
        [DataMember(Name="no_match", EmitDefaultValue=false)]
        public int? NoMatch { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class JobInformationResponseAssessmentMetricsAddresscorrectionGeocodes {\n");
            sb.Append("  AddressGeocode: ").Append(AddressGeocode).Append("\n");
            sb.Append("  StreetGeocode: ").Append(StreetGeocode).Append("\n");
            sb.Append("  PostalCodeGeocode: ").Append(PostalCodeGeocode).Append("\n");
            sb.Append("  CountyGeocode: ").Append(CountyGeocode).Append("\n");
            sb.Append("  NoMatch: ").Append(NoMatch).Append("\n");
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
            return this.Equals(input as JobInformationResponseAssessmentMetricsAddresscorrectionGeocodes);
        }

        /// <summary>
        /// Returns true if JobInformationResponseAssessmentMetricsAddresscorrectionGeocodes instances are equal
        /// </summary>
        /// <param name="input">Instance of JobInformationResponseAssessmentMetricsAddresscorrectionGeocodes to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(JobInformationResponseAssessmentMetricsAddresscorrectionGeocodes input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.AddressGeocode == input.AddressGeocode ||
                    (this.AddressGeocode != null &&
                    this.AddressGeocode.Equals(input.AddressGeocode))
                ) && 
                (
                    this.StreetGeocode == input.StreetGeocode ||
                    (this.StreetGeocode != null &&
                    this.StreetGeocode.Equals(input.StreetGeocode))
                ) && 
                (
                    this.PostalCodeGeocode == input.PostalCodeGeocode ||
                    (this.PostalCodeGeocode != null &&
                    this.PostalCodeGeocode.Equals(input.PostalCodeGeocode))
                ) && 
                (
                    this.CountyGeocode == input.CountyGeocode ||
                    (this.CountyGeocode != null &&
                    this.CountyGeocode.Equals(input.CountyGeocode))
                ) && 
                (
                    this.NoMatch == input.NoMatch ||
                    (this.NoMatch != null &&
                    this.NoMatch.Equals(input.NoMatch))
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
                if (this.AddressGeocode != null)
                    hashCode = hashCode * 59 + this.AddressGeocode.GetHashCode();
                if (this.StreetGeocode != null)
                    hashCode = hashCode * 59 + this.StreetGeocode.GetHashCode();
                if (this.PostalCodeGeocode != null)
                    hashCode = hashCode * 59 + this.PostalCodeGeocode.GetHashCode();
                if (this.CountyGeocode != null)
                    hashCode = hashCode * 59 + this.CountyGeocode.GetHashCode();
                if (this.NoMatch != null)
                    hashCode = hashCode * 59 + this.NoMatch.GetHashCode();
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
