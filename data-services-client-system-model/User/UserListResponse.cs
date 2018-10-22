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
    /// A collection of user summaries. The list will be empty if no matching users are found or if the search criteria are not specific enough (ie. the &#39;enabled&#39; parameter is not specific enough).
    /// </summary>
    [DataContract]
    public partial class UserListResponse : IEquatable<UserListResponse>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UserListResponse" /> class.
        /// </summary>
        /// <param name="Total">The total number of users found. If no search criteria is set, this will represent the total count of users in the database..</param>
        /// <param name="Limit">The number of users requested.</param>
        /// <param name="FirstPage">A relative URL to the first page of users based on limit and offset if it exists.</param>
        /// <param name="NextPage">A relative URL to the next page of users based on limit and offset if it exists.</param>
        /// <param name="PreviousPage">A relative URL to the previous page of users based on limit and offset if it exists.</param>
        /// <param name="LastPage">A relative URL to the last page of users based on limit and offset if it exists.</param>
        /// <param name="Users">Users.</param>
        public UserListResponse(int? Total = default(int?), int? Limit = default(int?), string FirstPage = default(string), string NextPage = default(string), string PreviousPage = default(string), string LastPage = default(string), List<Usersummary> Users = default(List<Usersummary>))
        {
            this.Total = Total;
            this.Limit = Limit;
            this.FirstPage = FirstPage;
            this.NextPage = NextPage;
            this.PreviousPage = PreviousPage;
            this.LastPage = LastPage;
            this.Users = Users;
        }
        
        /// <summary>
        /// The total number of users found. If no search criteria is set, this will represent the total count of users in the database.
        /// </summary>
        /// <value>The total number of users found. If no search criteria is set, this will represent the total count of users in the database.</value>
        [DataMember(Name="total", EmitDefaultValue=false)]
        public int? Total { get; set; }

        /// <summary>
        /// The number of users requested
        /// </summary>
        /// <value>The number of users requested</value>
        [DataMember(Name="limit", EmitDefaultValue=false)]
        public int? Limit { get; set; }

        /// <summary>
        /// A relative URL to the first page of users based on limit and offset if it exists
        /// </summary>
        /// <value>A relative URL to the first page of users based on limit and offset if it exists</value>
        [DataMember(Name="first_page", EmitDefaultValue=false)]
        public string FirstPage { get; set; }

        /// <summary>
        /// A relative URL to the next page of users based on limit and offset if it exists
        /// </summary>
        /// <value>A relative URL to the next page of users based on limit and offset if it exists</value>
        [DataMember(Name="next_page", EmitDefaultValue=false)]
        public string NextPage { get; set; }

        /// <summary>
        /// A relative URL to the previous page of users based on limit and offset if it exists
        /// </summary>
        /// <value>A relative URL to the previous page of users based on limit and offset if it exists</value>
        [DataMember(Name="previous_page", EmitDefaultValue=false)]
        public string PreviousPage { get; set; }

        /// <summary>
        /// A relative URL to the last page of users based on limit and offset if it exists
        /// </summary>
        /// <value>A relative URL to the last page of users based on limit and offset if it exists</value>
        [DataMember(Name="last_page", EmitDefaultValue=false)]
        public string LastPage { get; set; }

        /// <summary>
        /// Gets or Sets Users
        /// </summary>
        [DataMember(Name="users", EmitDefaultValue=false)]
        public List<Usersummary> Users { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UserListResponse {\n");
            sb.Append("  Total: ").Append(Total).Append("\n");
            sb.Append("  Limit: ").Append(Limit).Append("\n");
            sb.Append("  FirstPage: ").Append(FirstPage).Append("\n");
            sb.Append("  NextPage: ").Append(NextPage).Append("\n");
            sb.Append("  PreviousPage: ").Append(PreviousPage).Append("\n");
            sb.Append("  LastPage: ").Append(LastPage).Append("\n");
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
            return this.Equals(input as UserListResponse);
        }

        /// <summary>
        /// Returns true if UserListResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of UserListResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(UserListResponse input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Total == input.Total ||
                    (this.Total != null &&
                    this.Total.Equals(input.Total))
                ) && 
                (
                    this.Limit == input.Limit ||
                    (this.Limit != null &&
                    this.Limit.Equals(input.Limit))
                ) && 
                (
                    this.FirstPage == input.FirstPage ||
                    (this.FirstPage != null &&
                    this.FirstPage.Equals(input.FirstPage))
                ) && 
                (
                    this.NextPage == input.NextPage ||
                    (this.NextPage != null &&
                    this.NextPage.Equals(input.NextPage))
                ) && 
                (
                    this.PreviousPage == input.PreviousPage ||
                    (this.PreviousPage != null &&
                    this.PreviousPage.Equals(input.PreviousPage))
                ) && 
                (
                    this.LastPage == input.LastPage ||
                    (this.LastPage != null &&
                    this.LastPage.Equals(input.LastPage))
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
                if (this.Total != null)
                    hashCode = hashCode * 59 + this.Total.GetHashCode();
                if (this.Limit != null)
                    hashCode = hashCode * 59 + this.Limit.GetHashCode();
                if (this.FirstPage != null)
                    hashCode = hashCode * 59 + this.FirstPage.GetHashCode();
                if (this.NextPage != null)
                    hashCode = hashCode * 59 + this.NextPage.GetHashCode();
                if (this.PreviousPage != null)
                    hashCode = hashCode * 59 + this.PreviousPage.GetHashCode();
                if (this.LastPage != null)
                    hashCode = hashCode * 59 + this.LastPage.GetHashCode();
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
        IEnumerable<ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }

}
