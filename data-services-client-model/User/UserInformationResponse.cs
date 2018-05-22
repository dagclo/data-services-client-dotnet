/* 
 * User Management
 *
 * Provides an API to:   * Enumerate the user base   * Create new users   * Gather specific user's information   * Change a user's information  User information include things like:   * Whether or not the user account is `enabled` or not   * Username/password credentials as well as API keys   * Contact information such as `first_name`, `last_name`, `organization` and `email_address`   * Group membership - membership of a `group` is used to grant access to services and features   * Tenant membership - membership of a `tenant` is used to assign users specific `roles` in a organization   * Additional details - each user may have a collection of custom key-value pairs  For details about authentication, refer to the [authentication specification](/oauth/swagger.json).
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

namespace Quadient.DataServices.Model.User
{
    /// <summary>
    /// UserInformationResponse
    /// </summary>
    [DataContract]
    public partial class UserInformationResponse :  IEquatable<UserInformationResponse>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UserInformationResponse" /> class.
        /// </summary>
        /// <param name="UserId">The user_id of the user..</param>
        /// <param name="Uri">An href to the user resource..</param>
        /// <param name="FirstName">FirstName.</param>
        /// <param name="LastName">LastName.</param>
        /// <param name="Username">Username.</param>
        /// <param name="EmailAddress">EmailAddress.</param>
        /// <param name="Enabled">Enabled.</param>
        /// <param name="Groups">Groups this user belongs to..</param>
        /// <param name="ExtSub">url originating store of user.</param>
        /// <param name="Tenants">Defines the tenants that this user is a part of or has specific privileges against..</param>
        /// <param name="ServiceConfigurations">Defines the service_configurations that this user is a part of..</param>
        /// <param name="Origin">How or why the user was created..</param>
        /// <param name="CreatedBy">The user_id that created the user..</param>
        /// <param name="CreatedAt">The UTC time of creating the user..</param>
        /// <param name="LockOuts">LockOuts.</param>
        /// <param name="AdditionalDetails">Additional details about the user.</param>
        public UserInformationResponse(string UserId = default(string), string Uri = default(string), string FirstName = default(string), string LastName = default(string), string Username = default(string), string EmailAddress = default(string), bool? Enabled = default(bool?), List<string> Groups = default(List<string>), string ExtSub = default(string), Dictionary<string, TenantInformation> Tenants = default(Dictionary<string, TenantInformation>), Dictionary<string, TenantInformation> ServiceConfigurations = default(Dictionary<string, TenantInformation>), string Origin = default(string), string CreatedBy = default(string), DateTime? CreatedAt = default(DateTime?), List<LockOutInformation> LockOuts = default(List<LockOutInformation>), Object AdditionalDetails = default(Object))
        {
            this.UserId = UserId;
            this.Uri = Uri;
            this.FirstName = FirstName;
            this.LastName = LastName;
            this.Username = Username;
            this.EmailAddress = EmailAddress;
            this.Enabled = Enabled;
            this.Groups = Groups;
            this.ExtSub = ExtSub;
            this.Tenants = Tenants;
            this.ServiceConfigurations = ServiceConfigurations;
            this.Origin = Origin;
            this.CreatedBy = CreatedBy;
            this.CreatedAt = CreatedAt;
            this.LockOuts = LockOuts;
            this.AdditionalDetails = AdditionalDetails;
        }
        
        /// <summary>
        /// The user_id of the user.
        /// </summary>
        /// <value>The user_id of the user.</value>
        [DataMember(Name="user_id", EmitDefaultValue=false)]
        public string UserId { get; set; }

        /// <summary>
        /// An href to the user resource.
        /// </summary>
        /// <value>An href to the user resource.</value>
        [DataMember(Name="uri", EmitDefaultValue=false)]
        public string Uri { get; set; }

        /// <summary>
        /// Gets or Sets FirstName
        /// </summary>
        [DataMember(Name="first_name", EmitDefaultValue=false)]
        public string FirstName { get; set; }

        /// <summary>
        /// Gets or Sets LastName
        /// </summary>
        [DataMember(Name="last_name", EmitDefaultValue=false)]
        public string LastName { get; set; }

        /// <summary>
        /// Gets or Sets Username
        /// </summary>
        [DataMember(Name="username", EmitDefaultValue=false)]
        public string Username { get; set; }

        /// <summary>
        /// Gets or Sets EmailAddress
        /// </summary>
        [DataMember(Name="email_address", EmitDefaultValue=false)]
        public string EmailAddress { get; set; }

        /// <summary>
        /// Gets or Sets Enabled
        /// </summary>
        [DataMember(Name="enabled", EmitDefaultValue=false)]
        public bool? Enabled { get; set; }

        /// <summary>
        /// Groups this user belongs to.
        /// </summary>
        /// <value>Groups this user belongs to.</value>
        [DataMember(Name="groups", EmitDefaultValue=false)]
        public List<string> Groups { get; set; }

        /// <summary>
        /// url originating store of user
        /// </summary>
        /// <value>url originating store of user</value>
        [DataMember(Name="ext_sub", EmitDefaultValue=false)]
        public string ExtSub { get; set; }

        /// <summary>
        /// Defines the tenants that this user is a part of or has specific privileges against.
        /// </summary>
        /// <value>Defines the tenants that this user is a part of or has specific privileges against.</value>
        [DataMember(Name="tenants", EmitDefaultValue=false)]
        public Dictionary<string, TenantInformation> Tenants { get; set; }

        /// <summary>
        /// Defines the service_configurations that this user is a part of.
        /// </summary>
        /// <value>Defines the service_configurations that this user is a part of.</value>
        [DataMember(Name="service_configurations", EmitDefaultValue=false)]
        public Dictionary<string, TenantInformation> ServiceConfigurations { get; set; }

        /// <summary>
        /// How or why the user was created.
        /// </summary>
        /// <value>How or why the user was created.</value>
        [DataMember(Name="origin", EmitDefaultValue=false)]
        public string Origin { get; set; }

        /// <summary>
        /// The user_id that created the user.
        /// </summary>
        /// <value>The user_id that created the user.</value>
        [DataMember(Name="created_by", EmitDefaultValue=false)]
        public string CreatedBy { get; set; }

        /// <summary>
        /// The UTC time of creating the user.
        /// </summary>
        /// <value>The UTC time of creating the user.</value>
        [DataMember(Name="created_at", EmitDefaultValue=false)]
        public DateTime? CreatedAt { get; set; }

        /// <summary>
        /// Gets or Sets LockOuts
        /// </summary>
        [DataMember(Name="lock_outs", EmitDefaultValue=false)]
        public List<LockOutInformation> LockOuts { get; set; }

        /// <summary>
        /// Additional details about the user
        /// </summary>
        /// <value>Additional details about the user</value>
        [DataMember(Name="additional_details", EmitDefaultValue=false)]
        public Object AdditionalDetails { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UserInformationResponse {\n");
            sb.Append("  UserId: ").Append(UserId).Append("\n");
            sb.Append("  Uri: ").Append(Uri).Append("\n");
            sb.Append("  FirstName: ").Append(FirstName).Append("\n");
            sb.Append("  LastName: ").Append(LastName).Append("\n");
            sb.Append("  Username: ").Append(Username).Append("\n");
            sb.Append("  EmailAddress: ").Append(EmailAddress).Append("\n");
            sb.Append("  Enabled: ").Append(Enabled).Append("\n");
            sb.Append("  Groups: ").Append(Groups).Append("\n");
            sb.Append("  ExtSub: ").Append(ExtSub).Append("\n");
            sb.Append("  Tenants: ").Append(Tenants).Append("\n");
            sb.Append("  ServiceConfigurations: ").Append(ServiceConfigurations).Append("\n");
            sb.Append("  Origin: ").Append(Origin).Append("\n");
            sb.Append("  CreatedBy: ").Append(CreatedBy).Append("\n");
            sb.Append("  CreatedAt: ").Append(CreatedAt).Append("\n");
            sb.Append("  LockOuts: ").Append(LockOuts).Append("\n");
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
            return this.Equals(input as UserInformationResponse);
        }

        /// <summary>
        /// Returns true if UserInformationResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of UserInformationResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(UserInformationResponse input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.UserId == input.UserId ||
                    (this.UserId != null &&
                    this.UserId.Equals(input.UserId))
                ) && 
                (
                    this.Uri == input.Uri ||
                    (this.Uri != null &&
                    this.Uri.Equals(input.Uri))
                ) && 
                (
                    this.FirstName == input.FirstName ||
                    (this.FirstName != null &&
                    this.FirstName.Equals(input.FirstName))
                ) && 
                (
                    this.LastName == input.LastName ||
                    (this.LastName != null &&
                    this.LastName.Equals(input.LastName))
                ) && 
                (
                    this.Username == input.Username ||
                    (this.Username != null &&
                    this.Username.Equals(input.Username))
                ) && 
                (
                    this.EmailAddress == input.EmailAddress ||
                    (this.EmailAddress != null &&
                    this.EmailAddress.Equals(input.EmailAddress))
                ) && 
                (
                    this.Enabled == input.Enabled ||
                    (this.Enabled != null &&
                    this.Enabled.Equals(input.Enabled))
                ) && 
                (
                    this.Groups == input.Groups ||
                    this.Groups != null &&
                    this.Groups.SequenceEqual(input.Groups)
                ) && 
                (
                    this.ExtSub == input.ExtSub ||
                    (this.ExtSub != null &&
                    this.ExtSub.Equals(input.ExtSub))
                ) && 
                (
                    this.Tenants == input.Tenants ||
                    this.Tenants != null &&
                    this.Tenants.SequenceEqual(input.Tenants)
                ) && 
                (
                    this.ServiceConfigurations == input.ServiceConfigurations ||
                    this.ServiceConfigurations != null &&
                    this.ServiceConfigurations.SequenceEqual(input.ServiceConfigurations)
                ) && 
                (
                    this.Origin == input.Origin ||
                    (this.Origin != null &&
                    this.Origin.Equals(input.Origin))
                ) && 
                (
                    this.CreatedBy == input.CreatedBy ||
                    (this.CreatedBy != null &&
                    this.CreatedBy.Equals(input.CreatedBy))
                ) && 
                (
                    this.CreatedAt == input.CreatedAt ||
                    (this.CreatedAt != null &&
                    this.CreatedAt.Equals(input.CreatedAt))
                ) && 
                (
                    this.LockOuts == input.LockOuts ||
                    this.LockOuts != null &&
                    this.LockOuts.SequenceEqual(input.LockOuts)
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
                if (this.UserId != null)
                    hashCode = hashCode * 59 + this.UserId.GetHashCode();
                if (this.Uri != null)
                    hashCode = hashCode * 59 + this.Uri.GetHashCode();
                if (this.FirstName != null)
                    hashCode = hashCode * 59 + this.FirstName.GetHashCode();
                if (this.LastName != null)
                    hashCode = hashCode * 59 + this.LastName.GetHashCode();
                if (this.Username != null)
                    hashCode = hashCode * 59 + this.Username.GetHashCode();
                if (this.EmailAddress != null)
                    hashCode = hashCode * 59 + this.EmailAddress.GetHashCode();
                if (this.Enabled != null)
                    hashCode = hashCode * 59 + this.Enabled.GetHashCode();
                if (this.Groups != null)
                    hashCode = hashCode * 59 + this.Groups.GetHashCode();
                if (this.ExtSub != null)
                    hashCode = hashCode * 59 + this.ExtSub.GetHashCode();
                if (this.Tenants != null)
                    hashCode = hashCode * 59 + this.Tenants.GetHashCode();
                if (this.ServiceConfigurations != null)
                    hashCode = hashCode * 59 + this.ServiceConfigurations.GetHashCode();
                if (this.Origin != null)
                    hashCode = hashCode * 59 + this.Origin.GetHashCode();
                if (this.CreatedBy != null)
                    hashCode = hashCode * 59 + this.CreatedBy.GetHashCode();
                if (this.CreatedAt != null)
                    hashCode = hashCode * 59 + this.CreatedAt.GetHashCode();
                if (this.LockOuts != null)
                    hashCode = hashCode * 59 + this.LockOuts.GetHashCode();
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
        IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }

}
