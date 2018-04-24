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

namespace Quadient.DataServices.Model.Phone
{
    /// <summary>
    /// PhoneValidationRequestRecord
    /// </summary>
    [DataContract]
    public partial class PhoneValidationRequestRecord : IEquatable<PhoneValidationRequestRecord>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PhoneValidationRequestRecord" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected PhoneValidationRequestRecord() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="PhoneValidationRequestRecord" /> class.
        /// </summary>
        /// <param name="Id">User-specified reference id or name for the job. For example, My Job ID...</param>
        /// <param name="Country">The country code or name. The ISO 3166 2-letter country code is preferred..</param>
        /// <param name="PhoneNumber">The phone number to be validated. (required).</param>
        public PhoneValidationRequestRecord(string Id = default(string), string Country = default(string), string PhoneNumber = default(string))
        {
            // to ensure "PhoneNumber" is required (not null)
            if (PhoneNumber == null)
            {
                throw new InvalidDataException("PhoneNumber is a required property for PhoneValidationRequestRecord and cannot be null");
            }
            else
            {
                this.PhoneNumber = PhoneNumber;
            }
            this.Id = Id;
            this.Country = Country;
        }
        
        /// <summary>
        /// User-specified reference id or name for the job. For example, My Job ID..
        /// </summary>
        /// <value>User-specified reference id or name for the job. For example, My Job ID..</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; set; }

        /// <summary>
        /// The country code or name. The ISO 3166 2-letter country code is preferred.
        /// </summary>
        /// <value>The country code or name. The ISO 3166 2-letter country code is preferred.</value>
        [DataMember(Name="country", EmitDefaultValue=false)]
        public string Country { get; set; }

        /// <summary>
        /// The phone number to be validated.
        /// </summary>
        /// <value>The phone number to be validated.</value>
        [DataMember(Name="phone_number", EmitDefaultValue=false)]
        public string PhoneNumber { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PhoneValidationRequestRecord {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Country: ").Append(Country).Append("\n");
            sb.Append("  PhoneNumber: ").Append(PhoneNumber).Append("\n");
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
            return this.Equals(input as PhoneValidationRequestRecord);
        }

        /// <summary>
        /// Returns true if PhoneValidationRequestRecord instances are equal
        /// </summary>
        /// <param name="input">Instance of PhoneValidationRequestRecord to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PhoneValidationRequestRecord input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
                (
                    this.Country == input.Country ||
                    (this.Country != null &&
                    this.Country.Equals(input.Country))
                ) && 
                (
                    this.PhoneNumber == input.PhoneNumber ||
                    (this.PhoneNumber != null &&
                    this.PhoneNumber.Equals(input.PhoneNumber))
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
                if (this.Id != null)
                    hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.Country != null)
                    hashCode = hashCode * 59 + this.Country.GetHashCode();
                if (this.PhoneNumber != null)
                    hashCode = hashCode * 59 + this.PhoneNumber.GetHashCode();
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
