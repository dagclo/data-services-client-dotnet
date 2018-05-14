/* 
 * Pricebook Management
 *
 * No description provided (generated by Swagger Codegen https://github.com/swagger-api/swagger-codegen)
 *
 * OpenAPI spec version: 0.1
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

namespace Quadient.DataServices.Model.Pricebook
{
    /// <summary>
    /// PriceSettingRequest
    /// </summary>
    [DataContract]
    public partial class PriceSettingRequest :  IEquatable<PriceSettingRequest>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PriceSettingRequest" /> class.
        /// </summary>
        /// <param name="Prices">Prices.</param>
        public PriceSettingRequest(List<Price> Prices = default(List<Price>))
        {
            this.Prices = Prices;
        }
        
        /// <summary>
        /// Gets or Sets Prices
        /// </summary>
        [DataMember(Name="prices", EmitDefaultValue=false)]
        public List<Price> Prices { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PriceSettingRequest {\n");
            sb.Append("  Prices: ").Append(Prices).Append("\n");
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
            return this.Equals(input as PriceSettingRequest);
        }

        /// <summary>
        /// Returns true if PriceSettingRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of PriceSettingRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PriceSettingRequest input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Prices == input.Prices ||
                    this.Prices != null &&
                    this.Prices.SequenceEqual(input.Prices)
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
                if (this.Prices != null)
                    hashCode = hashCode * 59 + this.Prices.GetHashCode();
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