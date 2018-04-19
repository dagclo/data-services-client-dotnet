/* 
 * Phone Validation
 *
 * The Phone Validation data service parses, standardizes, and reformats phone numbers.  The service validates that a phone number is valid when considered against a set of  rules, including range of numbers in use, and formats. In addition, the service indicates what type of line the phone number is attached to, for example, fixed (land) line. ## Key functionality: * Parses and formats phone numbers in accordance with international and national standards. * Identifies the type of phone number, for example, Mobile, VoIP, Toll free, and so forth. * Provides easy-to-understand correction status, codes, and messages.
 *
 * OpenAPI spec version: 1.0
 * 
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Quadient.DataServices.Model.Phone
{
    /// <summary>
    /// OutcomeDefinition
    /// </summary>
    [DataContract]
    public partial class OutcomeDefinition :  IEquatable<OutcomeDefinition>, IValidatableObject
    {
        /// <summary>
        /// The final status of the object. The rules for selecting a &#x60;category&#x60; are as follows:  * Skipped: If the input &#x60;phone_number&#x60; is missing, null, blank, or entirely white spaces, &#x60;Skipped&#x60; is returned. * Invalid: If the input &#x60;phone_number&#x60; is not recognized, &#x60;Invalid&#x60; is returned. * Valid: If the input &#x60;phone_number&#x60; is recognized and matches exactly one or more of the formats, &#x60;Valid&#x60; is returned. * Corrected: If the input &#x60;phone_number&#x60;is recognized, but it does not match any of the formats, &#x60;Corrected&#x60; is returned. * Doubtful: Currently &#x60;Doubtful&#x60; is not an expected outcome category. It may be activated in later versions of the service in case a phone number is recognized but is deemed to be suspicious or otherwise unqualified. 
        /// </summary>
        /// <value>The final status of the object. The rules for selecting a &#x60;category&#x60; are as follows:  * Skipped: If the input &#x60;phone_number&#x60; is missing, null, blank, or entirely white spaces, &#x60;Skipped&#x60; is returned. * Invalid: If the input &#x60;phone_number&#x60; is not recognized, &#x60;Invalid&#x60; is returned. * Valid: If the input &#x60;phone_number&#x60; is recognized and matches exactly one or more of the formats, &#x60;Valid&#x60; is returned. * Corrected: If the input &#x60;phone_number&#x60;is recognized, but it does not match any of the formats, &#x60;Corrected&#x60; is returned. * Doubtful: Currently &#x60;Doubtful&#x60; is not an expected outcome category. It may be activated in later versions of the service in case a phone number is recognized but is deemed to be suspicious or otherwise unqualified. </value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum CategoryEnum
        {
            
            /// <summary>
            /// Enum Valid for value: Valid
            /// </summary>
            [EnumMember(Value = "Valid")]
            Valid = 1,
            
            /// <summary>
            /// Enum Corrected for value: Corrected
            /// </summary>
            [EnumMember(Value = "Corrected")]
            Corrected = 2,
            
            /// <summary>
            /// Enum Invalid for value: Invalid
            /// </summary>
            [EnumMember(Value = "Invalid")]
            Invalid = 3,
            
            /// <summary>
            /// Enum Skipped for value: Skipped
            /// </summary>
            [EnumMember(Value = "Skipped")]
            Skipped = 4,
            
            /// <summary>
            /// Enum Doubtful for value: Doubtful
            /// </summary>
            [EnumMember(Value = "Doubtful")]
            Doubtful = 5
        }

        /// <summary>
        /// The final status of the object. The rules for selecting a &#x60;category&#x60; are as follows:  * Skipped: If the input &#x60;phone_number&#x60; is missing, null, blank, or entirely white spaces, &#x60;Skipped&#x60; is returned. * Invalid: If the input &#x60;phone_number&#x60; is not recognized, &#x60;Invalid&#x60; is returned. * Valid: If the input &#x60;phone_number&#x60; is recognized and matches exactly one or more of the formats, &#x60;Valid&#x60; is returned. * Corrected: If the input &#x60;phone_number&#x60;is recognized, but it does not match any of the formats, &#x60;Corrected&#x60; is returned. * Doubtful: Currently &#x60;Doubtful&#x60; is not an expected outcome category. It may be activated in later versions of the service in case a phone number is recognized but is deemed to be suspicious or otherwise unqualified. 
        /// </summary>
        /// <value>The final status of the object. The rules for selecting a &#x60;category&#x60; are as follows:  * Skipped: If the input &#x60;phone_number&#x60; is missing, null, blank, or entirely white spaces, &#x60;Skipped&#x60; is returned. * Invalid: If the input &#x60;phone_number&#x60; is not recognized, &#x60;Invalid&#x60; is returned. * Valid: If the input &#x60;phone_number&#x60; is recognized and matches exactly one or more of the formats, &#x60;Valid&#x60; is returned. * Corrected: If the input &#x60;phone_number&#x60;is recognized, but it does not match any of the formats, &#x60;Corrected&#x60; is returned. * Doubtful: Currently &#x60;Doubtful&#x60; is not an expected outcome category. It may be activated in later versions of the service in case a phone number is recognized but is deemed to be suspicious or otherwise unqualified. </value>
        [DataMember(Name="category", EmitDefaultValue=false)]
        public CategoryEnum Category { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="OutcomeDefinition" /> class.
        /// </summary>
        [JsonConstructor]
        protected OutcomeDefinition() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="OutcomeDefinition" /> class.
        /// </summary>
        /// <param name="Category">The final status of the object. The rules for selecting a &#x60;category&#x60; are as follows:  * Skipped: If the input &#x60;phone_number&#x60; is missing, null, blank, or entirely white spaces, &#x60;Skipped&#x60; is returned. * Invalid: If the input &#x60;phone_number&#x60; is not recognized, &#x60;Invalid&#x60; is returned. * Valid: If the input &#x60;phone_number&#x60; is recognized and matches exactly one or more of the formats, &#x60;Valid&#x60; is returned. * Corrected: If the input &#x60;phone_number&#x60;is recognized, but it does not match any of the formats, &#x60;Corrected&#x60; is returned. * Doubtful: Currently &#x60;Doubtful&#x60; is not an expected outcome category. It may be activated in later versions of the service in case a phone number is recognized but is deemed to be suspicious or otherwise unqualified.  (required).</param>
        /// <param name="Codes">An object that contains correction codes as keys. The values may be either a string message or another object that contains additional information.  (required).</param>
        public OutcomeDefinition(CategoryEnum Category = default(CategoryEnum), Dictionary<string, string> Codes = default(Dictionary<string, string>))
        {
            // to ensure "Category" is required (not null)
            if (Category == null)
            {
                throw new InvalidDataException("Category is a required property for OutcomeDefinition and cannot be null");
            }
            else
            {
                this.Category = Category;
            }
            // to ensure "Codes" is required (not null)
            if (Codes == null)
            {
                throw new InvalidDataException("Codes is a required property for OutcomeDefinition and cannot be null");
            }
            else
            {
                this.Codes = Codes;
            }
        }
        

        /// <summary>
        /// An object that contains correction codes as keys. The values may be either a string message or another object that contains additional information. 
        /// </summary>
        /// <value>An object that contains correction codes as keys. The values may be either a string message or another object that contains additional information. </value>
        [DataMember(Name="codes", EmitDefaultValue=false)]
        public Dictionary<string, string> Codes { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class OutcomeDefinition {\n");
            sb.Append("  Category: ").Append(Category).Append("\n");
            sb.Append("  Codes: ").Append(Codes).Append("\n");
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
            return this.Equals(input as OutcomeDefinition);
        }

        /// <summary>
        /// Returns true if OutcomeDefinition instances are equal
        /// </summary>
        /// <param name="input">Instance of OutcomeDefinition to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(OutcomeDefinition input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Category == input.Category ||
                    (this.Category != null &&
                    this.Category.Equals(input.Category))
                ) && 
                (
                    this.Codes == input.Codes ||
                    this.Codes != null &&
                    this.Codes.SequenceEqual(input.Codes)
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
                if (this.Category != null)
                    hashCode = hashCode * 59 + this.Category.GetHashCode();
                if (this.Codes != null)
                    hashCode = hashCode * 59 + this.Codes.GetHashCode();
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
