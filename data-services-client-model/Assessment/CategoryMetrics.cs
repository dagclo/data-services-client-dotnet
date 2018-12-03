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
    /// CategoryMetrics
    /// </summary>
    [DataContract]
    public partial class CategoryMetrics : IEquatable<CategoryMetrics>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CategoryMetrics" /> class.
        /// </summary>
        /// <param name="Valid">Number of records that are valid as-is.</param>
        /// <param name="Corrected">Number of records that could be corrected by the data service.</param>
        /// <param name="Doubtful">Number of records that are marked as &#39;Doubtful&#39;, typically with some suggested change.</param>
        /// <param name="Invalid">Number of records that are invalid.</param>
        /// <param name="Skipped">Number of records that are skipped by the data service.</param>
        public CategoryMetrics(int? Valid = default(int?), int? Corrected = default(int?), int? Doubtful = default(int?), int? Invalid = default(int?), int? Skipped = default(int?))
        {
            this.Valid = Valid;
            this.Corrected = Corrected;
            this.Doubtful = Doubtful;
            this.Invalid = Invalid;
            this.Skipped = Skipped;
        }
        
        /// <summary>
        /// Number of records that are valid as-is
        /// </summary>
        /// <value>Number of records that are valid as-is</value>
        [DataMember(Name="Valid", EmitDefaultValue=false)]
        public int? Valid { get; set; }

        /// <summary>
        /// Number of records that could be corrected by the data service
        /// </summary>
        /// <value>Number of records that could be corrected by the data service</value>
        [DataMember(Name="Corrected", EmitDefaultValue=false)]
        public int? Corrected { get; set; }

        /// <summary>
        /// Number of records that are marked as &#39;Doubtful&#39;, typically with some suggested change
        /// </summary>
        /// <value>Number of records that are marked as &#39;Doubtful&#39;, typically with some suggested change</value>
        [DataMember(Name="Doubtful", EmitDefaultValue=false)]
        public int? Doubtful { get; set; }

        /// <summary>
        /// Number of records that are invalid
        /// </summary>
        /// <value>Number of records that are invalid</value>
        [DataMember(Name="Invalid", EmitDefaultValue=false)]
        public int? Invalid { get; set; }

        /// <summary>
        /// Number of records that are skipped by the data service
        /// </summary>
        /// <value>Number of records that are skipped by the data service</value>
        [DataMember(Name="Skipped", EmitDefaultValue=false)]
        public int? Skipped { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CategoryMetrics {\n");
            sb.Append("  Valid: ").Append(Valid).Append("\n");
            sb.Append("  Corrected: ").Append(Corrected).Append("\n");
            sb.Append("  Doubtful: ").Append(Doubtful).Append("\n");
            sb.Append("  Invalid: ").Append(Invalid).Append("\n");
            sb.Append("  Skipped: ").Append(Skipped).Append("\n");
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
            return this.Equals(input as CategoryMetrics);
        }

        /// <summary>
        /// Returns true if CategoryMetrics instances are equal
        /// </summary>
        /// <param name="input">Instance of CategoryMetrics to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CategoryMetrics input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Valid == input.Valid ||
                    (this.Valid != null &&
                    this.Valid.Equals(input.Valid))
                ) && 
                (
                    this.Corrected == input.Corrected ||
                    (this.Corrected != null &&
                    this.Corrected.Equals(input.Corrected))
                ) && 
                (
                    this.Doubtful == input.Doubtful ||
                    (this.Doubtful != null &&
                    this.Doubtful.Equals(input.Doubtful))
                ) && 
                (
                    this.Invalid == input.Invalid ||
                    (this.Invalid != null &&
                    this.Invalid.Equals(input.Invalid))
                ) && 
                (
                    this.Skipped == input.Skipped ||
                    (this.Skipped != null &&
                    this.Skipped.Equals(input.Skipped))
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
                if (this.Valid != null)
                    hashCode = hashCode * 59 + this.Valid.GetHashCode();
                if (this.Corrected != null)
                    hashCode = hashCode * 59 + this.Corrected.GetHashCode();
                if (this.Doubtful != null)
                    hashCode = hashCode * 59 + this.Doubtful.GetHashCode();
                if (this.Invalid != null)
                    hashCode = hashCode * 59 + this.Invalid.GetHashCode();
                if (this.Skipped != null)
                    hashCode = hashCode * 59 + this.Skipped.GetHashCode();
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
