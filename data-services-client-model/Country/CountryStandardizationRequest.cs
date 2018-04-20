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
    /// CountryStandardizationRequest
    /// </summary>
    [DataContract]
    public partial class CountryStandardizationRequest :  IEquatable<CountryStandardizationRequest>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CountryStandardizationRequest" /> class.
        /// </summary>
        /// <param name="Language">Language short code. It can be empty - default value is &#39;en&#39;. Api return country name in this language. (default to &quot;en&quot;).</param>
        /// <param name="Countries">Array of input countries. It can be the country code or name to search for..</param>
        public CountryStandardizationRequest(string Language = "en", List<string> Countries = default(List<string>))
        {
            // use default value if no "Language" provided
            if (Language == null)
            {
                this.Language = "en";
            }
            else
            {
                this.Language = Language;
            }
            this.Countries = Countries;
        }
        
        /// <summary>
        /// Language short code. It can be empty - default value is &#39;en&#39;. Api return country name in this language.
        /// </summary>
        /// <value>Language short code. It can be empty - default value is &#39;en&#39;. Api return country name in this language.</value>
        [DataMember(Name="language", EmitDefaultValue=false)]
        public string Language { get; set; }

        /// <summary>
        /// Array of input countries. It can be the country code or name to search for.
        /// </summary>
        /// <value>Array of input countries. It can be the country code or name to search for.</value>
        [DataMember(Name="countries", EmitDefaultValue=false)]
        public List<string> Countries { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CountryStandardizationRequest {\n");
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
            return this.Equals(input as CountryStandardizationRequest);
        }

        /// <summary>
        /// Returns true if CountryStandardizationRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of CountryStandardizationRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CountryStandardizationRequest input)
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
        IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }

}
