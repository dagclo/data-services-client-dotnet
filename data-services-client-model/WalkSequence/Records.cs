/* 
 * Walk Sequence
 *
 * Performs USPS CASS processing and appends USPS Walk Sequence numbers to mail pieces. Properly walk sequenced mailings may qualify for USPS mailing discounts.  ## Job execution  The general flow to execute a batch job is to:  1. Create a job, specifying configuration properties, upload and download schema (input fields and output fields). Job configuration cannot be changed after creation.  2. Upload records to process via one or more calls to the `/jobs/{job_id}/records` endpoint. Records are uploaded in blocks. The records are stored on the server for processing.  3. Initiate processing by calling the `/jobs/{job_id}/_run` endpoint. 4. Wait for the job status to enter `SUCCESS` or `FAILED`. 5. Download the records. 6. Delete job when you are done with it via a `DELETE` on the `/jobs/{job_id}` endpoint, removing input and output records.  ## Records  Records must be uploaded completely prior to running the service. Records are categorized as `input` or `output`. The schema (fields and order) of the records are defined via the job creation call.  ## Pagination Records for a job are broken into pages (`page_id`) for retrieval. The collection of record page ids are available via the `/jobs/{job_id}/records/pages` endpoint. Retrieve this collection as a precursor to downloading records. Each record page can then be retrieved by the client. Page IDs are immutable and can be retrieved in parallel. Record pages may also be retrieved multiple times if needed. 
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
    /// Records
    /// </summary>
    [DataContract]
    public partial class Records :  IEquatable<Records>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Records" /> class.
        /// </summary>
        /// <param name="_Records">A two-dimensional array containing records to be uploaded.</param>
        public Records(List<List<string>> _Records = default(List<List<string>>))
        {
            this._Records = _Records;
        }
        
        /// <summary>
        /// A two-dimensional array containing records to be uploaded
        /// </summary>
        /// <value>A two-dimensional array containing records to be uploaded</value>
        [DataMember(Name="records", EmitDefaultValue=false)]
        public List<List<string>> _Records { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Records {\n");
            sb.Append("  _Records: ").Append(_Records).Append("\n");
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
            return this.Equals(input as Records);
        }

        /// <summary>
        /// Returns true if Records instances are equal
        /// </summary>
        /// <param name="input">Instance of Records to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Records input)
        {
            if (input == null)
                return false;

            return 
                (
                    this._Records == input._Records ||
                    this._Records != null &&
                    this._Records.SequenceEqual(input._Records)
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
                if (this._Records != null)
                    hashCode = hashCode * 59 + this._Records.GetHashCode();
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