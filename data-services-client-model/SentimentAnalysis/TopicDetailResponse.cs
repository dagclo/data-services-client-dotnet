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
    /// Details about a topic.
    /// </summary>
    [DataContract]
    public partial class TopicDetailResponse : IEquatable<TopicDetailResponse>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TopicDetailResponse" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected TopicDetailResponse() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="TopicDetailResponse" /> class.
        /// </summary>
        /// <param name="Id">Unique identifier for the topic resource. (required).</param>
        /// <param name="Name">Descriptive name for the topic..</param>
        /// <param name="CreatedDate">Date and time the topic was created..</param>
        /// <param name="KeyPhrases">Collection of words or phrases that are treated as synonyms by key phrase detection. (required).</param>
        /// <param name="Configuration">Configuration.</param>
        public TopicDetailResponse(string Id = default(string), string Name = default(string), DateTime? CreatedDate = default(DateTime?), List<string> KeyPhrases = default(List<string>), Object Configuration = default(Object))
        {
            // to ensure "Id" is required (not null)
            if (Id == null)
            {
                throw new InvalidDataException("Id is a required property for TopicDetailResponse and cannot be null");
            }
            else
            {
                this.Id = Id;
            }
            // to ensure "KeyPhrases" is required (not null)
            if (KeyPhrases == null)
            {
                throw new InvalidDataException("KeyPhrases is a required property for TopicDetailResponse and cannot be null");
            }
            else
            {
                this.KeyPhrases = KeyPhrases;
            }
            this.Name = Name;
            this.CreatedDate = CreatedDate;
            this.Configuration = Configuration;
        }
        
        /// <summary>
        /// Unique identifier for the topic resource.
        /// </summary>
        /// <value>Unique identifier for the topic resource.</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; set; }

        /// <summary>
        /// Descriptive name for the topic.
        /// </summary>
        /// <value>Descriptive name for the topic.</value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }

        /// <summary>
        /// Date and time the topic was created.
        /// </summary>
        /// <value>Date and time the topic was created.</value>
        [DataMember(Name="created_date", EmitDefaultValue=false)]
        public DateTime? CreatedDate { get; set; }

        /// <summary>
        /// Collection of words or phrases that are treated as synonyms by key phrase detection.
        /// </summary>
        /// <value>Collection of words or phrases that are treated as synonyms by key phrase detection.</value>
        [DataMember(Name="key_phrases", EmitDefaultValue=false)]
        public List<string> KeyPhrases { get; set; }

        /// <summary>
        /// Gets or Sets Configuration
        /// </summary>
        [DataMember(Name="configuration", EmitDefaultValue=false)]
        public Object Configuration { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TopicDetailResponse {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  CreatedDate: ").Append(CreatedDate).Append("\n");
            sb.Append("  KeyPhrases: ").Append(KeyPhrases).Append("\n");
            sb.Append("  Configuration: ").Append(Configuration).Append("\n");
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
            return this.Equals(input as TopicDetailResponse);
        }

        /// <summary>
        /// Returns true if TopicDetailResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of TopicDetailResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TopicDetailResponse input)
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
                    this.CreatedDate == input.CreatedDate ||
                    (this.CreatedDate != null &&
                    this.CreatedDate.Equals(input.CreatedDate))
                ) && 
                (
                    this.KeyPhrases == input.KeyPhrases ||
                    this.KeyPhrases != null &&
                    this.KeyPhrases.SequenceEqual(input.KeyPhrases)
                ) && 
                (
                    this.Configuration == input.Configuration ||
                    (this.Configuration != null &&
                    this.Configuration.Equals(input.Configuration))
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
                if (this.CreatedDate != null)
                    hashCode = hashCode * 59 + this.CreatedDate.GetHashCode();
                if (this.KeyPhrases != null)
                    hashCode = hashCode * 59 + this.KeyPhrases.GetHashCode();
                if (this.Configuration != null)
                    hashCode = hashCode * 59 + this.Configuration.GetHashCode();
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