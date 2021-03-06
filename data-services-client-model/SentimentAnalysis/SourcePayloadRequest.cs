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
	/// A collection of artifacts for sentiment analysis.
	/// </summary>
	[DataContract]
	public partial class SourcePayloadRequest : IEquatable<SourcePayloadRequest>, IValidatableObject
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="SourcePayloadRequest" /> class.
		/// </summary>
		[JsonConstructorAttribute]
		protected SourcePayloadRequest() { }
		/// <summary>
		/// Initializes a new instance of the <see cref="SourcePayloadRequest" /> class.
		/// </summary>
		/// <param name="SampleOnly">The given data is used for topic suggestion only. No other processing occurs. (default to false).</param>
		/// <param name="Artifacts">Artifacts (required).</param>
		public SourcePayloadRequest(bool? SampleOnly = false, List<SourceArtifactRequest> Artifacts = default(List<SourceArtifactRequest>))
		{
			// to ensure "Artifacts" is required (not null)
			if (Artifacts == null)
			{
				throw new InvalidDataException("Artifacts is a required property for SourcePayloadRequest and cannot be null");
			}
			else
			{
				this.Artifacts = Artifacts;
			}
			// use default value if no "SampleOnly" provided
			if (SampleOnly == null)
			{
				this.SampleOnly = false;
			}
			else
			{
				this.SampleOnly = SampleOnly;
			}
		}
		
		/// <summary>
		/// The given data is used for topic suggestion only. No other processing occurs.
		/// </summary>
		/// <value>The given data is used for topic suggestion only. No other processing occurs.</value>
		[DataMember(Name="sample_only", EmitDefaultValue=false)]
		public bool? SampleOnly { get; set; }

		/// <summary>
		/// Gets or Sets Artifacts
		/// </summary>
		[DataMember(Name="artifacts", EmitDefaultValue=false)]
		public List<SourceArtifactRequest> Artifacts { get; set; }

		/// <summary>
		/// Returns the string presentation of the object
		/// </summary>
		/// <returns>String presentation of the object</returns>
		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.Append("class SourcePayloadRequest {\n");
			sb.Append("  SampleOnly: ").Append(SampleOnly).Append("\n");
			sb.Append("  Artifacts: ").Append(Artifacts).Append("\n");
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
			return this.Equals(input as SourcePayloadRequest);
		}

		/// <summary>
		/// Returns true if SourcePayloadRequest instances are equal
		/// </summary>
		/// <param name="input">Instance of SourcePayloadRequest to be compared</param>
		/// <returns>Boolean</returns>
		public bool Equals(SourcePayloadRequest input)
		{
			if (input == null)
				return false;

			return 
				(
					this.SampleOnly == input.SampleOnly ||
					(this.SampleOnly != null &&
					this.SampleOnly.Equals(input.SampleOnly))
				) && 
				(
					this.Artifacts == input.Artifacts ||
					this.Artifacts != null &&
					this.Artifacts.SequenceEqual(input.Artifacts)
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
				if (this.SampleOnly != null)
					hashCode = hashCode * 59 + this.SampleOnly.GetHashCode();
				if (this.Artifacts != null)
					hashCode = hashCode * 59 + this.Artifacts.GetHashCode();
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
