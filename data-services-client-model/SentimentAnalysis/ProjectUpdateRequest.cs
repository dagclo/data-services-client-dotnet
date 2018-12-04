/* 
 * Sentiment Analysis
 *
 * The Sentiment Analysis service offers insight into what customers are saying and feeling about your brand or product. Taking advantage of machine learning, the service can help you monitor customer perception and help influence the direction of your marketing and customer experience operations.	The service can analyze data from a variety of data sources, including Twitter and text contained in .csv files, say from customer support survey responses, and presents multiple visualizations of the results. You can review trends over time, easily learn what's hot and what's not based on the content of your data, and if you tap into the data in your Twitter feed, get a list of the topics that are the hottest and the messages that are the most intense.  Key functionality: * Steps you through setup with an easy to understand wizard. * Tracks sentiment per day/hour per topic. * Captures the most intense messages in periods ranging from seven to 30 days. * Provides sentiment visualizations that capture what topics your customers are discussing. 
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

namespace Quadient.DataServices.Model.SentimentAnalysis
{
	/// <summary>
	/// ProjectUpdateRequest
	/// </summary>
	[DataContract]
	public partial class ProjectUpdateRequest : IEquatable<ProjectUpdateRequest>, IValidatableObject
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="ProjectUpdateRequest" /> class.
		/// </summary>
		/// <param name="Name">Descriptive name for the project..</param>
		/// <param name="Description">The purpose or scope of the project..</param>
		public ProjectUpdateRequest(string Name = default(string), string Description = default(string))
		{
			this.Name = Name;
			this.Description = Description;
		}
		
		/// <summary>
		/// Descriptive name for the project.
		/// </summary>
		/// <value>Descriptive name for the project.</value>
		[DataMember(Name="name", EmitDefaultValue=false)]
		public string Name { get; set; }

		/// <summary>
		/// The purpose or scope of the project.
		/// </summary>
		/// <value>The purpose or scope of the project.</value>
		[DataMember(Name="description", EmitDefaultValue=false)]
		public string Description { get; set; }

		/// <summary>
		/// Returns the string presentation of the object
		/// </summary>
		/// <returns>String presentation of the object</returns>
		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.Append("class ProjectUpdateRequest {\n");
			sb.Append("  Name: ").Append(Name).Append("\n");
			sb.Append("  Description: ").Append(Description).Append("\n");
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
			return this.Equals(input as ProjectUpdateRequest);
		}

		/// <summary>
		/// Returns true if ProjectUpdateRequest instances are equal
		/// </summary>
		/// <param name="input">Instance of ProjectUpdateRequest to be compared</param>
		/// <returns>Boolean</returns>
		public bool Equals(ProjectUpdateRequest input)
		{
			if (input == null)
				return false;

			return 
				(
					this.Name == input.Name ||
					(this.Name != null &&
					this.Name.Equals(input.Name))
				) && 
				(
					this.Description == input.Description ||
					(this.Description != null &&
					this.Description.Equals(input.Description))
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
				if (this.Name != null)
					hashCode = hashCode * 59 + this.Name.GetHashCode();
				if (this.Description != null)
					hashCode = hashCode * 59 + this.Description.GetHashCode();
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
