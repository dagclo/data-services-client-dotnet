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
	/// AuthResponse
	/// </summary>
	[DataContract]
	public partial class AuthResponse : IEquatable<AuthResponse>, IValidatableObject
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="AuthResponse" /> class.
		/// </summary>
		/// <param name="AccessToken">the jwt.</param>
		/// <param name="ExpiresIn">the lifetime in seconds of the access token.</param>
		public AuthResponse(string AccessToken = default(string), decimal? ExpiresIn = default(decimal?))
		{
			this.AccessToken = AccessToken;
			this.ExpiresIn = ExpiresIn;
		}
		
		/// <summary>
		/// the jwt
		/// </summary>
		/// <value>the jwt</value>
		[DataMember(Name="access_token", EmitDefaultValue=false)]
		public string AccessToken { get; set; }

		/// <summary>
		/// the lifetime in seconds of the access token
		/// </summary>
		/// <value>the lifetime in seconds of the access token</value>
		[DataMember(Name="expires_in", EmitDefaultValue=false)]
		public decimal? ExpiresIn { get; set; }

		/// <summary>
		/// Returns the string presentation of the object
		/// </summary>
		/// <returns>String presentation of the object</returns>
		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.Append("class AuthResponse {\n");
			sb.Append("  AccessToken: ").Append(AccessToken).Append("\n");
			sb.Append("  ExpiresIn: ").Append(ExpiresIn).Append("\n");
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
			return this.Equals(input as AuthResponse);
		}

		/// <summary>
		/// Returns true if AuthResponse instances are equal
		/// </summary>
		/// <param name="input">Instance of AuthResponse to be compared</param>
		/// <returns>Boolean</returns>
		public bool Equals(AuthResponse input)
		{
			if (input == null)
				return false;

			return 
				(
					this.AccessToken == input.AccessToken ||
					(this.AccessToken != null &&
					this.AccessToken.Equals(input.AccessToken))
				) && 
				(
					this.ExpiresIn == input.ExpiresIn ||
					(this.ExpiresIn != null &&
					this.ExpiresIn.Equals(input.ExpiresIn))
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
				if (this.AccessToken != null)
					hashCode = hashCode * 59 + this.AccessToken.GetHashCode();
				if (this.ExpiresIn != null)
					hashCode = hashCode * 59 + this.ExpiresIn.GetHashCode();
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
