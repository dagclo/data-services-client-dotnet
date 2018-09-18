/* 
 * US-Appends
 *
 * Provides Suppression information to your US contacts. This service offers the ability to update addresses of persons who have moved, inform you in case of incarceration, death or if they have opted in to a do-not-mail registry.  ## Job execution  The general flow to execute a batch job is to:  1. Create a job, specifying configuration properties, upload and download schema (input fields and output fields). Job configuration cannot be changed after creation.  2. Upload records to process via one or more calls to the `/jobs/{job_id}/records` endpoint. Records are uploaded in blocks. The records are stored on the server for processing.  3. Initiate processing by calling the `/jobs/{job_id}/_run` endpoint. 4. Wait for the job status to enter `SUCCESS` or `FAILED`. 5. Download the records. 6. Delete job when you are done with it via a `DELETE` on the `/jobs/{job_id}` endpoint, removing input and output records.  ## Records  Records must be uploaded completely prior to running the service. Records are categorized as `input` or `output`. The schema (fields and order) of the records are defined via the job creation call.  ## Pagination Records for a job are broken into pages (`page_id`) for retrieval. The collection of record page ids are available via the `/jobs/{job_id}/records/pages` endpoint. Retrieve this collection as a precursor to downloading records. Each record page can then be retrieved by the client. Page IDs are immutable and can be retrieved in parallel. Record pages may also be retrieved multiple times if needed. 
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

namespace Quadient.DataServies.Model.UsBatch
{
    /// <summary>
    /// Defines the layout of records that will be uploaded/downloaded in this job.
    /// </summary>
    [DataContract]
    public partial class USAppendsJob :  IEquatable<USAppendsJob>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="USAppendsJob" /> class.
        /// </summary>
        /// <param name="JobId">JobId.</param>
        /// <param name="JobStatus">JobStatus.</param>
        /// <param name="ParentJob">The Job ID of the parent job. .</param>
        /// <param name="Configuration">Configuration.</param>
        /// <param name="InputFields">InputFields.</param>
        /// <param name="OutputFields">OutputFields.</param>
        public USAppendsJob(string JobId = default(string), JobStatus JobStatus = default(JobStatus), string ParentJob = default(string), USAppendsConfiguration Configuration = default(USAppendsConfiguration), List<USAppendsInputField> InputFields = default(List<USAppendsInputField>), List<USAppendsOutputField> OutputFields = default(List<USAppendsOutputField>))
        {
            this.JobId = JobId;
            this.JobStatus = JobStatus;
            this.ParentJob = ParentJob;
            this.Configuration = Configuration;
            this.InputFields = InputFields;
            this.OutputFields = OutputFields;
        }
        
        /// <summary>
        /// Gets or Sets JobId
        /// </summary>
        [DataMember(Name="job_id", EmitDefaultValue=false)]
        public string JobId { get; set; }

        /// <summary>
        /// Gets or Sets JobStatus
        /// </summary>
        [DataMember(Name="job_status", EmitDefaultValue=false)]
        public JobStatus JobStatus { get; set; }

        /// <summary>
        /// The Job ID of the parent job. 
        /// </summary>
        /// <value>The Job ID of the parent job. </value>
        [DataMember(Name="parent_job", EmitDefaultValue=false)]
        public string ParentJob { get; set; }

        /// <summary>
        /// Gets or Sets Configuration
        /// </summary>
        [DataMember(Name="configuration", EmitDefaultValue=false)]
        public USAppendsConfiguration Configuration { get; set; }

        /// <summary>
        /// Gets or Sets InputFields
        /// </summary>
        [DataMember(Name="input_fields", EmitDefaultValue=false)]
        public List<USAppendsInputField> InputFields { get; set; }

        /// <summary>
        /// Gets or Sets OutputFields
        /// </summary>
        [DataMember(Name="output_fields", EmitDefaultValue=false)]
        public List<USAppendsOutputField> OutputFields { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class USAppendsJob {\n");
            sb.Append("  JobId: ").Append(JobId).Append("\n");
            sb.Append("  JobStatus: ").Append(JobStatus).Append("\n");
            sb.Append("  ParentJob: ").Append(ParentJob).Append("\n");
            sb.Append("  Configuration: ").Append(Configuration).Append("\n");
            sb.Append("  InputFields: ").Append(InputFields).Append("\n");
            sb.Append("  OutputFields: ").Append(OutputFields).Append("\n");
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
            return this.Equals(input as USAppendsJob);
        }

        /// <summary>
        /// Returns true if USAppendsJob instances are equal
        /// </summary>
        /// <param name="input">Instance of USAppendsJob to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(USAppendsJob input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.JobId == input.JobId ||
                    (this.JobId != null &&
                    this.JobId.Equals(input.JobId))
                ) && 
                (
                    this.JobStatus == input.JobStatus ||
                    (this.JobStatus != null &&
                    this.JobStatus.Equals(input.JobStatus))
                ) && 
                (
                    this.ParentJob == input.ParentJob ||
                    (this.ParentJob != null &&
                    this.ParentJob.Equals(input.ParentJob))
                ) && 
                (
                    this.Configuration == input.Configuration ||
                    (this.Configuration != null &&
                    this.Configuration.Equals(input.Configuration))
                ) && 
                (
                    this.InputFields == input.InputFields ||
                    this.InputFields != null &&
                    this.InputFields.SequenceEqual(input.InputFields)
                ) && 
                (
                    this.OutputFields == input.OutputFields ||
                    this.OutputFields != null &&
                    this.OutputFields.SequenceEqual(input.OutputFields)
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
                if (this.JobId != null)
                    hashCode = hashCode * 59 + this.JobId.GetHashCode();
                if (this.JobStatus != null)
                    hashCode = hashCode * 59 + this.JobStatus.GetHashCode();
                if (this.ParentJob != null)
                    hashCode = hashCode * 59 + this.ParentJob.GetHashCode();
                if (this.Configuration != null)
                    hashCode = hashCode * 59 + this.Configuration.GetHashCode();
                if (this.InputFields != null)
                    hashCode = hashCode * 59 + this.InputFields.GetHashCode();
                if (this.OutputFields != null)
                    hashCode = hashCode * 59 + this.OutputFields.GetHashCode();
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
