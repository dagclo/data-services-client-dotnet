/* 
 * Address Correction
 *
 * The Address Correction data service validates and corrects postal addresses from around the world.  The service is currently available for the following countries: United States, United Kingdom, and Canada. Address correction standardizes address spellings, abbreviations, and formats, adds additional delivery information, such as geocodes, and verifies the deliverability of each address.  It improves your delivery success odds by correcting incorrect information, such as postal codes and typos in street names, and verifying delivery target names.  Key functionality: * Corrects the spelling of street names and cities. * Standardizes address formats and abbreviations, based on country ID. * Enriches output with deliverability information for an address, such as USPS DPV® confirmation and geocoding coordinates. * Provides easy-to-understand correction status, codes, and messages.
 *
 * OpenAPI spec version: 1.0.22
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

namespace Quadient.DataServices.Model.Address
{
    /// <summary>
    /// Defines an additional output group of fields for move_update processing, enabled using the &#x60;output_groups&#x60; configuration setting.
    /// </summary>
    [DataContract]
    public partial class CorrectionResponseRecordMoveUpdate : IEquatable<CorrectionResponseRecordMoveUpdate>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CorrectionResponseRecordMoveUpdate" /> class.
        /// </summary>
        /// <param name="AddressCookie">An identifier that can be passed in with the corresponding record when running a move_update job in place of the record&#39;s address details..</param>
        public CorrectionResponseRecordMoveUpdate(string AddressCookie = default(string))
        {
            this.AddressCookie = AddressCookie;
        }
        
        /// <summary>
        /// An identifier that can be passed in with the corresponding record when running a move_update job in place of the record&#39;s address details.
        /// </summary>
        /// <value>An identifier that can be passed in with the corresponding record when running a move_update job in place of the record&#39;s address details.</value>
        [DataMember(Name="address_cookie", EmitDefaultValue=false)]
        public string AddressCookie { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CorrectionResponseRecordMoveUpdate {\n");
            sb.Append("  AddressCookie: ").Append(AddressCookie).Append("\n");
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
            return this.Equals(input as CorrectionResponseRecordMoveUpdate);
        }

        /// <summary>
        /// Returns true if CorrectionResponseRecordMoveUpdate instances are equal
        /// </summary>
        /// <param name="input">Instance of CorrectionResponseRecordMoveUpdate to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CorrectionResponseRecordMoveUpdate input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.AddressCookie == input.AddressCookie ||
                    (this.AddressCookie != null &&
                    this.AddressCookie.Equals(input.AddressCookie))
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
                if (this.AddressCookie != null)
                    hashCode = hashCode * 59 + this.AddressCookie.GetHashCode();
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
