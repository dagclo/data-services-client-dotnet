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
    /// DailyUsageAggregation
    /// </summary>
    [DataContract]
    public partial class DailyUsageAggregation : IEquatable<DailyUsageAggregation>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DailyUsageAggregation" /> class.
        /// </summary>
        /// <param name="Finalized">Are the usage metrics finalized (true) or just a point-in-time snapshot (false)..</param>
        /// <param name="ServiceUse">Defines a set of usage metrics for each of the services that has been consumed during the job..</param>
        /// <param name="Date">The date of the usage (UTC timezone).</param>
        public DailyUsageAggregation(bool? Finalized = default(bool?), Object ServiceUse = default(Object), DateTime? Date = default(DateTime?))
        {
            this.Finalized = Finalized;
            this.ServiceUse = ServiceUse;
            this.Date = Date;
        }
        
        /// <summary>
        /// Are the usage metrics finalized (true) or just a point-in-time snapshot (false).
        /// </summary>
        /// <value>Are the usage metrics finalized (true) or just a point-in-time snapshot (false).</value>
        [DataMember(Name="finalized", EmitDefaultValue=false)]
        public bool? Finalized { get; set; }

        /// <summary>
        /// Defines a set of usage metrics for each of the services that has been consumed during the job.
        /// </summary>
        /// <value>Defines a set of usage metrics for each of the services that has been consumed during the job.</value>
        [DataMember(Name="service-use", EmitDefaultValue=false)]
        public Object ServiceUse { get; set; }

        /// <summary>
        /// The date of the usage (UTC timezone)
        /// </summary>
        /// <value>The date of the usage (UTC timezone)</value>
        [DataMember(Name="date", EmitDefaultValue=false)]
        [JsonConverter(typeof(SwaggerDateConverter))]
        public DateTime? Date { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DailyUsageAggregation {\n");
            sb.Append("  Finalized: ").Append(Finalized).Append("\n");
            sb.Append("  ServiceUse: ").Append(ServiceUse).Append("\n");
            sb.Append("  Date: ").Append(Date).Append("\n");
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
            return this.Equals(input as DailyUsageAggregation);
        }

        /// <summary>
        /// Returns true if DailyUsageAggregation instances are equal
        /// </summary>
        /// <param name="input">Instance of DailyUsageAggregation to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DailyUsageAggregation input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Finalized == input.Finalized ||
                    (this.Finalized != null &&
                    this.Finalized.Equals(input.Finalized))
                ) && 
                (
                    this.ServiceUse == input.ServiceUse ||
                    (this.ServiceUse != null &&
                    this.ServiceUse.Equals(input.ServiceUse))
                ) && 
                (
                    this.Date == input.Date ||
                    (this.Date != null &&
                    this.Date.Equals(input.Date))
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
                if (this.Finalized != null)
                    hashCode = hashCode * 59 + this.Finalized.GetHashCode();
                if (this.ServiceUse != null)
                    hashCode = hashCode * 59 + this.ServiceUse.GetHashCode();
                if (this.Date != null)
                    hashCode = hashCode * 59 + this.Date.GetHashCode();
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
