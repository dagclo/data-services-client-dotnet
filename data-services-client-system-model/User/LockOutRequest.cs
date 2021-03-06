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
	/// LockOutRequest
	/// </summary>
	[DataContract]
	public partial class LockOutRequest : IEquatable<LockOutRequest>, IValidatableObject
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="LockOutRequest" /> class.
		/// </summary>
		/// <param name="Services">Services.</param>
		/// <param name="LockOut">true to lock.  false to unlock..</param>
		/// <param name="Reason">reason why user is being locked out.</param>
		public LockOutRequest(List<string> Services = default(List<string>), bool? LockOut = default(bool?), string Reason = default(string))
		{
			this.Services = Services;
			this.LockOut = LockOut;
			this.Reason = Reason;
		}
		
		/// <summary>
		/// Gets or Sets Services
		/// </summary>
		[DataMember(Name="services", EmitDefaultValue=false)]
		public List<string> Services { get; set; }

		/// <summary>
		/// true to lock.  false to unlock.
		/// </summary>
		/// <value>true to lock.  false to unlock.</value>
		[DataMember(Name="lock_out", EmitDefaultValue=false)]
		public bool? LockOut { get; set; }

		/// <summary>
		/// reason why user is being locked out
		/// </summary>
		/// <value>reason why user is being locked out</value>
		[DataMember(Name="reason", EmitDefaultValue=false)]
		public string Reason { get; set; }

		/// <summary>
		/// Returns the string presentation of the object
		/// </summary>
		/// <returns>String presentation of the object</returns>
		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.Append("class LockOutRequest {\n");
			sb.Append("  Services: ").Append(Services).Append("\n");
			sb.Append("  LockOut: ").Append(LockOut).Append("\n");
			sb.Append("  Reason: ").Append(Reason).Append("\n");
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
			return this.Equals(input as LockOutRequest);
		}

		/// <summary>
		/// Returns true if LockOutRequest instances are equal
		/// </summary>
		/// <param name="input">Instance of LockOutRequest to be compared</param>
		/// <returns>Boolean</returns>
		public bool Equals(LockOutRequest input)
		{
			if (input == null)
				return false;

			return 
				(
					this.Services == input.Services ||
					this.Services != null &&
					this.Services.SequenceEqual(input.Services)
				) && 
				(
					this.LockOut == input.LockOut ||
					(this.LockOut != null &&
					this.LockOut.Equals(input.LockOut))
				) && 
				(
					this.Reason == input.Reason ||
					(this.Reason != null &&
					this.Reason.Equals(input.Reason))
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
				if (this.Services != null)
					hashCode = hashCode * 59 + this.Services.GetHashCode();
				if (this.LockOut != null)
					hashCode = hashCode * 59 + this.LockOut.GetHashCode();
				if (this.Reason != null)
					hashCode = hashCode * 59 + this.Reason.GetHashCode();
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
