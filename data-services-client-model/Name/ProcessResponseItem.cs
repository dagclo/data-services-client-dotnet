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
	/// Response item containing the results of processing.
	/// </summary>
	[DataContract]
	public partial class ProcessResponseItem : IEquatable<ProcessResponseItem>, IValidatableObject
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="ProcessResponseItem" /> class.
		/// </summary>
		/// <param name="Id">The optional identifier provided for this name on input..</param>
		/// <param name="Name">Name.</param>
		/// <param name="Outcome">Outcome.</param>
		public ProcessResponseItem(string Id = default(string), NameDetailsOut Name = default(NameDetailsOut), OutcomeDefinition Outcome = default(OutcomeDefinition))
		{
			this.Id = Id;
			this.Name = Name;
			this.Outcome = Outcome;
		}
		
		/// <summary>
		/// The optional identifier provided for this name on input.
		/// </summary>
		/// <value>The optional identifier provided for this name on input.</value>
		[DataMember(Name="id", EmitDefaultValue=false)]
		public string Id { get; set; }

		/// <summary>
		/// Gets or Sets Name
		/// </summary>
		[DataMember(Name="name", EmitDefaultValue=false)]
		public NameDetailsOut Name { get; set; }

		/// <summary>
		/// Gets or Sets Outcome
		/// </summary>
		[DataMember(Name="outcome", EmitDefaultValue=false)]
		public OutcomeDefinition Outcome { get; set; }

		/// <summary>
		/// Returns the string presentation of the object
		/// </summary>
		/// <returns>String presentation of the object</returns>
		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.Append("class ProcessResponseItem {\n");
			sb.Append("  Id: ").Append(Id).Append("\n");
			sb.Append("  Name: ").Append(Name).Append("\n");
			sb.Append("  Outcome: ").Append(Outcome).Append("\n");
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
			return this.Equals(input as ProcessResponseItem);
		}

		/// <summary>
		/// Returns true if ProcessResponseItem instances are equal
		/// </summary>
		/// <param name="input">Instance of ProcessResponseItem to be compared</param>
		/// <returns>Boolean</returns>
		public bool Equals(ProcessResponseItem input)
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
					this.Name == input.Name ||
					(this.Name != null &&
					this.Name.Equals(input.Name))
				) && 
				(
					this.Outcome == input.Outcome ||
					(this.Outcome != null &&
					this.Outcome.Equals(input.Outcome))
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
				if (this.Name != null)
					hashCode = hashCode * 59 + this.Name.GetHashCode();
				if (this.Outcome != null)
					hashCode = hashCode * 59 + this.Outcome.GetHashCode();
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
