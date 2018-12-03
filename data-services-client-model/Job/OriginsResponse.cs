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
    /// OriginsResponse
    /// </summary>
    [DataContract]
    public partial class OriginsResponse : IEquatable<OriginsResponse>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="OriginsResponse" /> class.
        /// </summary>
        /// <param name="Origins">A list of distinct origin values used.</param>
        public OriginsResponse(List<string> Origins = default(List<string>))
        {
            this.Origins = Origins;
        }
        
        /// <summary>
        /// A list of distinct origin values used
        /// </summary>
        /// <value>A list of distinct origin values used</value>
        [DataMember(Name="origins", EmitDefaultValue=false)]
        public List<string> Origins { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class OriginsResponse {\n");
            sb.Append("  Origins: ").Append(Origins).Append("\n");
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
            return this.Equals(input as OriginsResponse);
        }

        /// <summary>
        /// Returns true if OriginsResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of OriginsResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(OriginsResponse input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Origins == input.Origins ||
                    this.Origins != null &&
                    this.Origins.SequenceEqual(input.Origins)
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
                if (this.Origins != null)
                    hashCode = hashCode * 59 + this.Origins.GetHashCode();
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
