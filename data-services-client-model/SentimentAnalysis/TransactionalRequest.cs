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
    /// A collection of artifacts for sentiment analysis.
    /// </summary>
    [DataContract]
    public partial class TransactionalRequest : IEquatable<TransactionalRequest>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TransactionalRequest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected TransactionalRequest() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="TransactionalRequest" /> class.
        /// </summary>
        /// <param name="Artifacts">Artifacts (required).</param>
        /// <param name="Configuration">Configuration.</param>
        public TransactionalRequest(List<TransactionalArtifactRequest> Artifacts = default(List<TransactionalArtifactRequest>), TransactionalConfiguration Configuration = default(TransactionalConfiguration))
        {
            // to ensure "Artifacts" is required (not null)
            if (Artifacts == null)
            {
                throw new InvalidDataException("Artifacts is a required property for TransactionalRequest and cannot be null");
            }
            else
            {
                this.Artifacts = Artifacts;
            }
            this.Configuration = Configuration;
        }
        
        /// <summary>
        /// Gets or Sets Artifacts
        /// </summary>
        [DataMember(Name="artifacts", EmitDefaultValue=false)]
        public List<TransactionalArtifactRequest> Artifacts { get; set; }

        /// <summary>
        /// Gets or Sets Configuration
        /// </summary>
        [DataMember(Name="configuration", EmitDefaultValue=false)]
        public TransactionalConfiguration Configuration { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TransactionalRequest {\n");
            sb.Append("  Artifacts: ").Append(Artifacts).Append("\n");
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
            return this.Equals(input as TransactionalRequest);
        }

        /// <summary>
        /// Returns true if TransactionalRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of TransactionalRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TransactionalRequest input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Artifacts == input.Artifacts ||
                    this.Artifacts != null &&
                    this.Artifacts.SequenceEqual(input.Artifacts)
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
                if (this.Artifacts != null)
                    hashCode = hashCode * 59 + this.Artifacts.GetHashCode();
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
