/* 
 * Data Quality Assessment
 *
 * Allows users to assess the Quadient Data Services before buying. This service runs assessment jobs based on real data, but does not give back the records that have been corrected. Rather, it provides \"assessment metrics\" which can be used to determine and explain the value of using Data Services. 
 *
 * OpenAPI spec version: 1.0.0
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

namespace Quadient.DataServices.Model.Assessment
{
    /// <summary>
    /// JobListItem
    /// </summary>
    [DataContract]
    public partial class JobListItem : IEquatable<JobListItem>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="JobListItem" /> class.
        /// </summary>
        /// <param name="JobId">JobId.</param>
        /// <param name="Name">Name.</param>
        /// <param name="Services">Services.</param>
        /// <param name="JobStatus">JobStatus.</param>
        /// <param name="ProgressDetails">ProgressDetails.</param>
        /// <param name="CreatedAt">The time of job creation.</param>
        public JobListItem(string JobId = default(string), string Name = default(string), ServicesArray Services = default(ServicesArray), JobStatus JobStatus = default(JobStatus), ProgressDetails ProgressDetails = default(ProgressDetails), DateTime? CreatedAt = default(DateTime?))
        {
            this.JobId = JobId;
            this.Name = Name;
            this.Services = Services;
            this.JobStatus = JobStatus;
            this.ProgressDetails = ProgressDetails;
            this.CreatedAt = CreatedAt;
        }
        
        /// <summary>
        /// Gets or Sets JobId
        /// </summary>
        [DataMember(Name="job_id", EmitDefaultValue=false)]
        public string JobId { get; set; }

        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }

        /// <summary>
        /// Gets or Sets Services
        /// </summary>
        [DataMember(Name="services", EmitDefaultValue=false)]
        public ServicesArray Services { get; set; }

        /// <summary>
        /// Gets or Sets JobStatus
        /// </summary>
        [DataMember(Name="job_status", EmitDefaultValue=false)]
        public JobStatus JobStatus { get; set; }

        /// <summary>
        /// Gets or Sets ProgressDetails
        /// </summary>
        [DataMember(Name="progress_details", EmitDefaultValue=false)]
        public ProgressDetails ProgressDetails { get; set; }

        /// <summary>
        /// The time of job creation
        /// </summary>
        /// <value>The time of job creation</value>
        [DataMember(Name="created_at", EmitDefaultValue=false)]
        public DateTime? CreatedAt { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class JobListItem {\n");
            sb.Append("  JobId: ").Append(JobId).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Services: ").Append(Services).Append("\n");
            sb.Append("  JobStatus: ").Append(JobStatus).Append("\n");
            sb.Append("  ProgressDetails: ").Append(ProgressDetails).Append("\n");
            sb.Append("  CreatedAt: ").Append(CreatedAt).Append("\n");
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
            return this.Equals(input as JobListItem);
        }

        /// <summary>
        /// Returns true if JobListItem instances are equal
        /// </summary>
        /// <param name="input">Instance of JobListItem to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(JobListItem input)
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
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.Services == input.Services ||
                    (this.Services != null &&
                    this.Services.Equals(input.Services))
                ) && 
                (
                    this.JobStatus == input.JobStatus ||
                    (this.JobStatus != null &&
                    this.JobStatus.Equals(input.JobStatus))
                ) && 
                (
                    this.ProgressDetails == input.ProgressDetails ||
                    (this.ProgressDetails != null &&
                    this.ProgressDetails.Equals(input.ProgressDetails))
                ) && 
                (
                    this.CreatedAt == input.CreatedAt ||
                    (this.CreatedAt != null &&
                    this.CreatedAt.Equals(input.CreatedAt))
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
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.Services != null)
                    hashCode = hashCode * 59 + this.Services.GetHashCode();
                if (this.JobStatus != null)
                    hashCode = hashCode * 59 + this.JobStatus.GetHashCode();
                if (this.ProgressDetails != null)
                    hashCode = hashCode * 59 + this.ProgressDetails.GetHashCode();
                if (this.CreatedAt != null)
                    hashCode = hashCode * 59 + this.CreatedAt.GetHashCode();
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
