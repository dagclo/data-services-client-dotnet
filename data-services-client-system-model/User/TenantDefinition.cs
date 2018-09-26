/* 
 * User Management
 *
 * Provides an API to:   * Enumerate the user base   * Create new users   * Gather specific user's information   * Change a user's information  User information include things like:   * Whether or not the user account is `enabled` or not   * Username/password credentials as well as API keys   * Contact information such as `first_name`, `last_name`, `organization` and `email_address`   * Group membership - membership of a `group` is used to grant access to services and features   * Tenant membership - membership of a `tenant` is used to assign users specific `roles` in a organization   * Additional details - each user may have a collection of custom key-value pairs  For details about authentication, refer to the [authentication specification](/oauth/swagger.json).
 *
 * OpenAPI spec version: 1.1.32
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
using SwaggerDateConverter = Quadient.DataServices.System.Model.Client.SwaggerDateConverter;

namespace Quadient.DataServices.System.Model.User
{
    /// <summary>
    /// TenantDefinition
    /// </summary>
    [DataContract]
    public partial class TenantDefinition : IEquatable<TenantDefinition>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TenantDefinition" /> class.
        /// </summary>
        /// <param name="TenantName">The name of a tenant.</param>
        /// <param name="GroupDomain">GroupDomain.</param>
        /// <param name="Groups">Groups.</param>
        /// <param name="ServiceConfigurations">ServiceConfigurations.</param>
        public TenantDefinition(string TenantName = default(string), List<string> GroupDomain = default(List<string>), List<string> Groups = default(List<string>), List<string> ServiceConfigurations = default(List<string>))
        {
            this.TenantName = TenantName;
            this.GroupDomain = GroupDomain;
            this.Groups = Groups;
            this.ServiceConfigurations = ServiceConfigurations;
        }
        
        /// <summary>
        /// The name of a tenant
        /// </summary>
        /// <value>The name of a tenant</value>
        [DataMember(Name="tenant_name", EmitDefaultValue=false)]
        public string TenantName { get; set; }

        /// <summary>
        /// Gets or Sets GroupDomain
        /// </summary>
        [DataMember(Name="group_domain", EmitDefaultValue=false)]
        public List<string> GroupDomain { get; set; }

        /// <summary>
        /// Gets or Sets Groups
        /// </summary>
        [DataMember(Name="groups", EmitDefaultValue=false)]
        public List<string> Groups { get; set; }

        /// <summary>
        /// Gets or Sets ServiceConfigurations
        /// </summary>
        [DataMember(Name="service_configurations", EmitDefaultValue=false)]
        public List<string> ServiceConfigurations { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TenantDefinition {\n");
            sb.Append("  TenantName: ").Append(TenantName).Append("\n");
            sb.Append("  GroupDomain: ").Append(GroupDomain).Append("\n");
            sb.Append("  Groups: ").Append(Groups).Append("\n");
            sb.Append("  ServiceConfigurations: ").Append(ServiceConfigurations).Append("\n");
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
            return this.Equals(input as TenantDefinition);
        }

        /// <summary>
        /// Returns true if TenantDefinition instances are equal
        /// </summary>
        /// <param name="input">Instance of TenantDefinition to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TenantDefinition input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.TenantName == input.TenantName ||
                    (this.TenantName != null &&
                    this.TenantName.Equals(input.TenantName))
                ) && 
                (
                    this.GroupDomain == input.GroupDomain ||
                    this.GroupDomain != null &&
                    this.GroupDomain.SequenceEqual(input.GroupDomain)
                ) && 
                (
                    this.Groups == input.Groups ||
                    this.Groups != null &&
                    this.Groups.SequenceEqual(input.Groups)
                ) && 
                (
                    this.ServiceConfigurations == input.ServiceConfigurations ||
                    this.ServiceConfigurations != null &&
                    this.ServiceConfigurations.SequenceEqual(input.ServiceConfigurations)
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
                if (this.TenantName != null)
                    hashCode = hashCode * 59 + this.TenantName.GetHashCode();
                if (this.GroupDomain != null)
                    hashCode = hashCode * 59 + this.GroupDomain.GetHashCode();
                if (this.Groups != null)
                    hashCode = hashCode * 59 + this.Groups.GetHashCode();
                if (this.ServiceConfigurations != null)
                    hashCode = hashCode * 59 + this.ServiceConfigurations.GetHashCode();
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
