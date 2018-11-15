/* 
 * Sentiment Analysis
 *
 * The Sentiment Analysis service offers insight into what customers are saying and feeling about your brand or product. Taking advantage of machine learning, the service can help you monitor customer perception and help influence the direction of your marketing and customer experience operations.  The service can analyze data from a variety of data sources, including Twitter and text contained in .csv files, say from customer support survey responses, and presents multiple visualizations of the results. You can review trends over time, easily learn what's hot and what's not based on the content of your data, and if you tap into the data in your Twitter feed, get a list of the topics that are the hottest and the messages that are the most intense.  Key functionality: * Steps you through setup with an easy to understand wizard. * Tracks sentiment per day/hour per topic. * Captures the most intense messages in periods ranging from seven to 30 days. * Provides sentiment visualizations that capture what topics your customers are discussing. 
 *
 * OpenAPI spec version: 0.3.19
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
    /// SourceArtifactRequest
    /// </summary>
    [DataContract]
    public partial class SourceArtifactRequest : IEquatable<SourceArtifactRequest>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SourceArtifactRequest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected SourceArtifactRequest() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="SourceArtifactRequest" /> class.
        /// </summary>
        /// <param name="Id">User-supplied identifier..</param>
        /// <param name="Author">The author of the artifact..</param>
        /// <param name="Text">The text that will be analyzed. (required).</param>
        /// <param name="Language">ISO 639-1 two-character language code..</param>
        /// <param name="Date">Date and time the source was created..</param>
        public SourceArtifactRequest(string Id = default(string), string Author = default(string), string Text = default(string), string Language = default(string), DateTime? Date = default(DateTime?))
        {
            // to ensure "Text" is required (not null)
            if (Text == null)
            {
                throw new InvalidDataException("Text is a required property for SourceArtifactRequest and cannot be null");
            }
            else
            {
                this.Text = Text;
            }
            this.Id = Id;
            this.Author = Author;
            this.Language = Language;
            this.Date = Date;
        }
        
        /// <summary>
        /// User-supplied identifier.
        /// </summary>
        /// <value>User-supplied identifier.</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; set; }

        /// <summary>
        /// The author of the artifact.
        /// </summary>
        /// <value>The author of the artifact.</value>
        [DataMember(Name="author", EmitDefaultValue=false)]
        public string Author { get; set; }

        /// <summary>
        /// The text that will be analyzed.
        /// </summary>
        /// <value>The text that will be analyzed.</value>
        [DataMember(Name="text", EmitDefaultValue=false)]
        public string Text { get; set; }

        /// <summary>
        /// ISO 639-1 two-character language code.
        /// </summary>
        /// <value>ISO 639-1 two-character language code.</value>
        [DataMember(Name="language", EmitDefaultValue=false)]
        public string Language { get; set; }

        /// <summary>
        /// Date and time the source was created.
        /// </summary>
        /// <value>Date and time the source was created.</value>
        [DataMember(Name="date", EmitDefaultValue=false)]
        public DateTime? Date { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SourceArtifactRequest {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Author: ").Append(Author).Append("\n");
            sb.Append("  Text: ").Append(Text).Append("\n");
            sb.Append("  Language: ").Append(Language).Append("\n");
            sb.Append("  Date: ").Append(Date).Append("\n");
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
            return this.Equals(input as SourceArtifactRequest);
        }

        /// <summary>
        /// Returns true if SourceArtifactRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of SourceArtifactRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SourceArtifactRequest input)
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
                    this.Author == input.Author ||
                    (this.Author != null &&
                    this.Author.Equals(input.Author))
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
                    this.Date == input.Date ||
                    (this.Date != null &&
                    this.Date.Equals(input.Date))
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
                if (this.Author != null)
                    hashCode = hashCode * 59 + this.Author.GetHashCode();
                if (this.Text != null)
                    hashCode = hashCode * 59 + this.Text.GetHashCode();
                if (this.Language != null)
                    hashCode = hashCode * 59 + this.Language.GetHashCode();
                if (this.Date != null)
                    hashCode = hashCode * 59 + this.Date.GetHashCode();
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
            // Language (string) maxLength
            if(this.Language != null && this.Language.Length > 0)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Language, length must be less than 0.", new [] { "Language" });
            }

            // Language (string) minLength
            if(this.Language != null && this.Language.Length < 0)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Language, length must be greater than 0.", new [] { "Language" });
            }

            yield break;
        }
    }

}
