/* 
 * Name validation
 *
 * The Name Validation data service parses fields, structured and unstructured,  pertaining to names in your records to offer updates, standardization, and  enrichment of name data. For example, it can provide you with information	to help you analyze and standardize customer contact data. The service is a tool to validate and parse name information and structure name parts.  It can indicate that a part of a name is missing, and assign parts of an input string.  In addition, the service can help indicate that the name belongs to a person,  with given name, middle name, and family name fields, or belongs to an organization.	You can refine the results by using the country code to map the output more closely  to that country's name usage patterns. ## Key functionality: * Formats and capitalizes name parts. Indicates how you wnat to handle different name parts. * Identifies the gender of a person based on the name. * Identifies missing name parts. * Indicates whether a particular name is typically a nickname and suggest other possible nicknames.
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
	/// NameDetailsOut
	/// </summary>
	[DataContract]
	public partial class NameDetailsOut : IEquatable<NameDetailsOut>, IValidatableObject
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="NameDetailsOut" /> class.
		/// </summary>
		/// <param name="Salutation">A greeting used in a letter or other written or non-written communication ([Read more](https://en.wikipedia.org/wiki/Salutation)). .</param>
		/// <param name="Honorific">A title that conveys esteem or respect when used in addressing or referring to a person ([Read more](https://en.wikipedia.org/wiki/Honorific)). .</param>
		/// <param name="TitleBefore">A title or function, typically professional or academic, that comes before the name parts. .</param>
		/// <param name="GivenName">One or more name parts or initials that make up what is commonly known as the \&quot;given name\&quot; or \&quot;first name\&quot; of the person. .</param>
		/// <param name="MiddleName">One or more name parts or initials that make up what is commonly known as the \&quot;middle name\&quot; of the person. .</param>
		/// <param name="FamilyName">One or more name parts or initials that make up what is commonly known as the \&quot;family name\&quot;, \&quot;last name\&quot; or \&quot;surname\&quot; of the person. .</param>
		/// <param name="GenerationTitle">A title related to a person&#39;s family or generation status. .</param>
		/// <param name="TitleAfter">A title, typically professional or academic, that comes after the name parts. .</param>
		/// <param name="Nicknames">An optional array of potential nicknames for the name parts of the person. .</param>
		/// <param name="DistinctiveTerms">An optional array (included when &#x60;enable_distinctive_terms&#x60; is true) containing terms that are considered distinctive to this name. Usually these terms represent the parts of the name that are non-generic, such as the word \&quot;Maersk\&quot; out of \&quot;Maersk Shipping A/S\&quot;. Note that there are no guarantees that any given name contains \&quot;distinctive terms\&quot;, since some names are composed of entirely \&quot;generic\&quot; terms. .</param>
		/// <param name="FamilyNamePrefix">One or more words that serve as the prefix to the first family name of the person. .</param>
		/// <param name="FamilyNameWithoutPrefix">If the family name contains prefixes, this field provides the family name without any prefixes. .</param>
		/// <param name="OrganizationName">The name of an organization, if &#x60;entity_type&#x60; was found to be an organization..</param>
		/// <param name="OrganizationType">Any legal form, entity type or structural description of the company that is embedded in the name..</param>
		/// <param name="FullName">The representation of the full name without any salutation, honorific or title elements. For &#x60;person&#x60; entities, this always equates to the concatenation of &#x60;given_name&#x60;, &#x60;middle_name&#x60;, &#x60;family_name&#x60;, and &#x60;generation_title&#x60;. The treatment of the &#x60;generation_title&#x60; element depends on the &#x60;generation_title_handling&#x60; configuration. For &#x60;organization&#x60; entities, this always equates to the concatenation of &#x60;organization_name&#x60; and &#x60;organization_type&#x60;. For &#x60;job_title&#x60; entities, this is simply the job title. .</param>
		/// <param name="Gender">The gender of the person. .</param>
		/// <param name="EntityType">The type of entity that the name was found to represent..</param>
		public NameDetailsOut(string Salutation = default(string), string Honorific = default(string), string TitleBefore = default(string), string GivenName = default(string), string MiddleName = default(string), string FamilyName = default(string), string GenerationTitle = default(string), string TitleAfter = default(string), List<NicknameItem> Nicknames = default(List<NicknameItem>), List<string> DistinctiveTerms = default(List<string>), string FamilyNamePrefix = default(string), string FamilyNameWithoutPrefix = default(string), string OrganizationName = default(string), string OrganizationType = default(string), string FullName = default(string), Gender Gender = default(Gender), EntityType EntityType = default(EntityType))
		{
			this.Salutation = Salutation;
			this.Honorific = Honorific;
			this.TitleBefore = TitleBefore;
			this.GivenName = GivenName;
			this.MiddleName = MiddleName;
			this.FamilyName = FamilyName;
			this.GenerationTitle = GenerationTitle;
			this.TitleAfter = TitleAfter;
			this.Nicknames = Nicknames;
			this.DistinctiveTerms = DistinctiveTerms;
			this.FamilyNamePrefix = FamilyNamePrefix;
			this.FamilyNameWithoutPrefix = FamilyNameWithoutPrefix;
			this.OrganizationName = OrganizationName;
			this.OrganizationType = OrganizationType;
			this.FullName = FullName;
			this.Gender = Gender;
			this.EntityType = EntityType;
		}
		
		/// <summary>
		/// A greeting used in a letter or other written or non-written communication ([Read more](https://en.wikipedia.org/wiki/Salutation)). 
		/// </summary>
		/// <value>A greeting used in a letter or other written or non-written communication ([Read more](https://en.wikipedia.org/wiki/Salutation)). </value>
		[DataMember(Name="salutation", EmitDefaultValue=false)]
		public string Salutation { get; set; }

		/// <summary>
		/// A title that conveys esteem or respect when used in addressing or referring to a person ([Read more](https://en.wikipedia.org/wiki/Honorific)). 
		/// </summary>
		/// <value>A title that conveys esteem or respect when used in addressing or referring to a person ([Read more](https://en.wikipedia.org/wiki/Honorific)). </value>
		[DataMember(Name="honorific", EmitDefaultValue=false)]
		public string Honorific { get; set; }

		/// <summary>
		/// A title or function, typically professional or academic, that comes before the name parts. 
		/// </summary>
		/// <value>A title or function, typically professional or academic, that comes before the name parts. </value>
		[DataMember(Name="title_before", EmitDefaultValue=false)]
		public string TitleBefore { get; set; }

		/// <summary>
		/// One or more name parts or initials that make up what is commonly known as the \&quot;given name\&quot; or \&quot;first name\&quot; of the person. 
		/// </summary>
		/// <value>One or more name parts or initials that make up what is commonly known as the \&quot;given name\&quot; or \&quot;first name\&quot; of the person. </value>
		[DataMember(Name="given_name", EmitDefaultValue=false)]
		public string GivenName { get; set; }

		/// <summary>
		/// One or more name parts or initials that make up what is commonly known as the \&quot;middle name\&quot; of the person. 
		/// </summary>
		/// <value>One or more name parts or initials that make up what is commonly known as the \&quot;middle name\&quot; of the person. </value>
		[DataMember(Name="middle_name", EmitDefaultValue=false)]
		public string MiddleName { get; set; }

		/// <summary>
		/// One or more name parts or initials that make up what is commonly known as the \&quot;family name\&quot;, \&quot;last name\&quot; or \&quot;surname\&quot; of the person. 
		/// </summary>
		/// <value>One or more name parts or initials that make up what is commonly known as the \&quot;family name\&quot;, \&quot;last name\&quot; or \&quot;surname\&quot; of the person. </value>
		[DataMember(Name="family_name", EmitDefaultValue=false)]
		public string FamilyName { get; set; }

		/// <summary>
		/// A title related to a person&#39;s family or generation status. 
		/// </summary>
		/// <value>A title related to a person&#39;s family or generation status. </value>
		[DataMember(Name="generation_title", EmitDefaultValue=false)]
		public string GenerationTitle { get; set; }

		/// <summary>
		/// A title, typically professional or academic, that comes after the name parts. 
		/// </summary>
		/// <value>A title, typically professional or academic, that comes after the name parts. </value>
		[DataMember(Name="title_after", EmitDefaultValue=false)]
		public string TitleAfter { get; set; }

		/// <summary>
		/// An optional array of potential nicknames for the name parts of the person. 
		/// </summary>
		/// <value>An optional array of potential nicknames for the name parts of the person. </value>
		[DataMember(Name="nicknames", EmitDefaultValue=false)]
		public List<NicknameItem> Nicknames { get; set; }

		/// <summary>
		/// An optional array (included when &#x60;enable_distinctive_terms&#x60; is true) containing terms that are considered distinctive to this name. Usually these terms represent the parts of the name that are non-generic, such as the word \&quot;Maersk\&quot; out of \&quot;Maersk Shipping A/S\&quot;. Note that there are no guarantees that any given name contains \&quot;distinctive terms\&quot;, since some names are composed of entirely \&quot;generic\&quot; terms. 
		/// </summary>
		/// <value>An optional array (included when &#x60;enable_distinctive_terms&#x60; is true) containing terms that are considered distinctive to this name. Usually these terms represent the parts of the name that are non-generic, such as the word \&quot;Maersk\&quot; out of \&quot;Maersk Shipping A/S\&quot;. Note that there are no guarantees that any given name contains \&quot;distinctive terms\&quot;, since some names are composed of entirely \&quot;generic\&quot; terms. </value>
		[DataMember(Name="distinctive_terms", EmitDefaultValue=false)]
		public List<string> DistinctiveTerms { get; set; }

		/// <summary>
		/// One or more words that serve as the prefix to the first family name of the person. 
		/// </summary>
		/// <value>One or more words that serve as the prefix to the first family name of the person. </value>
		[DataMember(Name="family_name_prefix", EmitDefaultValue=false)]
		public string FamilyNamePrefix { get; set; }

		/// <summary>
		/// If the family name contains prefixes, this field provides the family name without any prefixes. 
		/// </summary>
		/// <value>If the family name contains prefixes, this field provides the family name without any prefixes. </value>
		[DataMember(Name="family_name_without_prefix", EmitDefaultValue=false)]
		public string FamilyNameWithoutPrefix { get; set; }

		/// <summary>
		/// The name of an organization, if &#x60;entity_type&#x60; was found to be an organization.
		/// </summary>
		/// <value>The name of an organization, if &#x60;entity_type&#x60; was found to be an organization.</value>
		[DataMember(Name="organization_name", EmitDefaultValue=false)]
		public string OrganizationName { get; set; }

		/// <summary>
		/// Any legal form, entity type or structural description of the company that is embedded in the name.
		/// </summary>
		/// <value>Any legal form, entity type or structural description of the company that is embedded in the name.</value>
		[DataMember(Name="organization_type", EmitDefaultValue=false)]
		public string OrganizationType { get; set; }

		/// <summary>
		/// The representation of the full name without any salutation, honorific or title elements. For &#x60;person&#x60; entities, this always equates to the concatenation of &#x60;given_name&#x60;, &#x60;middle_name&#x60;, &#x60;family_name&#x60;, and &#x60;generation_title&#x60;. The treatment of the &#x60;generation_title&#x60; element depends on the &#x60;generation_title_handling&#x60; configuration. For &#x60;organization&#x60; entities, this always equates to the concatenation of &#x60;organization_name&#x60; and &#x60;organization_type&#x60;. For &#x60;job_title&#x60; entities, this is simply the job title. 
		/// </summary>
		/// <value>The representation of the full name without any salutation, honorific or title elements. For &#x60;person&#x60; entities, this always equates to the concatenation of &#x60;given_name&#x60;, &#x60;middle_name&#x60;, &#x60;family_name&#x60;, and &#x60;generation_title&#x60;. The treatment of the &#x60;generation_title&#x60; element depends on the &#x60;generation_title_handling&#x60; configuration. For &#x60;organization&#x60; entities, this always equates to the concatenation of &#x60;organization_name&#x60; and &#x60;organization_type&#x60;. For &#x60;job_title&#x60; entities, this is simply the job title. </value>
		[DataMember(Name="full_name", EmitDefaultValue=false)]
		public string FullName { get; set; }

		/// <summary>
		/// The gender of the person. 
		/// </summary>
		/// <value>The gender of the person. </value>
		[DataMember(Name="gender", EmitDefaultValue=false)]
		public Gender Gender { get; set; }

		/// <summary>
		/// The type of entity that the name was found to represent.
		/// </summary>
		/// <value>The type of entity that the name was found to represent.</value>
		[DataMember(Name="entity_type", EmitDefaultValue=false)]
		public EntityType EntityType { get; set; }

		/// <summary>
		/// Returns the string presentation of the object
		/// </summary>
		/// <returns>String presentation of the object</returns>
		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.Append("class NameDetailsOut {\n");
			sb.Append("  Salutation: ").Append(Salutation).Append("\n");
			sb.Append("  Honorific: ").Append(Honorific).Append("\n");
			sb.Append("  TitleBefore: ").Append(TitleBefore).Append("\n");
			sb.Append("  GivenName: ").Append(GivenName).Append("\n");
			sb.Append("  MiddleName: ").Append(MiddleName).Append("\n");
			sb.Append("  FamilyName: ").Append(FamilyName).Append("\n");
			sb.Append("  GenerationTitle: ").Append(GenerationTitle).Append("\n");
			sb.Append("  TitleAfter: ").Append(TitleAfter).Append("\n");
			sb.Append("  Nicknames: ").Append(Nicknames).Append("\n");
			sb.Append("  DistinctiveTerms: ").Append(DistinctiveTerms).Append("\n");
			sb.Append("  FamilyNamePrefix: ").Append(FamilyNamePrefix).Append("\n");
			sb.Append("  FamilyNameWithoutPrefix: ").Append(FamilyNameWithoutPrefix).Append("\n");
			sb.Append("  OrganizationName: ").Append(OrganizationName).Append("\n");
			sb.Append("  OrganizationType: ").Append(OrganizationType).Append("\n");
			sb.Append("  FullName: ").Append(FullName).Append("\n");
			sb.Append("  Gender: ").Append(Gender).Append("\n");
			sb.Append("  EntityType: ").Append(EntityType).Append("\n");
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
			return this.Equals(input as NameDetailsOut);
		}

		/// <summary>
		/// Returns true if NameDetailsOut instances are equal
		/// </summary>
		/// <param name="input">Instance of NameDetailsOut to be compared</param>
		/// <returns>Boolean</returns>
		public bool Equals(NameDetailsOut input)
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
				) && 
				(
					this.Nicknames == input.Nicknames ||
					this.Nicknames != null &&
					this.Nicknames.SequenceEqual(input.Nicknames)
				) && 
				(
					this.DistinctiveTerms == input.DistinctiveTerms ||
					this.DistinctiveTerms != null &&
					this.DistinctiveTerms.SequenceEqual(input.DistinctiveTerms)
				) && 
				(
					this.FamilyNamePrefix == input.FamilyNamePrefix ||
					(this.FamilyNamePrefix != null &&
					this.FamilyNamePrefix.Equals(input.FamilyNamePrefix))
				) && 
				(
					this.FamilyNameWithoutPrefix == input.FamilyNameWithoutPrefix ||
					(this.FamilyNameWithoutPrefix != null &&
					this.FamilyNameWithoutPrefix.Equals(input.FamilyNameWithoutPrefix))
				) && 
				(
					this.OrganizationName == input.OrganizationName ||
					(this.OrganizationName != null &&
					this.OrganizationName.Equals(input.OrganizationName))
				) && 
				(
					this.OrganizationType == input.OrganizationType ||
					(this.OrganizationType != null &&
					this.OrganizationType.Equals(input.OrganizationType))
				) && 
				(
					this.FullName == input.FullName ||
					(this.FullName != null &&
					this.FullName.Equals(input.FullName))
				) && 
				(
					this.Gender == input.Gender ||
					(this.Gender != null &&
					this.Gender.Equals(input.Gender))
				) && 
				(
					this.EntityType == input.EntityType ||
					(this.EntityType != null &&
					this.EntityType.Equals(input.EntityType))
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
				if (this.Nicknames != null)
					hashCode = hashCode * 59 + this.Nicknames.GetHashCode();
				if (this.DistinctiveTerms != null)
					hashCode = hashCode * 59 + this.DistinctiveTerms.GetHashCode();
				if (this.FamilyNamePrefix != null)
					hashCode = hashCode * 59 + this.FamilyNamePrefix.GetHashCode();
				if (this.FamilyNameWithoutPrefix != null)
					hashCode = hashCode * 59 + this.FamilyNameWithoutPrefix.GetHashCode();
				if (this.OrganizationName != null)
					hashCode = hashCode * 59 + this.OrganizationName.GetHashCode();
				if (this.OrganizationType != null)
					hashCode = hashCode * 59 + this.OrganizationType.GetHashCode();
				if (this.FullName != null)
					hashCode = hashCode * 59 + this.FullName.GetHashCode();
				if (this.Gender != null)
					hashCode = hashCode * 59 + this.Gender.GetHashCode();
				if (this.EntityType != null)
					hashCode = hashCode * 59 + this.EntityType.GetHashCode();
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
