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
using SwaggerDateConverter = Quadient.DataServices.System.Model.Client.SwaggerDateConverter;

namespace Quadient.DataServices.System.Model.Pricebook
{
    /// <summary>
    /// EstimateDetails
    /// </summary>
    [DataContract]
    public partial class EstimateDetails : IEquatable<EstimateDetails>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EstimateDetails" /> class.
        /// </summary>
        /// <param name="UseStrict">Indicate whether strict validation should be used. Strict validation will reject unknown services. (default to true).</param>
        /// <param name="ServiceUse">Maps services to overall &#x60;count&#x60;s as well as (optionally) break down/out of that count into tiers. The more breaking out of counts to tiers is done, the more precise the estimate will be. In general you can expect a rather pessimistic estimate when no tiers are specified. .</param>
        public EstimateDetails(bool? UseStrict = true, Dictionary<string, Dictionary<string, decimal?>> ServiceUse = default(Dictionary<string, Dictionary<string, decimal?>>))
        {
            // use default value if no "UseStrict" provided
            if (UseStrict == null)
            {
                this.UseStrict = true;
            }
            else
            {
                this.UseStrict = UseStrict;
            }
            this.ServiceUse = ServiceUse;
        }
        
        /// <summary>
        /// Indicate whether strict validation should be used. Strict validation will reject unknown services.
        /// </summary>
        /// <value>Indicate whether strict validation should be used. Strict validation will reject unknown services.</value>
        [DataMember(Name="use_strict", EmitDefaultValue=false)]
        public bool? UseStrict { get; set; }

        /// <summary>
        /// Maps services to overall &#x60;count&#x60;s as well as (optionally) break down/out of that count into tiers. The more breaking out of counts to tiers is done, the more precise the estimate will be. In general you can expect a rather pessimistic estimate when no tiers are specified. 
        /// </summary>
        /// <value>Maps services to overall &#x60;count&#x60;s as well as (optionally) break down/out of that count into tiers. The more breaking out of counts to tiers is done, the more precise the estimate will be. In general you can expect a rather pessimistic estimate when no tiers are specified. </value>
        [DataMember(Name="service_use", EmitDefaultValue=false)]
        public Dictionary<string, Dictionary<string, decimal?>> ServiceUse { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class EstimateDetails {\n");
            sb.Append("  UseStrict: ").Append(UseStrict).Append("\n");
            sb.Append("  ServiceUse: ").Append(ServiceUse).Append("\n");
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
            return this.Equals(input as EstimateDetails);
        }

        /// <summary>
        /// Returns true if EstimateDetails instances are equal
        /// </summary>
        /// <param name="input">Instance of EstimateDetails to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(EstimateDetails input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.UseStrict == input.UseStrict ||
                    (this.UseStrict != null &&
                    this.UseStrict.Equals(input.UseStrict))
                ) && 
                (
                    this.ServiceUse == input.ServiceUse ||
                    this.ServiceUse != null &&
                    this.ServiceUse.SequenceEqual(input.ServiceUse)
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
                if (this.UseStrict != null)
                    hashCode = hashCode * 59 + this.UseStrict.GetHashCode();
                if (this.ServiceUse != null)
                    hashCode = hashCode * 59 + this.ServiceUse.GetHashCode();
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
