/* 
 * Job management
 *
 * A service that allows management and querying of data services jobs.  Some of the important traits of jobs are:	* A job has a unique `job_id`. * A job can have widely different life-cycles. Typically they represent a single batch job, but they can also represent interactions with the data services that span multiple sessions. * Jobs form a convenient 'container' for registering data service usage, stored and updated on an hourly basis. * When invoking data services, the `job_id` value should be passed in via the `Job-ID` HTTP header in order to register the specific service usage under a specific job. * If no `Job-ID` header is provided, all users also have a surrogate job called `users/{user_id}` which all other data service usage is registered against. * Jobs can exist in hierarchies. A job is considered a child/sub-job of another job when the `parent_job` attribute is set. * Job metadata such as `expected_services` and `expected_record_count` help in reserving necesary credits and other resources when specified. * Normally jobs are owned by an individual user and can only be accessed by this user. But there can also be tenant-scoped jobs in which case the job data can be accessed and managed by all members of the tenant with the relevant roles. 
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
	/// JobInformationResponse
	/// </summary>
	[DataContract]
	public partial class JobInformationResponse : IEquatable<JobInformationResponse>, IValidatableObject
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="JobInformationResponse" /> class.
		/// </summary>
		/// <param name="JobId">The job&#39;s unique ID..</param>
		/// <param name="Origin">The originating product/application/service for which this job was created..</param>
		/// <param name="Owner">The user_id of the job&#39;s owner..</param>
		/// <param name="ParentJob">The parent job&#39;s job_id. May be null if the job does not have a parent job..</param>
		/// <param name="CreatedAt">The time of job creation.</param>
		/// <param name="JobStatus">JobStatus.</param>
		public JobInformationResponse(string JobId = default(string), string Origin = default(string), string Owner = default(string), string ParentJob = default(string), DateTime? CreatedAt = default(DateTime?), JobStatus JobStatus = default(JobStatus))
		{
			this.JobId = JobId;
			this.Origin = Origin;
			this.Owner = Owner;
			this.ParentJob = ParentJob;
			this.CreatedAt = CreatedAt;
			this.JobStatus = JobStatus;
		}
		
		/// <summary>
		/// The job&#39;s unique ID.
		/// </summary>
		/// <value>The job&#39;s unique ID.</value>
		[DataMember(Name="job_id", EmitDefaultValue=false)]
		public string JobId { get; set; }

		/// <summary>
		/// The originating product/application/service for which this job was created.
		/// </summary>
		/// <value>The originating product/application/service for which this job was created.</value>
		[DataMember(Name="origin", EmitDefaultValue=false)]
		public string Origin { get; set; }

		/// <summary>
		/// The user_id of the job&#39;s owner.
		/// </summary>
		/// <value>The user_id of the job&#39;s owner.</value>
		[DataMember(Name="owner", EmitDefaultValue=false)]
		public string Owner { get; set; }

		/// <summary>
		/// The parent job&#39;s job_id. May be null if the job does not have a parent job.
		/// </summary>
		/// <value>The parent job&#39;s job_id. May be null if the job does not have a parent job.</value>
		[DataMember(Name="parent_job", EmitDefaultValue=false)]
		public string ParentJob { get; set; }

		/// <summary>
		/// The time of job creation
		/// </summary>
		/// <value>The time of job creation</value>
		[DataMember(Name="created_at", EmitDefaultValue=false)]
		public DateTime? CreatedAt { get; set; }

		/// <summary>
		/// Gets or Sets JobStatus
		/// </summary>
		[DataMember(Name="job_status", EmitDefaultValue=false)]
		public JobStatus JobStatus { get; set; }

		/// <summary>
		/// Returns the string presentation of the object
		/// </summary>
		/// <returns>String presentation of the object</returns>
		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.Append("class JobInformationResponse {\n");
			sb.Append("  JobId: ").Append(JobId).Append("\n");
			sb.Append("  Origin: ").Append(Origin).Append("\n");
			sb.Append("  Owner: ").Append(Owner).Append("\n");
			sb.Append("  ParentJob: ").Append(ParentJob).Append("\n");
			sb.Append("  CreatedAt: ").Append(CreatedAt).Append("\n");
			sb.Append("  JobStatus: ").Append(JobStatus).Append("\n");
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
			return this.Equals(input as JobInformationResponse);
		}

		/// <summary>
		/// Returns true if JobInformationResponse instances are equal
		/// </summary>
		/// <param name="input">Instance of JobInformationResponse to be compared</param>
		/// <returns>Boolean</returns>
		public bool Equals(JobInformationResponse input)
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
					this.ParentJob == input.ParentJob ||
					(this.ParentJob != null &&
					this.ParentJob.Equals(input.ParentJob))
				) && 
				(
					this.CreatedAt == input.CreatedAt ||
					(this.CreatedAt != null &&
					this.CreatedAt.Equals(input.CreatedAt))
				) && 
				(
					this.JobStatus == input.JobStatus ||
					(this.JobStatus != null &&
					this.JobStatus.Equals(input.JobStatus))
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
				if (this.Origin != null)
					hashCode = hashCode * 59 + this.Origin.GetHashCode();
				if (this.Owner != null)
					hashCode = hashCode * 59 + this.Owner.GetHashCode();
				if (this.ParentJob != null)
					hashCode = hashCode * 59 + this.ParentJob.GetHashCode();
				if (this.CreatedAt != null)
					hashCode = hashCode * 59 + this.CreatedAt.GetHashCode();
				if (this.JobStatus != null)
					hashCode = hashCode * 59 + this.JobStatus.GetHashCode();
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
