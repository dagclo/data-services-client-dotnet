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
	/// MeteringDetails
	/// </summary>
	[DataContract]
	public partial class MeteringDetails : IEquatable<MeteringDetails>, IValidatableObject
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="MeteringDetails" /> class.
		/// </summary>
		/// <param name="Tenant">(Optional) The tenant doing the work. Any tenant-specific pricing rules will be factored into the calculation..</param>
		/// <param name="UserId">(Optional) The user doing the work. Any user-specific pricing rules will be factored into the calculation..</param>
		/// <param name="UseStrict">Indicate whether strict validation should be used. Strict validation will reject unknown services. (default to true).</param>
		/// <param name="ServiceUse">ServiceUse.</param>
		public MeteringDetails(string Tenant = default(string), string UserId = default(string), bool? UseStrict = true, Dictionary<string, Object> ServiceUse = default(Dictionary<string, Object>))
		{
			this.Tenant = Tenant;
			this.UserId = UserId;
			// use default value if no "UseStrict" provided
			if (UseStrict == null)
			{
				this.UseStrict = true;
			}
			else
			{
				this.UseStrict = UseStrict;
			}
			this.ServiceUse = ServiceUse;
		}
		
		/// <summary>
		/// (Optional) The tenant doing the work. Any tenant-specific pricing rules will be factored into the calculation.
		/// </summary>
		/// <value>(Optional) The tenant doing the work. Any tenant-specific pricing rules will be factored into the calculation.</value>
		[DataMember(Name="tenant", EmitDefaultValue=false)]
		public string Tenant { get; set; }

		/// <summary>
		/// (Optional) The user doing the work. Any user-specific pricing rules will be factored into the calculation.
		/// </summary>
		/// <value>(Optional) The user doing the work. Any user-specific pricing rules will be factored into the calculation.</value>
		[DataMember(Name="user_id", EmitDefaultValue=false)]
		public string UserId { get; set; }

		/// <summary>
		/// Indicate whether strict validation should be used. Strict validation will reject unknown services.
		/// </summary>
		/// <value>Indicate whether strict validation should be used. Strict validation will reject unknown services.</value>
		[DataMember(Name="use_strict", EmitDefaultValue=false)]
		public bool? UseStrict { get; set; }

		/// <summary>
		/// Gets or Sets ServiceUse
		/// </summary>
		[DataMember(Name="service_use", EmitDefaultValue=false)]
		public Dictionary<string, Object> ServiceUse { get; set; }

		/// <summary>
		/// Returns the string presentation of the object
		/// </summary>
		/// <returns>String presentation of the object</returns>
		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.Append("class MeteringDetails {\n");
			sb.Append("  Tenant: ").Append(Tenant).Append("\n");
			sb.Append("  UserId: ").Append(UserId).Append("\n");
			sb.Append("  UseStrict: ").Append(UseStrict).Append("\n");
			sb.Append("  ServiceUse: ").Append(ServiceUse).Append("\n");
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
			return this.Equals(input as MeteringDetails);
		}

		/// <summary>
		/// Returns true if MeteringDetails instances are equal
		/// </summary>
		/// <param name="input">Instance of MeteringDetails to be compared</param>
		/// <returns>Boolean</returns>
		public bool Equals(MeteringDetails input)
		{
			if (input == null)
				return false;

			return 
				(
					this.Tenant == input.Tenant ||
					(this.Tenant != null &&
					this.Tenant.Equals(input.Tenant))
				) && 
				(
					this.UserId == input.UserId ||
					(this.UserId != null &&
					this.UserId.Equals(input.UserId))
				) && 
				(
					this.UseStrict == input.UseStrict ||
					(this.UseStrict != null &&
					this.UseStrict.Equals(input.UseStrict))
				) && 
				(
					this.ServiceUse == input.ServiceUse ||
					this.ServiceUse != null &&
					this.ServiceUse.SequenceEqual(input.ServiceUse)
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
				if (this.Tenant != null)
					hashCode = hashCode * 59 + this.Tenant.GetHashCode();
				if (this.UserId != null)
					hashCode = hashCode * 59 + this.UserId.GetHashCode();
				if (this.UseStrict != null)
					hashCode = hashCode * 59 + this.UseStrict.GetHashCode();
				if (this.ServiceUse != null)
					hashCode = hashCode * 59 + this.ServiceUse.GetHashCode();
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
