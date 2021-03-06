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
	/// The user&#39;s Twitter API credentials.  To obtain Twitter APIS credentials, you have to create an app in Twitter at https://apps.twitter.com and generate access tokens.
	/// </summary>
	[DataContract]
	public partial class TwitterSearchConfigurationCredentials : IEquatable<TwitterSearchConfigurationCredentials>, IValidatableObject
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="TwitterSearchConfigurationCredentials" /> class.
		/// </summary>
		/// <param name="ConsumerKey">The consumer key for the application..</param>
		/// <param name="ConsumerSecret">The consumer secret for the application..</param>
		/// <param name="AccessToken">The access token for the Twitter account to be used..</param>
		/// <param name="AccessTokenSecret">The access token secret for the Twitter account to be used..</param>
		public TwitterSearchConfigurationCredentials(string ConsumerKey = default(string), string ConsumerSecret = default(string), string AccessToken = default(string), string AccessTokenSecret = default(string))
		{
			this.ConsumerKey = ConsumerKey;
			this.ConsumerSecret = ConsumerSecret;
			this.AccessToken = AccessToken;
			this.AccessTokenSecret = AccessTokenSecret;
		}
		
		/// <summary>
		/// The consumer key for the application.
		/// </summary>
		/// <value>The consumer key for the application.</value>
		[DataMember(Name="consumer_key", EmitDefaultValue=false)]
		public string ConsumerKey { get; set; }

		/// <summary>
		/// The consumer secret for the application.
		/// </summary>
		/// <value>The consumer secret for the application.</value>
		[DataMember(Name="consumer_secret", EmitDefaultValue=false)]
		public string ConsumerSecret { get; set; }

		/// <summary>
		/// The access token for the Twitter account to be used.
		/// </summary>
		/// <value>The access token for the Twitter account to be used.</value>
		[DataMember(Name="access_token", EmitDefaultValue=false)]
		public string AccessToken { get; set; }

		/// <summary>
		/// The access token secret for the Twitter account to be used.
		/// </summary>
		/// <value>The access token secret for the Twitter account to be used.</value>
		[DataMember(Name="access_token_secret", EmitDefaultValue=false)]
		public string AccessTokenSecret { get; set; }

		/// <summary>
		/// Returns the string presentation of the object
		/// </summary>
		/// <returns>String presentation of the object</returns>
		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.Append("class TwitterSearchConfigurationCredentials {\n");
			sb.Append("  ConsumerKey: ").Append(ConsumerKey).Append("\n");
			sb.Append("  ConsumerSecret: ").Append(ConsumerSecret).Append("\n");
			sb.Append("  AccessToken: ").Append(AccessToken).Append("\n");
			sb.Append("  AccessTokenSecret: ").Append(AccessTokenSecret).Append("\n");
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
			return this.Equals(input as TwitterSearchConfigurationCredentials);
		}

		/// <summary>
		/// Returns true if TwitterSearchConfigurationCredentials instances are equal
		/// </summary>
		/// <param name="input">Instance of TwitterSearchConfigurationCredentials to be compared</param>
		/// <returns>Boolean</returns>
		public bool Equals(TwitterSearchConfigurationCredentials input)
		{
			if (input == null)
				return false;

			return 
				(
					this.ConsumerKey == input.ConsumerKey ||
					(this.ConsumerKey != null &&
					this.ConsumerKey.Equals(input.ConsumerKey))
				) && 
				(
					this.ConsumerSecret == input.ConsumerSecret ||
					(this.ConsumerSecret != null &&
					this.ConsumerSecret.Equals(input.ConsumerSecret))
				) && 
				(
					this.AccessToken == input.AccessToken ||
					(this.AccessToken != null &&
					this.AccessToken.Equals(input.AccessToken))
				) && 
				(
					this.AccessTokenSecret == input.AccessTokenSecret ||
					(this.AccessTokenSecret != null &&
					this.AccessTokenSecret.Equals(input.AccessTokenSecret))
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
				if (this.ConsumerKey != null)
					hashCode = hashCode * 59 + this.ConsumerKey.GetHashCode();
				if (this.ConsumerSecret != null)
					hashCode = hashCode * 59 + this.ConsumerSecret.GetHashCode();
				if (this.AccessToken != null)
					hashCode = hashCode * 59 + this.AccessToken.GetHashCode();
				if (this.AccessTokenSecret != null)
					hashCode = hashCode * 59 + this.AccessTokenSecret.GetHashCode();
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
