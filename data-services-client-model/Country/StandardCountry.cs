/* 
 * Country Standardization
 *
 * Country Standardization
 *
 * OpenAPI spec version: 1.0.0
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
    /// A country standardization result
    /// </summary>
    [DataContract]
    public partial class StandardCountry : IEquatable<StandardCountry>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="StandardCountry" /> class.
        /// </summary>
        /// <param name="Input">String from the request..</param>
        /// <param name="Name">Country name.</param>
        /// <param name="Iso2">Two letter ISO 3166-1 (alpha 2) code.</param>
        /// <param name="Iso3">Three letter ISO 3166-1 (alpha 3) code.</param>
        public StandardCountry(string Input = default(string), string Name = default(string), string Iso2 = default(string), string Iso3 = default(string))
        {
            this.Input = Input;
            this.Name = Name;
            this.Iso2 = Iso2;
            this.Iso3 = Iso3;
        }
        
        /// <summary>
        /// String from the request.
        /// </summary>
        /// <value>String from the request.</value>
        [DataMember(Name="input", EmitDefaultValue=false)]
        public string Input { get; set; }

        /// <summary>
        /// Country name
        /// </summary>
        /// <value>Country name</value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }

        /// <summary>
        /// Two letter ISO 3166-1 (alpha 2) code
        /// </summary>
        /// <value>Two letter ISO 3166-1 (alpha 2) code</value>
        [DataMember(Name="iso2", EmitDefaultValue=false)]
        public string Iso2 { get; set; }

        /// <summary>
        /// Three letter ISO 3166-1 (alpha 3) code
        /// </summary>
        /// <value>Three letter ISO 3166-1 (alpha 3) code</value>
        [DataMember(Name="iso3", EmitDefaultValue=false)]
        public string Iso3 { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class StandardCountry {\n");
            sb.Append("  Input: ").Append(Input).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Iso2: ").Append(Iso2).Append("\n");
            sb.Append("  Iso3: ").Append(Iso3).Append("\n");
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
            return this.Equals(input as StandardCountry);
        }

        /// <summary>
        /// Returns true if StandardCountry instances are equal
        /// </summary>
        /// <param name="input">Instance of StandardCountry to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(StandardCountry input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Input == input.Input ||
                    (this.Input != null &&
                    this.Input.Equals(input.Input))
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.Iso2 == input.Iso2 ||
                    (this.Iso2 != null &&
                    this.Iso2.Equals(input.Iso2))
                ) && 
                (
                    this.Iso3 == input.Iso3 ||
                    (this.Iso3 != null &&
                    this.Iso3.Equals(input.Iso3))
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
                if (this.Input != null)
                    hashCode = hashCode * 59 + this.Input.GetHashCode();
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.Iso2 != null)
                    hashCode = hashCode * 59 + this.Iso2.GetHashCode();
                if (this.Iso3 != null)
                    hashCode = hashCode * 59 + this.Iso3.GetHashCode();
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
