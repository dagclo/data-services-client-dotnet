/* 
 * US-Appends
 *
 * The US Appends service is a Quadient Cloud Data Services offering designed to help you improve and enhance the quality of your US-based contact data. The service can be used as a component of regular list cleansing and maintenance. The service flags contact records that match entries on do-not-mail and deceased person lists. It identifies addresses within correctional facilities. It also provides and corrects secondary data for an address, such as apartment number or floor number.  This service can reduce mailing costs by identifying people that are unwilling or unable to respond or have an undeliverable address. It helps bring into focus for your assessment whether a potential communication recipient should be removed from a list.   ## Key functionality: * Flags records that match entries on do-not-mail, deceased person, and correctional facility lists. * Appends missing apartment number unit information to an address to improve address quality.  ## Job execution  The general flow to execute a batch job is to:  1. Create a job, specifying its configuration properties, and upload and download schema (input fields and output fields). You cannot change the job's configuration after creation.  2. Upload records you want to process via one or more calls to the `/jobs/{job_id}/records` endpoint. Records are uploaded in blocks. The records are stored on the server for processing.  3. Initiate processing by calling the `/jobs/{job_id}/_run` endpoint. 4. Wait for the job status to be updated to `SUCCESS` or `FAILED`. 5. Download the records. 6. Delete job when you are done by requesting a `DELETE` on the `/jobs/{job_id}` endpoint, removing input and output records.  ## Records  The upload of records must be complete prior to running the service. Records are categorized as `input` or `output`. The schema (fields and order) of the records is defined via the job creation call.  ## Pagination Records for a job are broken into pages (`page_id`) for retrieval. The collection of record page IDs is available via the `/jobs/{job_id}/records/pages` endpoint. Retrieve this collection as a precursor to downloading records. Each record page can then be retrieved by the client. Page IDs are immutable and can be retrieved in parallel. Record pages may also be retrieved multiple times if needed.  ## Outcome codes  ### Apartment Append `A1` - Apartment information confirmed to be correct for the individual. No Changes made. `A2` - Apartment information present confirmed to be correct for the address. No Changes made. `C1` - Apartment information appended to address. `C4` - Lookup attempted, no apartment found. `E1` - Address was invalid as input. No changes made. `E2` - No contact information supplied. No changes made. `E3` - Multiple contacts on input. No changes made. `E4` - No lookup attempted.  ### Name Append `C1` - Name appended. `C4` - Name not appended.  ### Gender Append `C1` - Gender Added `C2` - No Gender added `C3` - Multiple names. No gender assigned. `C4` - Ambiguous result. No gender assigned.  ## Field value defintions  ### Gender Append `gender`, possible values: `M` - Male `F` - Female `U` - Unable to assign / Ambiguous 
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

namespace Quadient.DataServices.Model.UsBatch
{
    /// <summary>
    /// Defines the layout of records that will be uploaded or downloaded in this job.
    /// </summary>
    [DataContract]
    public partial class USAppendsJob : IEquatable<USAppendsJob>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="USAppendsJob" /> class.
        /// </summary>
        /// <param name="JobId">JobId.</param>
        /// <param name="JobStatus">JobStatus.</param>
        /// <param name="JobStatusDetails">JobStatusDetails.</param>
        /// <param name="ParentJob">The job ID of the parent job. .</param>
        /// <param name="Configuration">Configuration.</param>
        /// <param name="InputFields">InputFields.</param>
        /// <param name="OutputFields">OutputFields.</param>
        public USAppendsJob(string JobId = default(string), JobStatus JobStatus = default(JobStatus), string JobStatusDetails = default(string), string ParentJob = default(string), USAppendsConfiguration Configuration = default(USAppendsConfiguration), List<USAppendsInputField> InputFields = default(List<USAppendsInputField>), List<USAppendsOutputField> OutputFields = default(List<USAppendsOutputField>))
        {
            this.JobId = JobId;
            this.JobStatus = JobStatus;
            this.JobStatusDetails = JobStatusDetails;
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
        /// Gets or Sets JobStatusDetails
        /// </summary>
        [DataMember(Name="job_status_details", EmitDefaultValue=false)]
        public string JobStatusDetails { get; set; }

        /// <summary>
        /// The job ID of the parent job. 
        /// </summary>
        /// <value>The job ID of the parent job. </value>
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
            sb.Append("  JobStatusDetails: ").Append(JobStatusDetails).Append("\n");
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
                    this.JobStatusDetails == input.JobStatusDetails ||
                    (this.JobStatusDetails != null &&
                    this.JobStatusDetails.Equals(input.JobStatusDetails))
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
                if (this.JobStatusDetails != null)
                    hashCode = hashCode * 59 + this.JobStatusDetails.GetHashCode();
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
        IEnumerable<ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }

}
