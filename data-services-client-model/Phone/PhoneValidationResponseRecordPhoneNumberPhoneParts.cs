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
    /// PhoneValidationResponseRecordPhoneNumberPhoneParts
    /// </summary>
    [DataContract]
    public partial class PhoneValidationResponseRecordPhoneNumberPhoneParts : IEquatable<PhoneValidationResponseRecordPhoneNumberPhoneParts>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PhoneValidationResponseRecordPhoneNumberPhoneParts" /> class.
        /// </summary>
        /// <param name="CountryCallingCode">CountryCallingCode.</param>
        /// <param name="NationalNumber">NationalNumber.</param>
        /// <param name="Extension">Extension.</param>
        public PhoneValidationResponseRecordPhoneNumberPhoneParts(int? CountryCallingCode = default(int?), long? NationalNumber = default(long?), string Extension = default(string))
        {
            this.CountryCallingCode = CountryCallingCode;
            this.NationalNumber = NationalNumber;
            this.Extension = Extension;
        }
        
        /// <summary>
        /// Gets or Sets CountryCallingCode
        /// </summary>
        [DataMember(Name="country_calling_code", EmitDefaultValue=false)]
        public int? CountryCallingCode { get; set; }

        /// <summary>
        /// Gets or Sets NationalNumber
        /// </summary>
        [DataMember(Name="national_number", EmitDefaultValue=false)]
        public long? NationalNumber { get; set; }

        /// <summary>
        /// Gets or Sets Extension
        /// </summary>
        [DataMember(Name="extension", EmitDefaultValue=false)]
        public string Extension { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PhoneValidationResponseRecordPhoneNumberPhoneParts {\n");
            sb.Append("  CountryCallingCode: ").Append(CountryCallingCode).Append("\n");
            sb.Append("  NationalNumber: ").Append(NationalNumber).Append("\n");
            sb.Append("  Extension: ").Append(Extension).Append("\n");
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
            return this.Equals(input as PhoneValidationResponseRecordPhoneNumberPhoneParts);
        }

        /// <summary>
        /// Returns true if PhoneValidationResponseRecordPhoneNumberPhoneParts instances are equal
        /// </summary>
        /// <param name="input">Instance of PhoneValidationResponseRecordPhoneNumberPhoneParts to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PhoneValidationResponseRecordPhoneNumberPhoneParts input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.CountryCallingCode == input.CountryCallingCode ||
                    (this.CountryCallingCode != null &&
                    this.CountryCallingCode.Equals(input.CountryCallingCode))
                ) && 
                (
                    this.NationalNumber == input.NationalNumber ||
                    (this.NationalNumber != null &&
                    this.NationalNumber.Equals(input.NationalNumber))
                ) && 
                (
                    this.Extension == input.Extension ||
                    (this.Extension != null &&
                    this.Extension.Equals(input.Extension))
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
                if (this.CountryCallingCode != null)
                    hashCode = hashCode * 59 + this.CountryCallingCode.GetHashCode();
                if (this.NationalNumber != null)
                    hashCode = hashCode * 59 + this.NationalNumber.GetHashCode();
                if (this.Extension != null)
                    hashCode = hashCode * 59 + this.Extension.GetHashCode();
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
