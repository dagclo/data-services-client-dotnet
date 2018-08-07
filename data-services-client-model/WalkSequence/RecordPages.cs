/* 
 * Walk Sequence
 *
 * Appends USPS Walk Sequence numbers to mail pieces.  ## Job execution  The general flow to execute a batch job is to:  1. Create a job while specifying upload format (input fields) and download (output fields). 2. Upload records to process via one or more calls to the API. Records are uploaded in blocks. The records are    persisted until at least the end of the job. 3. Initiate processing by calling the `_run` endpoint. 4. Wait for the job status to enter `SUCCESS` or `FAILED`. 5. Download the records. 6. Delete job as appropriate.  ## Records  Records must be uploaded completely prior to running the service. Records are categorized as `input` or `output`. See Pagination for more information.  ## Pagination Records for a job are broken into pages (`page_id`) for retrieval. The collection of record page IDs are available and must be retrieved as a precursor to downloading records. Each record page can then be retrieved by the client. Page IDs are immutable and can be retrieved multiple times if needed. 
 *
 * OpenAPI spec version: 0.1.0
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

namespace Quadient.DataServies.Model.WalkSequence
{
    /// <summary>
    /// RecordPages
    /// </summary>
    [DataContract]
    public partial class RecordPages :  IEquatable<RecordPages>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RecordPages" /> class.
        /// </summary>
        /// <param name="PageIds">A collection of page IDs that can be retrieved.</param>
        public RecordPages(List<string> PageIds = default(List<string>))
        {
            this.PageIds = PageIds;
        }
        
        /// <summary>
        /// A collection of page IDs that can be retrieved
        /// </summary>
        /// <value>A collection of page IDs that can be retrieved</value>
        [DataMember(Name="page_ids", EmitDefaultValue=false)]
        public List<string> PageIds { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class RecordPages {\n");
            sb.Append("  PageIds: ").Append(PageIds).Append("\n");
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
            return this.Equals(input as RecordPages);
        }

        /// <summary>
        /// Returns true if RecordPages instances are equal
        /// </summary>
        /// <param name="input">Instance of RecordPages to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(RecordPages input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.PageIds == input.PageIds ||
                    this.PageIds != null &&
                    this.PageIds.SequenceEqual(input.PageIds)
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
                if (this.PageIds != null)
                    hashCode = hashCode * 59 + this.PageIds.GetHashCode();
                return hashCode;
            }
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }

}
