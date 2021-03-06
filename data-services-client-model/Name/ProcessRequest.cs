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
	/// Request of the process endpoint.
	/// </summary>
	[DataContract]
	public partial class ProcessRequest : IEquatable<ProcessRequest>, IValidatableObject
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="ProcessRequest" /> class.
		/// </summary>
		[JsonConstructorAttribute]
		protected ProcessRequest() { }
		/// <summary>
		/// Initializes a new instance of the <see cref="ProcessRequest" /> class.
		/// </summary>
		/// <param name="Configuration">Configuration.</param>
		/// <param name="Records">Records (required).</param>
		public ProcessRequest(ProcessRequestConfiguration Configuration = default(ProcessRequestConfiguration), List<ProcessRequestItem> Records = default(List<ProcessRequestItem>))
		{
			// to ensure "Records" is required (not null)
			if (Records == null)
			{
				throw new InvalidDataException("Records is a required property for ProcessRequest and cannot be null");
			}
			else
			{
				this.Records = Records;
			}
			this.Configuration = Configuration;
		}
		
		/// <summary>
		/// Gets or Sets Configuration
		/// </summary>
		[DataMember(Name="configuration", EmitDefaultValue=false)]
		public ProcessRequestConfiguration Configuration { get; set; }

		/// <summary>
		/// Gets or Sets Records
		/// </summary>
		[DataMember(Name="records", EmitDefaultValue=false)]
		public List<ProcessRequestItem> Records { get; set; }

		/// <summary>
		/// Returns the string presentation of the object
		/// </summary>
		/// <returns>String presentation of the object</returns>
		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.Append("class ProcessRequest {\n");
			sb.Append("  Configuration: ").Append(Configuration).Append("\n");
			sb.Append("  Records: ").Append(Records).Append("\n");
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
			return this.Equals(input as ProcessRequest);
		}

		/// <summary>
		/// Returns true if ProcessRequest instances are equal
		/// </summary>
		/// <param name="input">Instance of ProcessRequest to be compared</param>
		/// <returns>Boolean</returns>
		public bool Equals(ProcessRequest input)
		{
			if (input == null)
				return false;

			return 
				(
					this.Configuration == input.Configuration ||
					(this.Configuration != null &&
					this.Configuration.Equals(input.Configuration))
				) && 
				(
					this.Records == input.Records ||
					this.Records != null &&
					this.Records.SequenceEqual(input.Records)
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
				if (this.Configuration != null)
					hashCode = hashCode * 59 + this.Configuration.GetHashCode();
				if (this.Records != null)
					hashCode = hashCode * 59 + this.Records.GetHashCode();
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
