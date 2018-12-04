/* 
 * Pricebook Management
 *
 * No description provided (generated by Swagger Codegen https://github.com/swagger-api/swagger-codegen)
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

namespace Quadient.DataServices.System.Model.Pricebook
{
	/// <summary>
	/// TenantEnumeration
	/// </summary>
	[DataContract]
	public partial class TenantEnumeration : IEquatable<TenantEnumeration>, IValidatableObject
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="TenantEnumeration" /> class.
		/// </summary>
		/// <param name="Tenants">Tenants.</param>
		public TenantEnumeration(List<Tenant> Tenants = default(List<Tenant>))
		{
			this.Tenants = Tenants;
		}

		/// <summary>
		/// Gets or Sets Tenants
		/// </summary>
		[DataMember(Name = "tenants", EmitDefaultValue = false)]
		public List<Tenant> Tenants { get; set; }

		/// <summary>
		/// Returns the string presentation of the object
		/// </summary>
		/// <returns>String presentation of the object</returns>
		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.Append("class TenantEnumeration {\n");
			sb.Append("  Tenants: ").Append(Tenants).Append("\n");
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
			return this.Equals(input as TenantEnumeration);
		}

		/// <summary>
		/// Returns true if TenantEnumeration instances are equal
		/// </summary>
		/// <param name="input">Instance of TenantEnumeration to be compared</param>
		/// <returns>Boolean</returns>
		public bool Equals(TenantEnumeration input)
		{
			if (input == null)
				return false;

			return
				(
					this.Tenants == input.Tenants ||
					this.Tenants != null &&
					this.Tenants.SequenceEqual(input.Tenants)
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
				if (this.Tenants != null)
					hashCode = hashCode * 59 + this.Tenants.GetHashCode();
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
