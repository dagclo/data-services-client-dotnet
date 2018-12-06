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
	/// TwitterSearchConfiguration
	/// </summary>
	[DataContract]
	public partial class TwitterSearchConfiguration : IEquatable<TwitterSearchConfiguration>, IValidatableObject
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="TwitterSearchConfiguration" /> class.
		/// </summary>
		[JsonConstructorAttribute]
		protected TwitterSearchConfiguration() { }
		/// <summary>
		/// Initializes a new instance of the <see cref="TwitterSearchConfiguration" /> class.
		/// </summary>
		/// <param name="Credentials">Credentials (required).</param>
		/// <param name="Filters">Filters.</param>
		public TwitterSearchConfiguration(TwitterSearchConfigurationCredentials Credentials = default(TwitterSearchConfigurationCredentials), TwitterSearchConfigurationFilters Filters = default(TwitterSearchConfigurationFilters))
		{
			// to ensure "Credentials" is required (not null)
			if (Credentials == null)
			{
				throw new InvalidDataException("Credentials is a required property for TwitterSearchConfiguration and cannot be null");
			}
			else
			{
				this.Credentials = Credentials;
			}
			this.Filters = Filters;
		}
		
		/// <summary>
		/// Gets or Sets Credentials
		/// </summary>
		[DataMember(Name="credentials", EmitDefaultValue=false)]
		public TwitterSearchConfigurationCredentials Credentials { get; set; }

		/// <summary>
		/// Gets or Sets Filters
		/// </summary>
		[DataMember(Name="filters", EmitDefaultValue=false)]
		public TwitterSearchConfigurationFilters Filters { get; set; }

		/// <summary>
		/// Returns the string presentation of the object
		/// </summary>
		/// <returns>String presentation of the object</returns>
		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.Append("class TwitterSearchConfiguration {\n");
			sb.Append("  Credentials: ").Append(Credentials).Append("\n");
			sb.Append("  Filters: ").Append(Filters).Append("\n");
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
			return this.Equals(input as TwitterSearchConfiguration);
		}

		/// <summary>
		/// Returns true if TwitterSearchConfiguration instances are equal
		/// </summary>
		/// <param name="input">Instance of TwitterSearchConfiguration to be compared</param>
		/// <returns>Boolean</returns>
		public bool Equals(TwitterSearchConfiguration input)
		{
			if (input == null)
				return false;

			return 
				(
					this.Credentials == input.Credentials ||
					(this.Credentials != null &&
					this.Credentials.Equals(input.Credentials))
				) && 
				(
					this.Filters == input.Filters ||
					(this.Filters != null &&
					this.Filters.Equals(input.Filters))
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
				if (this.Credentials != null)
					hashCode = hashCode * 59 + this.Credentials.GetHashCode();
				if (this.Filters != null)
					hashCode = hashCode * 59 + this.Filters.GetHashCode();
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
