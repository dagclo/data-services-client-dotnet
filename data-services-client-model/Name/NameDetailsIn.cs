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
    /// NameDetailsIn
    /// </summary>
    [DataContract]
    public partial class NameDetailsIn :  IEquatable<NameDetailsIn>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="NameDetailsIn" /> class.
        /// </summary>
        /// <param name="Salutation">A greeting used in a letter or other written or non-written communication ([Read more](https://en.wikipedia.org/wiki/Salutation)). .</param>
        /// <param name="Honorific">A title that conveys esteem or respect when used in addressing or referring to a person ([Read more](https://en.wikipedia.org/wiki/Honorific)). This field only applies when &#x60;entity_type&#x60; is &#x60;person&#x60;. .</param>
        /// <param name="TitleBefore">A title or function, typically professional or academic, that comes before the name parts. This field only applies when &#x60;entity_type&#x60; is &#x60;person&#x60;. .</param>
        /// <param name="GivenName">One or more name parts or initials that make up what is commonly known as the \&quot;given name\&quot; or \&quot;first name\&quot; of the person. This field only applies when &#x60;entity_type&#x60; is &#x60;person&#x60;. .</param>
        /// <param name="MiddleName">One or more name parts or initials that make up what is commonly known as the \&quot;middle name\&quot; of the person. This field only applies when &#x60;entity_type&#x60; is &#x60;person&#x60;. .</param>
        /// <param name="FamilyName">One or more name parts or initials that make up what is commonly known as the \&quot;family name\&quot;, \&quot;last name\&quot; or \&quot;surname\&quot; of the person. This field only applies when &#x60;entity_type&#x60; is &#x60;person&#x60;. .</param>
        /// <param name="GenerationTitle">A title related to a person&#39;s family or generation status. This field only applies when &#x60;entity_type&#x60; is &#x60;person&#x60;. .</param>
        /// <param name="TitleAfter">A title, typically professional or academic, that comes after the name parts. This field only applies when &#x60;entity_type&#x60; is &#x60;person&#x60;. .</param>
        public NameDetailsIn(string Salutation = default(string), string Honorific = default(string), string TitleBefore = default(string), string GivenName = default(string), string MiddleName = default(string), string FamilyName = default(string), string GenerationTitle = default(string), string TitleAfter = default(string))
        {
            this.Salutation = Salutation;
            this.Honorific = Honorific;
            this.TitleBefore = TitleBefore;
            this.GivenName = GivenName;
            this.MiddleName = MiddleName;
            this.FamilyName = FamilyName;
            this.GenerationTitle = GenerationTitle;
            this.TitleAfter = TitleAfter;
        }
        
        /// <summary>
        /// A greeting used in a letter or other written or non-written communication ([Read more](https://en.wikipedia.org/wiki/Salutation)). 
        /// </summary>
        /// <value>A greeting used in a letter or other written or non-written communication ([Read more](https://en.wikipedia.org/wiki/Salutation)). </value>
        [DataMember(Name="salutation", EmitDefaultValue=false)]
        public string Salutation { get; set; }

        /// <summary>
        /// A title that conveys esteem or respect when used in addressing or referring to a person ([Read more](https://en.wikipedia.org/wiki/Honorific)). This field only applies when &#x60;entity_type&#x60; is &#x60;person&#x60;. 
        /// </summary>
        /// <value>A title that conveys esteem or respect when used in addressing or referring to a person ([Read more](https://en.wikipedia.org/wiki/Honorific)). This field only applies when &#x60;entity_type&#x60; is &#x60;person&#x60;. </value>
        [DataMember(Name="honorific", EmitDefaultValue=false)]
        public string Honorific { get; set; }

        /// <summary>
        /// A title or function, typically professional or academic, that comes before the name parts. This field only applies when &#x60;entity_type&#x60; is &#x60;person&#x60;. 
        /// </summary>
        /// <value>A title or function, typically professional or academic, that comes before the name parts. This field only applies when &#x60;entity_type&#x60; is &#x60;person&#x60;. </value>
        [DataMember(Name="title_before", EmitDefaultValue=false)]
        public string TitleBefore { get; set; }

        /// <summary>
        /// One or more name parts or initials that make up what is commonly known as the \&quot;given name\&quot; or \&quot;first name\&quot; of the person. This field only applies when &#x60;entity_type&#x60; is &#x60;person&#x60;. 
        /// </summary>
        /// <value>One or more name parts or initials that make up what is commonly known as the \&quot;given name\&quot; or \&quot;first name\&quot; of the person. This field only applies when &#x60;entity_type&#x60; is &#x60;person&#x60;. </value>
        [DataMember(Name="given_name", EmitDefaultValue=false)]
        public string GivenName { get; set; }

        /// <summary>
        /// One or more name parts or initials that make up what is commonly known as the \&quot;middle name\&quot; of the person. This field only applies when &#x60;entity_type&#x60; is &#x60;person&#x60;. 
        /// </summary>
        /// <value>One or more name parts or initials that make up what is commonly known as the \&quot;middle name\&quot; of the person. This field only applies when &#x60;entity_type&#x60; is &#x60;person&#x60;. </value>
        [DataMember(Name="middle_name", EmitDefaultValue=false)]
        public string MiddleName { get; set; }

        /// <summary>
        /// One or more name parts or initials that make up what is commonly known as the \&quot;family name\&quot;, \&quot;last name\&quot; or \&quot;surname\&quot; of the person. This field only applies when &#x60;entity_type&#x60; is &#x60;person&#x60;. 
        /// </summary>
        /// <value>One or more name parts or initials that make up what is commonly known as the \&quot;family name\&quot;, \&quot;last name\&quot; or \&quot;surname\&quot; of the person. This field only applies when &#x60;entity_type&#x60; is &#x60;person&#x60;. </value>
        [DataMember(Name="family_name", EmitDefaultValue=false)]
        public string FamilyName { get; set; }

        /// <summary>
        /// A title related to a person&#39;s family or generation status. This field only applies when &#x60;entity_type&#x60; is &#x60;person&#x60;. 
        /// </summary>
        /// <value>A title related to a person&#39;s family or generation status. This field only applies when &#x60;entity_type&#x60; is &#x60;person&#x60;. </value>
        [DataMember(Name="generation_title", EmitDefaultValue=false)]
        public string GenerationTitle { get; set; }

        /// <summary>
        /// A title, typically professional or academic, that comes after the name parts. This field only applies when &#x60;entity_type&#x60; is &#x60;person&#x60;. 
        /// </summary>
        /// <value>A title, typically professional or academic, that comes after the name parts. This field only applies when &#x60;entity_type&#x60; is &#x60;person&#x60;. </value>
        [DataMember(Name="title_after", EmitDefaultValue=false)]
        public string TitleAfter { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class NameDetailsIn {\n");
            sb.Append("  Salutation: ").Append(Salutation).Append("\n");
            sb.Append("  Honorific: ").Append(Honorific).Append("\n");
            sb.Append("  TitleBefore: ").Append(TitleBefore).Append("\n");
            sb.Append("  GivenName: ").Append(GivenName).Append("\n");
            sb.Append("  MiddleName: ").Append(MiddleName).Append("\n");
            sb.Append("  FamilyName: ").Append(FamilyName).Append("\n");
            sb.Append("  GenerationTitle: ").Append(GenerationTitle).Append("\n");
            sb.Append("  TitleAfter: ").Append(TitleAfter).Append("\n");
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
            return this.Equals(input as NameDetailsIn);
        }

        /// <summary>
        /// Returns true if NameDetailsIn instances are equal
        /// </summary>
        /// <param name="input">Instance of NameDetailsIn to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(NameDetailsIn input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Salutation == input.Salutation ||
                    (this.Salutation != null &&
                    this.Salutation.Equals(input.Salutation))
                ) && 
                (
                    this.Honorific == input.Honorific ||
                    (this.Honorific != null &&
                    this.Honorific.Equals(input.Honorific))
                ) && 
                (
                    this.TitleBefore == input.TitleBefore ||
                    (this.TitleBefore != null &&
                    this.TitleBefore.Equals(input.TitleBefore))
                ) && 
                (
                    this.GivenName == input.GivenName ||
                    (this.GivenName != null &&
                    this.GivenName.Equals(input.GivenName))
                ) && 
                (
                    this.MiddleName == input.MiddleName ||
                    (this.MiddleName != null &&
                    this.MiddleName.Equals(input.MiddleName))
                ) && 
                (
                    this.FamilyName == input.FamilyName ||
                    (this.FamilyName != null &&
                    this.FamilyName.Equals(input.FamilyName))
                ) && 
                (
                    this.GenerationTitle == input.GenerationTitle ||
                    (this.GenerationTitle != null &&
                    this.GenerationTitle.Equals(input.GenerationTitle))
                ) && 
                (
                    this.TitleAfter == input.TitleAfter ||
                    (this.TitleAfter != null &&
                    this.TitleAfter.Equals(input.TitleAfter))
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
                if (this.Salutation != null)
                    hashCode = hashCode * 59 + this.Salutation.GetHashCode();
                if (this.Honorific != null)
                    hashCode = hashCode * 59 + this.Honorific.GetHashCode();
                if (this.TitleBefore != null)
                    hashCode = hashCode * 59 + this.TitleBefore.GetHashCode();
                if (this.GivenName != null)
                    hashCode = hashCode * 59 + this.GivenName.GetHashCode();
                if (this.MiddleName != null)
                    hashCode = hashCode * 59 + this.MiddleName.GetHashCode();
                if (this.FamilyName != null)
                    hashCode = hashCode * 59 + this.FamilyName.GetHashCode();
                if (this.GenerationTitle != null)
                    hashCode = hashCode * 59 + this.GenerationTitle.GetHashCode();
                if (this.TitleAfter != null)
                    hashCode = hashCode * 59 + this.TitleAfter.GetHashCode();
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
