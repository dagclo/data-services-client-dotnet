/* 
 * Job management
 *
 * A service that allows management and querying of data services jobs.  Some of the important traits of jobs are:  * A job has a unique `job_id`. * A job can have widely different life-cycles. Typically they represent a single batch job, but they can also represent interactions with the data services that span multiple sessions. * Jobs form a convenient 'container' for registering data service usage, stored and updated on an hourly basis. * When invoking data services, the `job_id` value should be passed in via the `Job-ID` HTTP header in order to register the specific service usage under a specific job. * If no `Job-ID` header is provided, all users also have a surrogate job called `users/{user_id}` which all other data service usage is registered against. * Jobs can exist in hierarchies. A job is considered a child/sub-job of another job when the `parent_job` attribute is set. * Job metadata such as `expected_services` and `expected_record_count` help in reserving necesary credits and other resources when specified. * Normally jobs are owned by an individual user and can only be accessed by this user. But there can also be tenant-scoped jobs in which case the job data can be accessed and managed by all members of the tenant with the relevant roles. 
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

namespace Quadient.DataServices.Model.Job
{
    /// <summary>
    /// JobStatusInformationResponse
    /// </summary>
    [DataContract]
    public partial class JobStatusInformationResponse : IEquatable<JobStatusInformationResponse>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="JobStatusInformationResponse" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected JobStatusInformationResponse() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="JobStatusInformationResponse" /> class.
        /// </summary>
        /// <param name="JobId">The job_id for the job..</param>
        /// <param name="JobStatus">JobStatus (required).</param>
        /// <param name="JobStatusDetails">Any additional details pertaining to the most recent job status change.</param>
        /// <param name="ChildStatuses">ChildStatuses.</param>
        public JobStatusInformationResponse(string JobId = default(string), JobStatus JobStatus = default(JobStatus), Object JobStatusDetails = default(Object), List<JobStatusInformationResponse> ChildStatuses = default(List<JobStatusInformationResponse>))
        {
            // to ensure "JobStatus" is required (not null)
            if (JobStatus == null)
            {
                throw new InvalidDataException("JobStatus is a required property for JobStatusInformationResponse and cannot be null");
            }
            else
            {
                this.JobStatus = JobStatus;
            }
            this.JobId = JobId;
            this.JobStatusDetails = JobStatusDetails;
            this.ChildStatuses = ChildStatuses;
        }
        
        /// <summary>
        /// The job_id for the job.
        /// </summary>
        /// <value>The job_id for the job.</value>
        [DataMember(Name="job_id", EmitDefaultValue=false)]
        public string JobId { get; set; }

        /// <summary>
        /// Gets or Sets JobStatus
        /// </summary>
        [DataMember(Name="job_status", EmitDefaultValue=false)]
        public JobStatus JobStatus { get; set; }

        /// <summary>
        /// Any additional details pertaining to the most recent job status change
        /// </summary>
        /// <value>Any additional details pertaining to the most recent job status change</value>
        [DataMember(Name="job_status_details", EmitDefaultValue=false)]
        public Object JobStatusDetails { get; set; }

        /// <summary>
        /// Gets or Sets ChildStatuses
        /// </summary>
        [DataMember(Name="child_statuses", EmitDefaultValue=false)]
        public List<JobStatusInformationResponse> ChildStatuses { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class JobStatusInformationResponse {\n");
            sb.Append("  JobId: ").Append(JobId).Append("\n");
            sb.Append("  JobStatus: ").Append(JobStatus).Append("\n");
            sb.Append("  JobStatusDetails: ").Append(JobStatusDetails).Append("\n");
            sb.Append("  ChildStatuses: ").Append(ChildStatuses).Append("\n");
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
            return this.Equals(input as JobStatusInformationResponse);
        }

        /// <summary>
        /// Returns true if JobStatusInformationResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of JobStatusInformationResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(JobStatusInformationResponse input)
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
                    this.ChildStatuses == input.ChildStatuses ||
                    this.ChildStatuses != null &&
                    this.ChildStatuses.SequenceEqual(input.ChildStatuses)
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
                if (this.ChildStatuses != null)
                    hashCode = hashCode * 59 + this.ChildStatuses.GetHashCode();
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
