/* 
 * User Management
 *
 * Provides an API to:	 * Enumerate the user base	 * Create new users   * Gather specific user's information	 * Change a user's information	User information include things like:	* Whether or not the user account is `enabled` or not	* Username/password credentials as well as API keys   * Contact information such as `first_name`, `last_name`, `organization` and `email_address`	* Group membership - membership of a `group` is used to grant access to services and features	* Tenant membership - membership of a `tenant` is used to assign users specific `roles` in a organization	* Additional details - each user may have a collection of custom key-value pairs  For details about authentication, refer to the [authentication specification](/oauth/swagger.json).
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
	/// UserInformationRequest
	/// </summary>
	[DataContract]
	public partial class UserInformationRequest : IEquatable<UserInformationRequest>, IValidatableObject
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="UserInformationRequest" /> class.
		/// </summary>
		/// <param name="Username">Username.</param>
		/// <param name="EmailAddress">EmailAddress.</param>
		/// <param name="FirstName">The user&#39;s given/first name..</param>
		/// <param name="LastName">The user&#39;s last name..</param>
		/// <param name="Enabled">Allows setting the account&#39;s initial enabled state..</param>
		/// <param name="Password">Must conform the the password policy of the tenant..</param>
		/// <param name="Groups">A collection of currently existing groups that this user is to belong to..</param>
		/// <param name="Tenants">Defines the tenants that this user is a part of or has specific privileges against..</param>
		/// <param name="Origin">How or why the user was created..</param>
		/// <param name="AdditionalDetails">Additional details about the user..</param>
		/// <param name="ExtSub">url originating store of user.</param>
		public UserInformationRequest(string Username = default(string), string EmailAddress = default(string), string FirstName = default(string), string LastName = default(string), bool? Enabled = default(bool?), string Password = default(string), List<string> Groups = default(List<string>), Dictionary<string, TenantInformation> Tenants = default(Dictionary<string, TenantInformation>), string Origin = default(string), Object AdditionalDetails = default(Object), string ExtSub = default(string))
		{
			this.Username = Username;
			this.EmailAddress = EmailAddress;
			this.FirstName = FirstName;
			this.LastName = LastName;
			this.Enabled = Enabled;
			this.Password = Password;
			this.Groups = Groups;
			this.Tenants = Tenants;
			this.Origin = Origin;
			this.AdditionalDetails = AdditionalDetails;
			this.ExtSub = ExtSub;
		}
		
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
		/// The user&#39;s given/first name.
		/// </summary>
		/// <value>The user&#39;s given/first name.</value>
		[DataMember(Name="first_name", EmitDefaultValue=false)]
		public string FirstName { get; set; }

		/// <summary>
		/// The user&#39;s last name.
		/// </summary>
		/// <value>The user&#39;s last name.</value>
		[DataMember(Name="last_name", EmitDefaultValue=false)]
		public string LastName { get; set; }

		/// <summary>
		/// Allows setting the account&#39;s initial enabled state.
		/// </summary>
		/// <value>Allows setting the account&#39;s initial enabled state.</value>
		[DataMember(Name="enabled", EmitDefaultValue=false)]
		public bool? Enabled { get; set; }

		/// <summary>
		/// Must conform the the password policy of the tenant.
		/// </summary>
		/// <value>Must conform the the password policy of the tenant.</value>
		[DataMember(Name="password", EmitDefaultValue=false)]
		public string Password { get; set; }

		/// <summary>
		/// A collection of currently existing groups that this user is to belong to.
		/// </summary>
		/// <value>A collection of currently existing groups that this user is to belong to.</value>
		[DataMember(Name="groups", EmitDefaultValue=false)]
		public List<string> Groups { get; set; }

		/// <summary>
		/// Defines the tenants that this user is a part of or has specific privileges against.
		/// </summary>
		/// <value>Defines the tenants that this user is a part of or has specific privileges against.</value>
		[DataMember(Name="tenants", EmitDefaultValue=false)]
		public Dictionary<string, TenantInformation> Tenants { get; set; }

		/// <summary>
		/// How or why the user was created.
		/// </summary>
		/// <value>How or why the user was created.</value>
		[DataMember(Name="origin", EmitDefaultValue=false)]
		public string Origin { get; set; }

		/// <summary>
		/// Additional details about the user.
		/// </summary>
		/// <value>Additional details about the user.</value>
		[DataMember(Name="additional_details", EmitDefaultValue=false)]
		public Object AdditionalDetails { get; set; }

		/// <summary>
		/// url originating store of user
		/// </summary>
		/// <value>url originating store of user</value>
		[DataMember(Name="ext_sub", EmitDefaultValue=false)]
		public string ExtSub { get; set; }

		/// <summary>
		/// Returns the string presentation of the object
		/// </summary>
		/// <returns>String presentation of the object</returns>
		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.Append("class UserInformationRequest {\n");
			sb.Append("  Username: ").Append(Username).Append("\n");
			sb.Append("  EmailAddress: ").Append(EmailAddress).Append("\n");
			sb.Append("  FirstName: ").Append(FirstName).Append("\n");
			sb.Append("  LastName: ").Append(LastName).Append("\n");
			sb.Append("  Enabled: ").Append(Enabled).Append("\n");
			sb.Append("  Password: ").Append(Password).Append("\n");
			sb.Append("  Groups: ").Append(Groups).Append("\n");
			sb.Append("  Tenants: ").Append(Tenants).Append("\n");
			sb.Append("  Origin: ").Append(Origin).Append("\n");
			sb.Append("  AdditionalDetails: ").Append(AdditionalDetails).Append("\n");
			sb.Append("  ExtSub: ").Append(ExtSub).Append("\n");
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
			return this.Equals(input as UserInformationRequest);
		}

		/// <summary>
		/// Returns true if UserInformationRequest instances are equal
		/// </summary>
		/// <param name="input">Instance of UserInformationRequest to be compared</param>
		/// <returns>Boolean</returns>
		public bool Equals(UserInformationRequest input)
		{
			if (input == null)
				return false;

			return 
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
					this.Enabled == input.Enabled ||
					(this.Enabled != null &&
					this.Enabled.Equals(input.Enabled))
				) && 
				(
					this.Password == input.Password ||
					(this.Password != null &&
					this.Password.Equals(input.Password))
				) && 
				(
					this.Groups == input.Groups ||
					this.Groups != null &&
					this.Groups.SequenceEqual(input.Groups)
				) && 
				(
					this.Tenants == input.Tenants ||
					this.Tenants != null &&
					this.Tenants.SequenceEqual(input.Tenants)
				) && 
				(
					this.Origin == input.Origin ||
					(this.Origin != null &&
					this.Origin.Equals(input.Origin))
				) && 
				(
					this.AdditionalDetails == input.AdditionalDetails ||
					(this.AdditionalDetails != null &&
					this.AdditionalDetails.Equals(input.AdditionalDetails))
				) && 
				(
					this.ExtSub == input.ExtSub ||
					(this.ExtSub != null &&
					this.ExtSub.Equals(input.ExtSub))
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
				if (this.Username != null)
					hashCode = hashCode * 59 + this.Username.GetHashCode();
				if (this.EmailAddress != null)
					hashCode = hashCode * 59 + this.EmailAddress.GetHashCode();
				if (this.FirstName != null)
					hashCode = hashCode * 59 + this.FirstName.GetHashCode();
				if (this.LastName != null)
					hashCode = hashCode * 59 + this.LastName.GetHashCode();
				if (this.Enabled != null)
					hashCode = hashCode * 59 + this.Enabled.GetHashCode();
				if (this.Password != null)
					hashCode = hashCode * 59 + this.Password.GetHashCode();
				if (this.Groups != null)
					hashCode = hashCode * 59 + this.Groups.GetHashCode();
				if (this.Tenants != null)
					hashCode = hashCode * 59 + this.Tenants.GetHashCode();
				if (this.Origin != null)
					hashCode = hashCode * 59 + this.Origin.GetHashCode();
				if (this.AdditionalDetails != null)
					hashCode = hashCode * 59 + this.AdditionalDetails.GetHashCode();
				if (this.ExtSub != null)
					hashCode = hashCode * 59 + this.ExtSub.GetHashCode();
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
