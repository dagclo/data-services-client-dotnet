/* 
 * User Management
 *
 * Provides an API to:   * Enumerate the user base   * Create new users   * Gather specific user's information   * Change a user's information  User information include things like:   * Whether or not the user account is `enabled` or not   * Username/password credentials as well as API keys   * Contact information such as `first_name`, `last_name`, `organization` and `email_address`   * Group membership - membership of a `group` is used to grant access to services and features   * Tenant membership - membership of a `tenant` is used to assign users specific `roles` in a organization   * Additional details - each user may have a collection of custom key-value pairs  For details about authentication, refer to the [authentication specification](/oauth/swagger.json).
 *
 * OpenAPI spec version: 1.1.37
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
    /// ApiKeyInformation
    /// </summary>
    [DataContract]
    public partial class ApiKeyInformation : IEquatable<ApiKeyInformation>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ApiKeyInformation" /> class.
        /// </summary>
        /// <param name="Id">The public ID of this API key.</param>
        /// <param name="Secret">The API key secret.</param>
        /// <param name="Enabled">Whether or not this API key is currently enabled/active.</param>
        public ApiKeyInformation(string Id = default(string), string Secret = default(string), bool? Enabled = default(bool?))
        {
            this.Id = Id;
            this.Secret = Secret;
            this.Enabled = Enabled;
        }
        
        /// <summary>
        /// The public ID of this API key
        /// </summary>
        /// <value>The public ID of this API key</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; set; }

        /// <summary>
        /// The API key secret
        /// </summary>
        /// <value>The API key secret</value>
        [DataMember(Name="secret", EmitDefaultValue=false)]
        public string Secret { get; set; }

        /// <summary>
        /// Whether or not this API key is currently enabled/active
        /// </summary>
        /// <value>Whether or not this API key is currently enabled/active</value>
        [DataMember(Name="enabled", EmitDefaultValue=false)]
        public bool? Enabled { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ApiKeyInformation {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Secret: ").Append(Secret).Append("\n");
            sb.Append("  Enabled: ").Append(Enabled).Append("\n");
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
            return this.Equals(input as ApiKeyInformation);
        }

        /// <summary>
        /// Returns true if ApiKeyInformation instances are equal
        /// </summary>
        /// <param name="input">Instance of ApiKeyInformation to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ApiKeyInformation input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
                (
                    this.Secret == input.Secret ||
                    (this.Secret != null &&
                    this.Secret.Equals(input.Secret))
                ) && 
                (
                    this.Enabled == input.Enabled ||
                    (this.Enabled != null &&
                    this.Enabled.Equals(input.Enabled))
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
                if (this.Id != null)
                    hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.Secret != null)
                    hashCode = hashCode * 59 + this.Secret.GetHashCode();
                if (this.Enabled != null)
                    hashCode = hashCode * 59 + this.Enabled.GetHashCode();
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
