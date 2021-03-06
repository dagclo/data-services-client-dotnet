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
	/// PriceTotal
	/// </summary>
	[DataContract]
	public partial class PriceTotal : IEquatable<PriceTotal>, IValidatableObject
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="PriceTotal" /> class.
		/// </summary>
		/// <param name="Amount">The total price of this estimate or calculation.</param>
		/// <param name="Currency">The currency type used in this esimate or calculation.</param>
		/// <param name="ServiceError">Indicates an error with generating a price for this service..</param>
		/// <param name="UnknownTiers">Indicates tier paths that didn&#39;t match any prices..</param>
		public PriceTotal(decimal? Amount = default(decimal?), string Currency = default(string), string ServiceError = default(string), List<string> UnknownTiers = default(List<string>))
		{
			this.Amount = Amount;
			this.Currency = Currency;
			this.ServiceError = ServiceError;
			this.UnknownTiers = UnknownTiers;
		}
		
		/// <summary>
		/// The total price of this estimate or calculation
		/// </summary>
		/// <value>The total price of this estimate or calculation</value>
		[DataMember(Name="amount", EmitDefaultValue=false)]
		public decimal? Amount { get; set; }

		/// <summary>
		/// The currency type used in this esimate or calculation
		/// </summary>
		/// <value>The currency type used in this esimate or calculation</value>
		[DataMember(Name="currency", EmitDefaultValue=false)]
		public string Currency { get; set; }

		/// <summary>
		/// Indicates an error with generating a price for this service.
		/// </summary>
		/// <value>Indicates an error with generating a price for this service.</value>
		[DataMember(Name="service_error", EmitDefaultValue=false)]
		public string ServiceError { get; set; }

		/// <summary>
		/// Indicates tier paths that didn&#39;t match any prices.
		/// </summary>
		/// <value>Indicates tier paths that didn&#39;t match any prices.</value>
		[DataMember(Name="unknown_tiers", EmitDefaultValue=false)]
		public List<string> UnknownTiers { get; set; }

		/// <summary>
		/// Returns the string presentation of the object
		/// </summary>
		/// <returns>String presentation of the object</returns>
		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.Append("class PriceTotal {\n");
			sb.Append("  Amount: ").Append(Amount).Append("\n");
			sb.Append("  Currency: ").Append(Currency).Append("\n");
			sb.Append("  ServiceError: ").Append(ServiceError).Append("\n");
			sb.Append("  UnknownTiers: ").Append(UnknownTiers).Append("\n");
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
			return this.Equals(input as PriceTotal);
		}

		/// <summary>
		/// Returns true if PriceTotal instances are equal
		/// </summary>
		/// <param name="input">Instance of PriceTotal to be compared</param>
		/// <returns>Boolean</returns>
		public bool Equals(PriceTotal input)
		{
			if (input == null)
				return false;

			return 
				(
					this.Amount == input.Amount ||
					(this.Amount != null &&
					this.Amount.Equals(input.Amount))
				) && 
				(
					this.Currency == input.Currency ||
					(this.Currency != null &&
					this.Currency.Equals(input.Currency))
				) && 
				(
					this.ServiceError == input.ServiceError ||
					(this.ServiceError != null &&
					this.ServiceError.Equals(input.ServiceError))
				) && 
				(
					this.UnknownTiers == input.UnknownTiers ||
					this.UnknownTiers != null &&
					this.UnknownTiers.SequenceEqual(input.UnknownTiers)
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
				if (this.Amount != null)
					hashCode = hashCode * 59 + this.Amount.GetHashCode();
				if (this.Currency != null)
					hashCode = hashCode * 59 + this.Currency.GetHashCode();
				if (this.ServiceError != null)
					hashCode = hashCode * 59 + this.ServiceError.GetHashCode();
				if (this.UnknownTiers != null)
					hashCode = hashCode * 59 + this.UnknownTiers.GetHashCode();
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
