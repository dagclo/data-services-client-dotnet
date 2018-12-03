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
    /// CalculateResponse
    /// </summary>
    [DataContract]
    public partial class CalculateResponse : IEquatable<CalculateResponse>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CalculateResponse" /> class.
        /// </summary>
        /// <param name="PriceTotal">PriceTotal.</param>
        /// <param name="PricePerService">The map of service name to calculated price..</param>
        public CalculateResponse(PriceTotal PriceTotal = default(PriceTotal), Dictionary<string, PriceTotal> PricePerService = default(Dictionary<string, PriceTotal>))
        {
            this.PriceTotal = PriceTotal;
            this.PricePerService = PricePerService;
        }

        /// <summary>
        /// Gets or Sets PriceTotal
        /// </summary>
        [DataMember(Name = "price_total", EmitDefaultValue = false)]
        public PriceTotal PriceTotal { get; set; }

        /// <summary>
        /// The map of service name to calculated price.
        /// </summary>
        /// <value>The map of service name to calculated price.</value>
        [DataMember(Name = "price_per_service", EmitDefaultValue = false)]
        public Dictionary<string, PriceTotal> PricePerService { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CalculateResponse {\n");
            sb.Append("  PriceTotal: ").Append(PriceTotal).Append("\n");
            sb.Append("  PricePerService: ").Append(PricePerService).Append("\n");
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
            return this.Equals(input as CalculateResponse);
        }

        /// <summary>
        /// Returns true if CalculateResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of CalculateResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CalculateResponse input)
        {
            if (input == null)
                return false;

            return
                (
                    this.PriceTotal == input.PriceTotal ||
                    (this.PriceTotal != null &&
                    this.PriceTotal.Equals(input.PriceTotal))
                ) &&
                (
                    this.PricePerService == input.PricePerService ||
                    this.PricePerService != null &&
                    this.PricePerService.SequenceEqual(input.PricePerService)
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
                if (this.PriceTotal != null)
                    hashCode = hashCode * 59 + this.PriceTotal.GetHashCode();
                if (this.PricePerService != null)
                    hashCode = hashCode * 59 + this.PricePerService.GetHashCode();
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
