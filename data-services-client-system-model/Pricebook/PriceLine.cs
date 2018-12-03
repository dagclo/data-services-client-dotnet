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
using SwaggerDateConverter = Quadient.DataServices.System.Model.Client.SwaggerDateConverter;

namespace Quadient.DataServices.System.Model.Pricebook
{
    /// <summary>
    /// PriceLine
    /// </summary>
    [DataContract]
    public partial class PriceLine : IEquatable<PriceLine>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PriceLine" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected PriceLine() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="PriceLine" /> class.
        /// </summary>
        /// <param name="Name">The tier name of the price line item. (required).</param>
        /// <param name="Tenant">(Optional) Identifies the tenant this adjustment applies to..</param>
        /// <param name="UserId">(Optional) Identify a user id this price applies to..</param>
        /// <param name="IncludeInEstimates">Should this price-line item be factored into estimated price calculations?.</param>
        /// <param name="PricePerUnit">The price of this line item..</param>
        /// <param name="Currency">The currency of the price.</param>
        /// <param name="RecordsPerUnit">The number of records that make up 1 unit..</param>
        /// <param name="FloorPricePerUnit">The minimum price per unit possible, after applying discount..</param>
        /// <param name="PercentDiscount">A % discount applied to the effective base price..</param>
        /// <param name="Enabled">Is this price currently active? Prices may be disabled, overriding their time frame of effectivness..</param>
        /// <param name="OverrideRemaining">When an estimate request includes tier specifications, this indicates that the remainder of *count - specifiedTiersTotal* should be used. This will be true in cases where the tiers are expected to be mutually exclusive..</param>
        /// <param name="TimeFrame">TimeFrame.</param>
        /// <param name="Id">The unique id of this item..</param>
        /// <param name="Deleted">Has this price been deleted?.</param>
        public PriceLine(string Name = default(string), string Tenant = default(string), string UserId = default(string), bool? IncludeInEstimates = default(bool?), decimal? PricePerUnit = default(decimal?), string Currency = default(string), decimal? RecordsPerUnit = default(decimal?), decimal? FloorPricePerUnit = default(decimal?), decimal? PercentDiscount = default(decimal?), bool? Enabled = default(bool?), bool? OverrideRemaining = default(bool?), TimeFrame TimeFrame = default(TimeFrame), string Id = default(string), bool? Deleted = default(bool?))
        {
            // to ensure "Name" is required (not null)
            if (Name == null)
            {
                throw new InvalidDataException("Name is a required property for PriceLine and cannot be null");
            }
            else
            {
                this.Name = Name;
            }
            this.Tenant = Tenant;
            this.UserId = UserId;
            this.IncludeInEstimates = IncludeInEstimates;
            this.PricePerUnit = PricePerUnit;
            this.Currency = Currency;
            this.RecordsPerUnit = RecordsPerUnit;
            this.FloorPricePerUnit = FloorPricePerUnit;
            this.PercentDiscount = PercentDiscount;
            this.Enabled = Enabled;
            this.OverrideRemaining = OverrideRemaining;
            this.TimeFrame = TimeFrame;
            this.Id = Id;
            this.Deleted = Deleted;
        }

        /// <summary>
        /// The tier name of the price line item.
        /// </summary>
        /// <value>The tier name of the price line item.</value>
        [DataMember(Name = "name", EmitDefaultValue = false)]
        public string Name { get; set; }

        /// <summary>
        /// (Optional) Identifies the tenant this adjustment applies to.
        /// </summary>
        /// <value>(Optional) Identifies the tenant this adjustment applies to.</value>
        [DataMember(Name = "tenant", EmitDefaultValue = false)]
        public string Tenant { get; set; }

        /// <summary>
        /// (Optional) Identify a user id this price applies to.
        /// </summary>
        /// <value>(Optional) Identify a user id this price applies to.</value>
        [DataMember(Name = "user_id", EmitDefaultValue = false)]
        public string UserId { get; set; }

        /// <summary>
        /// Should this price-line item be factored into estimated price calculations?
        /// </summary>
        /// <value>Should this price-line item be factored into estimated price calculations?</value>
        [DataMember(Name = "include_in_estimates", EmitDefaultValue = false)]
        public bool? IncludeInEstimates { get; set; }

        /// <summary>
        /// The price of this line item.
        /// </summary>
        /// <value>The price of this line item.</value>
        [DataMember(Name = "price_per_unit", EmitDefaultValue = false)]
        public decimal? PricePerUnit { get; set; }

        /// <summary>
        /// The currency of the price
        /// </summary>
        /// <value>The currency of the price</value>
        [DataMember(Name = "currency", EmitDefaultValue = false)]
        public string Currency { get; set; }

        /// <summary>
        /// The number of records that make up 1 unit.
        /// </summary>
        /// <value>The number of records that make up 1 unit.</value>
        [DataMember(Name = "records_per_unit", EmitDefaultValue = false)]
        public decimal? RecordsPerUnit { get; set; }

        /// <summary>
        /// The minimum price per unit possible, after applying discount.
        /// </summary>
        /// <value>The minimum price per unit possible, after applying discount.</value>
        [DataMember(Name = "floor_price_per_unit", EmitDefaultValue = false)]
        public decimal? FloorPricePerUnit { get; set; }

        /// <summary>
        /// A % discount applied to the effective base price.
        /// </summary>
        /// <value>A % discount applied to the effective base price.</value>
        [DataMember(Name = "percent_discount", EmitDefaultValue = false)]
        public decimal? PercentDiscount { get; set; }

        /// <summary>
        /// Is this price currently active? Prices may be disabled, overriding their time frame of effectivness.
        /// </summary>
        /// <value>Is this price currently active? Prices may be disabled, overriding their time frame of effectivness.</value>
        [DataMember(Name = "enabled", EmitDefaultValue = false)]
        public bool? Enabled { get; set; }

        /// <summary>
        /// When an estimate request includes tier specifications, this indicates that the remainder of *count - specifiedTiersTotal* should be used. This will be true in cases where the tiers are expected to be mutually exclusive.
        /// </summary>
        /// <value>When an estimate request includes tier specifications, this indicates that the remainder of *count - specifiedTiersTotal* should be used. This will be true in cases where the tiers are expected to be mutually exclusive.</value>
        [DataMember(Name = "override_remaining", EmitDefaultValue = false)]
        public bool? OverrideRemaining { get; set; }

        /// <summary>
        /// Gets or Sets TimeFrame
        /// </summary>
        [DataMember(Name = "time_frame", EmitDefaultValue = false)]
        public TimeFrame TimeFrame { get; set; }

        /// <summary>
        /// The unique id of this item.
        /// </summary>
        /// <value>The unique id of this item.</value>
        [DataMember(Name = "id", EmitDefaultValue = false)]
        public string Id { get; set; }

        /// <summary>
        /// Has this price been deleted?
        /// </summary>
        /// <value>Has this price been deleted?</value>
        [DataMember(Name = "deleted", EmitDefaultValue = false)]
        public bool? Deleted { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PriceLine {\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Tenant: ").Append(Tenant).Append("\n");
            sb.Append("  UserId: ").Append(UserId).Append("\n");
            sb.Append("  IncludeInEstimates: ").Append(IncludeInEstimates).Append("\n");
            sb.Append("  PricePerUnit: ").Append(PricePerUnit).Append("\n");
            sb.Append("  Currency: ").Append(Currency).Append("\n");
            sb.Append("  RecordsPerUnit: ").Append(RecordsPerUnit).Append("\n");
            sb.Append("  FloorPricePerUnit: ").Append(FloorPricePerUnit).Append("\n");
            sb.Append("  PercentDiscount: ").Append(PercentDiscount).Append("\n");
            sb.Append("  Enabled: ").Append(Enabled).Append("\n");
            sb.Append("  OverrideRemaining: ").Append(OverrideRemaining).Append("\n");
            sb.Append("  TimeFrame: ").Append(TimeFrame).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Deleted: ").Append(Deleted).Append("\n");
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
            return this.Equals(input as PriceLine);
        }

        /// <summary>
        /// Returns true if PriceLine instances are equal
        /// </summary>
        /// <param name="input">Instance of PriceLine to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PriceLine input)
        {
            if (input == null)
                return false;

            return
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
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
                    this.IncludeInEstimates == input.IncludeInEstimates ||
                    (this.IncludeInEstimates != null &&
                    this.IncludeInEstimates.Equals(input.IncludeInEstimates))
                ) &&
                (
                    this.PricePerUnit == input.PricePerUnit ||
                    (this.PricePerUnit != null &&
                    this.PricePerUnit.Equals(input.PricePerUnit))
                ) &&
                (
                    this.Currency == input.Currency ||
                    (this.Currency != null &&
                    this.Currency.Equals(input.Currency))
                ) &&
                (
                    this.RecordsPerUnit == input.RecordsPerUnit ||
                    (this.RecordsPerUnit != null &&
                    this.RecordsPerUnit.Equals(input.RecordsPerUnit))
                ) &&
                (
                    this.FloorPricePerUnit == input.FloorPricePerUnit ||
                    (this.FloorPricePerUnit != null &&
                    this.FloorPricePerUnit.Equals(input.FloorPricePerUnit))
                ) &&
                (
                    this.PercentDiscount == input.PercentDiscount ||
                    (this.PercentDiscount != null &&
                    this.PercentDiscount.Equals(input.PercentDiscount))
                ) &&
                (
                    this.Enabled == input.Enabled ||
                    (this.Enabled != null &&
                    this.Enabled.Equals(input.Enabled))
                ) &&
                (
                    this.OverrideRemaining == input.OverrideRemaining ||
                    (this.OverrideRemaining != null &&
                    this.OverrideRemaining.Equals(input.OverrideRemaining))
                ) &&
                (
                    this.TimeFrame == input.TimeFrame ||
                    (this.TimeFrame != null &&
                    this.TimeFrame.Equals(input.TimeFrame))
                ) &&
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) &&
                (
                    this.Deleted == input.Deleted ||
                    (this.Deleted != null &&
                    this.Deleted.Equals(input.Deleted))
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
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.Tenant != null)
                    hashCode = hashCode * 59 + this.Tenant.GetHashCode();
                if (this.UserId != null)
                    hashCode = hashCode * 59 + this.UserId.GetHashCode();
                if (this.IncludeInEstimates != null)
                    hashCode = hashCode * 59 + this.IncludeInEstimates.GetHashCode();
                if (this.PricePerUnit != null)
                    hashCode = hashCode * 59 + this.PricePerUnit.GetHashCode();
                if (this.Currency != null)
                    hashCode = hashCode * 59 + this.Currency.GetHashCode();
                if (this.RecordsPerUnit != null)
                    hashCode = hashCode * 59 + this.RecordsPerUnit.GetHashCode();
                if (this.FloorPricePerUnit != null)
                    hashCode = hashCode * 59 + this.FloorPricePerUnit.GetHashCode();
                if (this.PercentDiscount != null)
                    hashCode = hashCode * 59 + this.PercentDiscount.GetHashCode();
                if (this.Enabled != null)
                    hashCode = hashCode * 59 + this.Enabled.GetHashCode();
                if (this.OverrideRemaining != null)
                    hashCode = hashCode * 59 + this.OverrideRemaining.GetHashCode();
                if (this.TimeFrame != null)
                    hashCode = hashCode * 59 + this.TimeFrame.GetHashCode();
                if (this.Id != null)
                    hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.Deleted != null)
                    hashCode = hashCode * 59 + this.Deleted.GetHashCode();
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
