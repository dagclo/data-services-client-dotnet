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
	/// Pricesheet
	/// </summary>
	[DataContract]
	public partial class Pricesheet : IEquatable<Pricesheet>, IValidatableObject
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="Pricesheet" /> class.
		/// </summary>
		/// <param name="FromDate">The start of the time frame these results fall within. If missing/null, the start of the time frame is the earliest item present..</param>
		/// <param name="ToDate">The end of the time frame these results fall withing. If missing/null, all items after the start of the time frame are included..</param>
		/// <param name="IncludesAllPrices">*When true*, the price sheet returned will contain expired and disabled price line items that fall within the result time frame. This allows the query to return the history of price changes for a particular service/tenant/user.  *When false*, only those items in effect at the end of the time frame will be present.  .</param>
		/// <param name="Tenant">The tenant the results are scoped to, if any.    *If null/missing*, pricing that pertains to any particular tenant are not included. .</param>
		/// <param name="UserId">The user the results are scoped to, if any.  *If null/missing*, pricing  pertaining to any particular user are not included. .</param>
		/// <param name="Services">Services.</param>
		public Pricesheet(DateTime? FromDate = default(DateTime?), DateTime? ToDate = default(DateTime?), bool? IncludesAllPrices = default(bool?), string Tenant = default(string), string UserId = default(string), List<Prices> Services = default(List<Prices>))
		{
			this.FromDate = FromDate;
			this.ToDate = ToDate;
			this.IncludesAllPrices = IncludesAllPrices;
			this.Tenant = Tenant;
			this.UserId = UserId;
			this.Services = Services;
		}

		/// <summary>
		/// The start of the time frame these results fall within. If missing/null, the start of the time frame is the earliest item present.
		/// </summary>
		/// <value>The start of the time frame these results fall within. If missing/null, the start of the time frame is the earliest item present.</value>
		[DataMember(Name = "from_date", EmitDefaultValue = false)]
		public DateTime? FromDate { get; set; }

		/// <summary>
		/// The end of the time frame these results fall withing. If missing/null, all items after the start of the time frame are included.
		/// </summary>
		/// <value>The end of the time frame these results fall withing. If missing/null, all items after the start of the time frame are included.</value>
		[DataMember(Name = "to_date", EmitDefaultValue = false)]
		public DateTime? ToDate { get; set; }

		/// <summary>
		/// *When true*, the price sheet returned will contain expired and disabled price line items that fall within the result time frame. This allows the query to return the history of price changes for a particular service/tenant/user.  *When false*, only those items in effect at the end of the time frame will be present.  
		/// </summary>
		/// <value>*When true*, the price sheet returned will contain expired and disabled price line items that fall within the result time frame. This allows the query to return the history of price changes for a particular service/tenant/user.  *When false*, only those items in effect at the end of the time frame will be present.  </value>
		[DataMember(Name = "includes_all_prices", EmitDefaultValue = false)]
		public bool? IncludesAllPrices { get; set; }

		/// <summary>
		/// The tenant the results are scoped to, if any.    *If null/missing*, pricing that pertains to any particular tenant are not included. 
		/// </summary>
		/// <value>The tenant the results are scoped to, if any.    *If null/missing*, pricing that pertains to any particular tenant are not included. </value>
		[DataMember(Name = "tenant", EmitDefaultValue = false)]
		public string Tenant { get; set; }

		/// <summary>
		/// The user the results are scoped to, if any.  *If null/missing*, pricing  pertaining to any particular user are not included. 
		/// </summary>
		/// <value>The user the results are scoped to, if any.  *If null/missing*, pricing  pertaining to any particular user are not included. </value>
		[DataMember(Name = "user_id", EmitDefaultValue = false)]
		public string UserId { get; set; }

		/// <summary>
		/// Gets or Sets Services
		/// </summary>
		[DataMember(Name = "services", EmitDefaultValue = false)]
		public List<Prices> Services { get; set; }

		/// <summary>
		/// Returns the string presentation of the object
		/// </summary>
		/// <returns>String presentation of the object</returns>
		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.Append("class Pricesheet {\n");
			sb.Append("  FromDate: ").Append(FromDate).Append("\n");
			sb.Append("  ToDate: ").Append(ToDate).Append("\n");
			sb.Append("  IncludesAllPrices: ").Append(IncludesAllPrices).Append("\n");
			sb.Append("  Tenant: ").Append(Tenant).Append("\n");
			sb.Append("  UserId: ").Append(UserId).Append("\n");
			sb.Append("  Services: ").Append(Services).Append("\n");
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
			return this.Equals(input as Pricesheet);
		}

		/// <summary>
		/// Returns true if Pricesheet instances are equal
		/// </summary>
		/// <param name="input">Instance of Pricesheet to be compared</param>
		/// <returns>Boolean</returns>
		public bool Equals(Pricesheet input)
		{
			if (input == null)
				return false;

			return
				(
					this.FromDate == input.FromDate ||
					(this.FromDate != null &&
					this.FromDate.Equals(input.FromDate))
				) &&
				(
					this.ToDate == input.ToDate ||
					(this.ToDate != null &&
					this.ToDate.Equals(input.ToDate))
				) &&
				(
					this.IncludesAllPrices == input.IncludesAllPrices ||
					(this.IncludesAllPrices != null &&
					this.IncludesAllPrices.Equals(input.IncludesAllPrices))
				) &&
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
					this.Services == input.Services ||
					this.Services != null &&
					this.Services.SequenceEqual(input.Services)
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
				if (this.FromDate != null)
					hashCode = hashCode * 59 + this.FromDate.GetHashCode();
				if (this.ToDate != null)
					hashCode = hashCode * 59 + this.ToDate.GetHashCode();
				if (this.IncludesAllPrices != null)
					hashCode = hashCode * 59 + this.IncludesAllPrices.GetHashCode();
				if (this.Tenant != null)
					hashCode = hashCode * 59 + this.Tenant.GetHashCode();
				if (this.UserId != null)
					hashCode = hashCode * 59 + this.UserId.GetHashCode();
				if (this.Services != null)
					hashCode = hashCode * 59 + this.Services.GetHashCode();
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
