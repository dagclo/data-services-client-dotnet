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
	/// ProjectsSummaryResponse
	/// </summary>
	[DataContract]
	public partial class ProjectsSummaryResponse : IEquatable<ProjectsSummaryResponse>, IValidatableObject
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="ProjectsSummaryResponse" /> class.
		/// </summary>
		/// <param name="Total">The total number of projects found..</param>
		/// <param name="Limit">The number of projects requested..</param>
		/// <param name="Projects">Projects.</param>
		public ProjectsSummaryResponse(int? Total = default(int?), int? Limit = default(int?), List<ProjectSummaryResponse> Projects = default(List<ProjectSummaryResponse>))
		{
			this.Total = Total;
			this.Limit = Limit;
			this.Projects = Projects;
		}
		
		/// <summary>
		/// The total number of projects found.
		/// </summary>
		/// <value>The total number of projects found.</value>
		[DataMember(Name="total", EmitDefaultValue=false)]
		public int? Total { get; set; }

		/// <summary>
		/// The number of projects requested.
		/// </summary>
		/// <value>The number of projects requested.</value>
		[DataMember(Name="limit", EmitDefaultValue=false)]
		public int? Limit { get; set; }

		/// <summary>
		/// Gets or Sets Projects
		/// </summary>
		[DataMember(Name="projects", EmitDefaultValue=false)]
		public List<ProjectSummaryResponse> Projects { get; set; }

		/// <summary>
		/// Returns the string presentation of the object
		/// </summary>
		/// <returns>String presentation of the object</returns>
		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.Append("class ProjectsSummaryResponse {\n");
			sb.Append("  Total: ").Append(Total).Append("\n");
			sb.Append("  Limit: ").Append(Limit).Append("\n");
			sb.Append("  Projects: ").Append(Projects).Append("\n");
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
			return this.Equals(input as ProjectsSummaryResponse);
		}

		/// <summary>
		/// Returns true if ProjectsSummaryResponse instances are equal
		/// </summary>
		/// <param name="input">Instance of ProjectsSummaryResponse to be compared</param>
		/// <returns>Boolean</returns>
		public bool Equals(ProjectsSummaryResponse input)
		{
			if (input == null)
				return false;

			return 
				(
					this.Total == input.Total ||
					(this.Total != null &&
					this.Total.Equals(input.Total))
				) && 
				(
					this.Limit == input.Limit ||
					(this.Limit != null &&
					this.Limit.Equals(input.Limit))
				) && 
				(
					this.Projects == input.Projects ||
					this.Projects != null &&
					this.Projects.SequenceEqual(input.Projects)
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
				if (this.Total != null)
					hashCode = hashCode * 59 + this.Total.GetHashCode();
				if (this.Limit != null)
					hashCode = hashCode * 59 + this.Limit.GetHashCode();
				if (this.Projects != null)
					hashCode = hashCode * 59 + this.Projects.GetHashCode();
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
