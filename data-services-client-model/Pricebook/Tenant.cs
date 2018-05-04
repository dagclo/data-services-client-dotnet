/* 
 * Pricebook Management
 *
 * No description provided (generated by Swagger Codegen https://github.com/swagger-api/swagger-codegen)
 *
 * OpenAPI spec version: 0.1
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

namespace Quadient.DataServices.Model
{
    /// <summary>
    /// Tenant
    /// </summary>
    [DataContract]
    public partial class Tenant :  IEquatable<Tenant>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Tenant" /> class.
        /// </summary>
        /// <param name="TenantName">TenantName.</param>
        /// <param name="Users">Users.</param>
        public Tenant(string TenantName = default(string), List<string> Users = default(List<string>))
        {
            this.TenantName = TenantName;
            this.Users = Users;
        }
        
        /// <summary>
        /// Gets or Sets TenantName
        /// </summary>
        [DataMember(Name="tenant_name", EmitDefaultValue=false)]
        public string TenantName { get; set; }

        /// <summary>
        /// Gets or Sets Users
        /// </summary>
        [DataMember(Name="users", EmitDefaultValue=false)]
        public List<string> Users { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Tenant {\n");
            sb.Append("  TenantName: ").Append(TenantName).Append("\n");
            sb.Append("  Users: ").Append(Users).Append("\n");
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
            return this.Equals(input as Tenant);
        }

        /// <summary>
        /// Returns true if Tenant instances are equal
        /// </summary>
        /// <param name="input">Instance of Tenant to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Tenant input)
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
                    this.Users == input.Users ||
                    this.Users != null &&
                    this.Users.SequenceEqual(input.Users)
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
                if (this.Users != null)
                    hashCode = hashCode * 59 + this.Users.GetHashCode();
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
