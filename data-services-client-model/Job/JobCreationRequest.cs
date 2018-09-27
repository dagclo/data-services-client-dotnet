/* 
 * Job management
 *
 * A service that allows management and querying of data services jobs.  Some of the important traits of jobs are:  * A job has a unique `job_id`. * A job can have widely different life-cycles. Typically they represent a single batch job, but they can also represent interactions with the data services that span multiple sessions. * Jobs form a convenient 'container' for registering data service usage, stored and updated on an hourly basis. * When invoking data services, the `job_id` value should be passed in via the `Job-ID` HTTP header in order to register the specific service usage under a specific job. * If no `Job-ID` header is provided, all users also have a surrogate job called `users/{user_id}` which all other data service usage is registered against. * Jobs can exist in hierarchies. A job is considered a child/sub-job of another job when the `parent_job` attribute is set. * Job metadata such as `expected_services` and `expected_record_count` help in reserving necesary credits and other resources when specified. * Normally jobs are owned by an individual user and can only be accessed by this user. But there can also be tenant-scoped jobs in which case the job data can be accessed and managed by all members of the tenant with the relevant roles. 
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

namespace Quadient.DataServices.Model.Job
{
    /// <summary>
    /// JobCreationRequest
    /// </summary>
    [DataContract]
    public partial class JobCreationRequest : IEquatable<JobCreationRequest>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="JobCreationRequest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected JobCreationRequest() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="JobCreationRequest" /> class.
        /// </summary>
        /// <param name="Origin">The originating product/application/service for which this job is being created. (required).</param>
        /// <param name="Owner">The user_id of the job&#39;s owner..</param>
        /// <param name="Tenant">The tenant the job is associated with.  Required if user has multiple tenants, optional otherwise..</param>
        /// <param name="ParentJob">The (optional) parent job&#39;s job_id. This may be specified if the job should have a declared child-relationship with a parent job..</param>
        /// <param name="ExpectedServices">An array of the expected services that this job will be consuming, referred to by their service_id..</param>
        /// <param name="ExpectedRecordCount">The expected amount of records that will be processed by the &#x60;expected_services&#x60; in this job.</param>
        /// <param name="JobStatus">JobStatus.</param>
        /// <param name="AdditionalDetails">Any additional details about the job..</param>
        public JobCreationRequest(string Origin = default(string), string Owner = default(string), string Tenant = default(string), string ParentJob = default(string), List<string> ExpectedServices = default(List<string>), long? ExpectedRecordCount = default(long?), JobStatus JobStatus = default(JobStatus), Object AdditionalDetails = default(Object))
        {
            // to ensure "Origin" is required (not null)
            if (Origin == null)
            {
                throw new InvalidDataException("Origin is a required property for JobCreationRequest and cannot be null");
            }
            else
            {
                this.Origin = Origin;
            }
            this.Owner = Owner;
            this.Tenant = Tenant;
            this.ParentJob = ParentJob;
            this.ExpectedServices = ExpectedServices;
            this.ExpectedRecordCount = ExpectedRecordCount;
            this.JobStatus = JobStatus;
            this.AdditionalDetails = AdditionalDetails;
        }
        
        /// <summary>
        /// The originating product/application/service for which this job is being created.
        /// </summary>
        /// <value>The originating product/application/service for which this job is being created.</value>
        [DataMember(Name="origin", EmitDefaultValue=false)]
        public string Origin { get; set; }

        /// <summary>
        /// The user_id of the job&#39;s owner.
        /// </summary>
        /// <value>The user_id of the job&#39;s owner.</value>
        [DataMember(Name="owner", EmitDefaultValue=false)]
        public string Owner { get; set; }

        /// <summary>
        /// The tenant the job is associated with.  Required if user has multiple tenants, optional otherwise.
        /// </summary>
        /// <value>The tenant the job is associated with.  Required if user has multiple tenants, optional otherwise.</value>
        [DataMember(Name="tenant", EmitDefaultValue=false)]
        public string Tenant { get; set; }

        /// <summary>
        /// The (optional) parent job&#39;s job_id. This may be specified if the job should have a declared child-relationship with a parent job.
        /// </summary>
        /// <value>The (optional) parent job&#39;s job_id. This may be specified if the job should have a declared child-relationship with a parent job.</value>
        [DataMember(Name="parent_job", EmitDefaultValue=false)]
        public string ParentJob { get; set; }

        /// <summary>
        /// An array of the expected services that this job will be consuming, referred to by their service_id.
        /// </summary>
        /// <value>An array of the expected services that this job will be consuming, referred to by their service_id.</value>
        [DataMember(Name="expected_services", EmitDefaultValue=false)]
        public List<string> ExpectedServices { get; set; }

        /// <summary>
        /// The expected amount of records that will be processed by the &#x60;expected_services&#x60; in this job
        /// </summary>
        /// <value>The expected amount of records that will be processed by the &#x60;expected_services&#x60; in this job</value>
        [DataMember(Name="expected_record_count", EmitDefaultValue=false)]
        public long? ExpectedRecordCount { get; set; }

        /// <summary>
        /// Gets or Sets JobStatus
        /// </summary>
        [DataMember(Name="job_status", EmitDefaultValue=false)]
        public JobStatus JobStatus { get; set; }

        /// <summary>
        /// Any additional details about the job.
        /// </summary>
        /// <value>Any additional details about the job.</value>
        [DataMember(Name="additional_details", EmitDefaultValue=false)]
        public Object AdditionalDetails { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class JobCreationRequest {\n");
            sb.Append("  Origin: ").Append(Origin).Append("\n");
            sb.Append("  Owner: ").Append(Owner).Append("\n");
            sb.Append("  Tenant: ").Append(Tenant).Append("\n");
            sb.Append("  ParentJob: ").Append(ParentJob).Append("\n");
            sb.Append("  ExpectedServices: ").Append(ExpectedServices).Append("\n");
            sb.Append("  ExpectedRecordCount: ").Append(ExpectedRecordCount).Append("\n");
            sb.Append("  JobStatus: ").Append(JobStatus).Append("\n");
            sb.Append("  AdditionalDetails: ").Append(AdditionalDetails).Append("\n");
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
            return this.Equals(input as JobCreationRequest);
        }

        /// <summary>
        /// Returns true if JobCreationRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of JobCreationRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(JobCreationRequest input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Origin == input.Origin ||
                    (this.Origin != null &&
                    this.Origin.Equals(input.Origin))
                ) && 
                (
                    this.Owner == input.Owner ||
                    (this.Owner != null &&
                    this.Owner.Equals(input.Owner))
                ) && 
                (
                    this.Tenant == input.Tenant ||
                    (this.Tenant != null &&
                    this.Tenant.Equals(input.Tenant))
                ) && 
                (
                    this.ParentJob == input.ParentJob ||
                    (this.ParentJob != null &&
                    this.ParentJob.Equals(input.ParentJob))
                ) && 
                (
                    this.ExpectedServices == input.ExpectedServices ||
                    this.ExpectedServices != null &&
                    this.ExpectedServices.SequenceEqual(input.ExpectedServices)
                ) && 
                (
                    this.ExpectedRecordCount == input.ExpectedRecordCount ||
                    (this.ExpectedRecordCount != null &&
                    this.ExpectedRecordCount.Equals(input.ExpectedRecordCount))
                ) && 
                (
                    this.JobStatus == input.JobStatus ||
                    (this.JobStatus != null &&
                    this.JobStatus.Equals(input.JobStatus))
                ) && 
                (
                    this.AdditionalDetails == input.AdditionalDetails ||
                    (this.AdditionalDetails != null &&
                    this.AdditionalDetails.Equals(input.AdditionalDetails))
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
                if (this.Origin != null)
                    hashCode = hashCode * 59 + this.Origin.GetHashCode();
                if (this.Owner != null)
                    hashCode = hashCode * 59 + this.Owner.GetHashCode();
                if (this.Tenant != null)
                    hashCode = hashCode * 59 + this.Tenant.GetHashCode();
                if (this.ParentJob != null)
                    hashCode = hashCode * 59 + this.ParentJob.GetHashCode();
                if (this.ExpectedServices != null)
                    hashCode = hashCode * 59 + this.ExpectedServices.GetHashCode();
                if (this.ExpectedRecordCount != null)
                    hashCode = hashCode * 59 + this.ExpectedRecordCount.GetHashCode();
                if (this.JobStatus != null)
                    hashCode = hashCode * 59 + this.JobStatus.GetHashCode();
                if (this.AdditionalDetails != null)
                    hashCode = hashCode * 59 + this.AdditionalDetails.GetHashCode();
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
