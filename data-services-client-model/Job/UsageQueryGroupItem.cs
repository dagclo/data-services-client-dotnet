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
    /// UsageQueryGroupItem
    /// </summary>
    [DataContract]
    public partial class UsageQueryGroupItem : IEquatable<UsageQueryGroupItem>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UsageQueryGroupItem" /> class.
        /// </summary>
        /// <param name="GroupValue">The value of the group, e.g. the date, the job_id or whatever was used as the group parameter of the query.</param>
        /// <param name="Usage">Defines a set of usage metrics for each of the services that has been consumed in this group..</param>
        public UsageQueryGroupItem(string GroupValue = default(string), Object Usage = default(Object))
        {
            this.GroupValue = GroupValue;
            this.Usage = Usage;
        }
        
        /// <summary>
        /// The value of the group, e.g. the date, the job_id or whatever was used as the group parameter of the query
        /// </summary>
        /// <value>The value of the group, e.g. the date, the job_id or whatever was used as the group parameter of the query</value>
        [DataMember(Name="group_value", EmitDefaultValue=false)]
        public string GroupValue { get; set; }

        /// <summary>
        /// Defines a set of usage metrics for each of the services that has been consumed in this group.
        /// </summary>
        /// <value>Defines a set of usage metrics for each of the services that has been consumed in this group.</value>
        [DataMember(Name="usage", EmitDefaultValue=false)]
        public Object Usage { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UsageQueryGroupItem {\n");
            sb.Append("  GroupValue: ").Append(GroupValue).Append("\n");
            sb.Append("  Usage: ").Append(Usage).Append("\n");
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
            return this.Equals(input as UsageQueryGroupItem);
        }

        /// <summary>
        /// Returns true if UsageQueryGroupItem instances are equal
        /// </summary>
        /// <param name="input">Instance of UsageQueryGroupItem to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(UsageQueryGroupItem input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.GroupValue == input.GroupValue ||
                    (this.GroupValue != null &&
                    this.GroupValue.Equals(input.GroupValue))
                ) && 
                (
                    this.Usage == input.Usage ||
                    (this.Usage != null &&
                    this.Usage.Equals(input.Usage))
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
                if (this.GroupValue != null)
                    hashCode = hashCode * 59 + this.GroupValue.GetHashCode();
                if (this.Usage != null)
                    hashCode = hashCode * 59 + this.Usage.GetHashCode();
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
