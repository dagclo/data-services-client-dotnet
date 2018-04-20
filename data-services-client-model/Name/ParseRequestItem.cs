/* 
 * Name validation
 *
 * The Name Validation data service parses fields, structured and unstructured,  pertaining to names in your records to offer updates, standardization, and  enrichment of name data. For example, it can provide you with information  to help you analyze and standardize customer contact data. The service is a tool to validate and parse name information and structure name parts.  It can indicate that a part of a name is missing, and assign parts of an input string.  In addition, the service can help indicate that the name belongs to a person,  with given name, middle name, and family name fields, or belongs to an organization.  You can refine the results by using the country code to map the output more closely  to that country's name usage patterns. ##Key functionality: * Formats and capitalizes name parts. Indicates how you wnat to handle different name parts. * Identifies the gender of a person based on the name. * Identifies missing name parts. * Indicates whether a particular name is typically a nickname and suggest other possible nicknames.  
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

namespace Quadient.DataServices.Model.Name
{
    /// <summary>
    /// ParseRequestItem
    /// </summary>
    [DataContract]
    public partial class ParseRequestItem :  IEquatable<ParseRequestItem>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ParseRequestItem" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ParseRequestItem() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="ParseRequestItem" /> class.
        /// </summary>
        /// <param name="Id">An optional identifier used to pass through to the response..</param>
        /// <param name="UnstructuredName">The unstructured name string to parse. (required).</param>
        /// <param name="Country">An optional country code for the person, which is used to apply any regional formatting rules. The ISO 3166 2-letter country code is preferred. .</param>
        public ParseRequestItem(string Id = default(string), string UnstructuredName = default(string), string Country = default(string))
        {
            // to ensure "UnstructuredName" is required (not null)
            if (UnstructuredName == null)
            {
                throw new InvalidDataException("UnstructuredName is a required property for ParseRequestItem and cannot be null");
            }
            else
            {
                this.UnstructuredName = UnstructuredName;
            }
            this.Id = Id;
            this.Country = Country;
        }
        
        /// <summary>
        /// An optional identifier used to pass through to the response.
        /// </summary>
        /// <value>An optional identifier used to pass through to the response.</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; set; }

        /// <summary>
        /// The unstructured name string to parse.
        /// </summary>
        /// <value>The unstructured name string to parse.</value>
        [DataMember(Name="unstructured_name", EmitDefaultValue=false)]
        public string UnstructuredName { get; set; }

        /// <summary>
        /// An optional country code for the person, which is used to apply any regional formatting rules. The ISO 3166 2-letter country code is preferred. 
        /// </summary>
        /// <value>An optional country code for the person, which is used to apply any regional formatting rules. The ISO 3166 2-letter country code is preferred. </value>
        [DataMember(Name="country", EmitDefaultValue=false)]
        public string Country { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ParseRequestItem {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  UnstructuredName: ").Append(UnstructuredName).Append("\n");
            sb.Append("  Country: ").Append(Country).Append("\n");
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
            return this.Equals(input as ParseRequestItem);
        }

        /// <summary>
        /// Returns true if ParseRequestItem instances are equal
        /// </summary>
        /// <param name="input">Instance of ParseRequestItem to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ParseRequestItem input)
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
                    this.UnstructuredName == input.UnstructuredName ||
                    (this.UnstructuredName != null &&
                    this.UnstructuredName.Equals(input.UnstructuredName))
                ) && 
                (
                    this.Country == input.Country ||
                    (this.Country != null &&
                    this.Country.Equals(input.Country))
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
                if (this.UnstructuredName != null)
                    hashCode = hashCode * 59 + this.UnstructuredName.GetHashCode();
                if (this.Country != null)
                    hashCode = hashCode * 59 + this.Country.GetHashCode();
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
