/* 
 * User Management
 *
 * Provides an API to:   * Enumerate the user base   * Create new users   * Gather specific user's information   * Change a user's information  User information include things like:   * Whether or not the user account is `enabled` or not   * Username/password credentials as well as API keys   * Contact information such as `first_name`, `last_name`, `organization` and `email_address`   * Group membership - membership of a `group` is used to grant access to services and features   * Tenant membership - membership of a `tenant` is used to assign users specific `roles` in a organization   * Additional details - each user may have a collection of custom key-value pairs  For details about authentication, refer to the [authentication specification](/oauth/swagger.json).
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
	/// ServiceConfigurationListingResponse
	/// </summary>
	[DataContract]
	public partial class ServiceConfigurationListingResponse : IEquatable<ServiceConfigurationListingResponse>, IValidatableObject
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="ServiceConfigurationListingResponse" /> class.
		/// </summary>
		/// <param name="ServiceConfigurations">A list of all existing service configurations..</param>
		public ServiceConfigurationListingResponse(List<ServiceConfigurationItem> ServiceConfigurations = default(List<ServiceConfigurationItem>))
		{
			this.ServiceConfigurations = ServiceConfigurations;
		}

		/// <summary>
		/// A list of all existing service configurations.
		/// </summary>
		/// <value>A list of all existing service configurations.</value>
		[DataMember(Name = "service_configurations", EmitDefaultValue = false)]
		public List<ServiceConfigurationItem> ServiceConfigurations { get; set; }

		/// <summary>
		/// Returns the string presentation of the object
		/// </summary>
		/// <returns>String presentation of the object</returns>
		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.Append("class ServiceConfigurationListingResponse {\n");
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
			return this.Equals(input as ServiceConfigurationListingResponse);
		}

		/// <summary>
		/// Returns true if ServiceConfigurationListingResponse instances are equal
		/// </summary>
		/// <param name="input">Instance of ServiceConfigurationListingResponse to be compared</param>
		/// <returns>Boolean</returns>
		public bool Equals(ServiceConfigurationListingResponse input)
		{
			if (input == null)
				return false;

			return
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
