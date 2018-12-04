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
	/// TransactionalArtifactResponse
	/// </summary>
	[DataContract]
	public partial class TransactionalArtifactResponse : IEquatable<TransactionalArtifactResponse>, IValidatableObject
	{
		/// <summary>
		/// Defines Sentiment
		/// </summary>
		[JsonConverter(typeof(StringEnumConverter))]
		public enum SentimentEnum
		{
			
			/// <summary>
			/// Enum Positive for value: Positive
			/// </summary>
			[EnumMember(Value = "Positive")]
			Positive = 1,
			
			/// <summary>
			/// Enum Neutral for value: Neutral
			/// </summary>
			[EnumMember(Value = "Neutral")]
			Neutral = 2,
			
			/// <summary>
			/// Enum Negative for value: Negative
			/// </summary>
			[EnumMember(Value = "Negative")]
			Negative = 3
		}

		/// <summary>
		/// Gets or Sets Sentiment
		/// </summary>
		[DataMember(Name="sentiment", EmitDefaultValue=false)]
		public SentimentEnum? Sentiment { get; set; }
		/// <summary>
		/// Initializes a new instance of the <see cref="TransactionalArtifactResponse" /> class.
		/// </summary>
		[JsonConstructorAttribute]
		protected TransactionalArtifactResponse() { }
		/// <summary>
		/// Initializes a new instance of the <see cref="TransactionalArtifactResponse" /> class.
		/// </summary>
		/// <param name="Id">User-supplied identifier. (required).</param>
		/// <param name="Text">The text that was analyzed..</param>
		/// <param name="Language">ISO 639-1 two-character language code..</param>
		/// <param name="Score">The sentiment score that was returned from an analysis of the text..</param>
		/// <param name="Sentiment">Sentiment.</param>
		/// <param name="SuggestedTopics">Key words or phrases from the text as identified by the sentiment analysis engine..</param>
		/// <param name="Outcome">Outcome.</param>
		public TransactionalArtifactResponse(string Id = default(string), string Text = default(string), string Language = default(string), decimal? Score = default(decimal?), SentimentEnum? Sentiment = default(SentimentEnum?), List<string> SuggestedTopics = default(List<string>), TransactionalArtifactOutcome Outcome = default(TransactionalArtifactOutcome))
		{
			// to ensure "Id" is required (not null)
			if (Id == null)
			{
				throw new InvalidDataException("Id is a required property for TransactionalArtifactResponse and cannot be null");
			}
			else
			{
				this.Id = Id;
			}
			this.Text = Text;
			this.Language = Language;
			this.Score = Score;
			this.Sentiment = Sentiment;
			this.SuggestedTopics = SuggestedTopics;
			this.Outcome = Outcome;
		}
		
		/// <summary>
		/// User-supplied identifier.
		/// </summary>
		/// <value>User-supplied identifier.</value>
		[DataMember(Name="id", EmitDefaultValue=false)]
		public string Id { get; set; }

		/// <summary>
		/// The text that was analyzed.
		/// </summary>
		/// <value>The text that was analyzed.</value>
		[DataMember(Name="text", EmitDefaultValue=false)]
		public string Text { get; set; }

		/// <summary>
		/// ISO 639-1 two-character language code.
		/// </summary>
		/// <value>ISO 639-1 two-character language code.</value>
		[DataMember(Name="language", EmitDefaultValue=false)]
		public string Language { get; set; }

		/// <summary>
		/// The sentiment score that was returned from an analysis of the text.
		/// </summary>
		/// <value>The sentiment score that was returned from an analysis of the text.</value>
		[DataMember(Name="score", EmitDefaultValue=false)]
		public decimal? Score { get; set; }


		/// <summary>
		/// Key words or phrases from the text as identified by the sentiment analysis engine.
		/// </summary>
		/// <value>Key words or phrases from the text as identified by the sentiment analysis engine.</value>
		[DataMember(Name="suggested_topics", EmitDefaultValue=false)]
		public List<string> SuggestedTopics { get; set; }

		/// <summary>
		/// Gets or Sets Outcome
		/// </summary>
		[DataMember(Name="outcome", EmitDefaultValue=false)]
		public TransactionalArtifactOutcome Outcome { get; set; }

		/// <summary>
		/// Returns the string presentation of the object
		/// </summary>
		/// <returns>String presentation of the object</returns>
		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.Append("class TransactionalArtifactResponse {\n");
			sb.Append("  Id: ").Append(Id).Append("\n");
			sb.Append("  Text: ").Append(Text).Append("\n");
			sb.Append("  Language: ").Append(Language).Append("\n");
			sb.Append("  Score: ").Append(Score).Append("\n");
			sb.Append("  Sentiment: ").Append(Sentiment).Append("\n");
			sb.Append("  SuggestedTopics: ").Append(SuggestedTopics).Append("\n");
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
			return this.Equals(input as TransactionalArtifactResponse);
		}

		/// <summary>
		/// Returns true if TransactionalArtifactResponse instances are equal
		/// </summary>
		/// <param name="input">Instance of TransactionalArtifactResponse to be compared</param>
		/// <returns>Boolean</returns>
		public bool Equals(TransactionalArtifactResponse input)
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
					this.Text == input.Text ||
					(this.Text != null &&
					this.Text.Equals(input.Text))
				) && 
				(
					this.Language == input.Language ||
					(this.Language != null &&
					this.Language.Equals(input.Language))
				) && 
				(
					this.Score == input.Score ||
					(this.Score != null &&
					this.Score.Equals(input.Score))
				) && 
				(
					this.Sentiment == input.Sentiment ||
					(this.Sentiment != null &&
					this.Sentiment.Equals(input.Sentiment))
				) && 
				(
					this.SuggestedTopics == input.SuggestedTopics ||
					this.SuggestedTopics != null &&
					this.SuggestedTopics.SequenceEqual(input.SuggestedTopics)
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
				if (this.Text != null)
					hashCode = hashCode * 59 + this.Text.GetHashCode();
				if (this.Language != null)
					hashCode = hashCode * 59 + this.Language.GetHashCode();
				if (this.Score != null)
					hashCode = hashCode * 59 + this.Score.GetHashCode();
				if (this.Sentiment != null)
					hashCode = hashCode * 59 + this.Sentiment.GetHashCode();
				if (this.SuggestedTopics != null)
					hashCode = hashCode * 59 + this.SuggestedTopics.GetHashCode();
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
