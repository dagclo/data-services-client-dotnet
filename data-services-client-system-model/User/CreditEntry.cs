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
    /// CreditEntry
    /// </summary>
    [DataContract]
    public partial class CreditEntry : IEquatable<CreditEntry>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CreditEntry" /> class.
        /// </summary>
        /// <param name="Value">value of this transaction.</param>
        /// <param name="FiledDate">date of the transaction.</param>
        /// <param name="BillingTransactionId">reference id provided by billing.</param>
        public CreditEntry(decimal? Value = default(decimal?), DateTime? FiledDate = default(DateTime?), string BillingTransactionId = default(string))
        {
            this.Value = Value;
            this.FiledDate = FiledDate;
            this.BillingTransactionId = BillingTransactionId;
        }

        /// <summary>
        /// value of this transaction
        /// </summary>
        /// <value>value of this transaction</value>
        [DataMember(Name = "value", EmitDefaultValue = false)]
        public decimal? Value { get; set; }

        /// <summary>
        /// date of the transaction
        /// </summary>
        /// <value>date of the transaction</value>
        [DataMember(Name = "filed_date", EmitDefaultValue = false)]
        public DateTime? FiledDate { get; set; }

        /// <summary>
        /// reference id provided by billing
        /// </summary>
        /// <value>reference id provided by billing</value>
        [DataMember(Name = "billing_transaction_id", EmitDefaultValue = false)]
        public string BillingTransactionId { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CreditEntry {\n");
            sb.Append("  Value: ").Append(Value).Append("\n");
            sb.Append("  FiledDate: ").Append(FiledDate).Append("\n");
            sb.Append("  BillingTransactionId: ").Append(BillingTransactionId).Append("\n");
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
            return this.Equals(input as CreditEntry);
        }

        /// <summary>
        /// Returns true if CreditEntry instances are equal
        /// </summary>
        /// <param name="input">Instance of CreditEntry to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CreditEntry input)
        {
            if (input == null)
                return false;

            return
                (
                    this.Value == input.Value ||
                    (this.Value != null &&
                    this.Value.Equals(input.Value))
                ) &&
                (
                    this.FiledDate == input.FiledDate ||
                    (this.FiledDate != null &&
                    this.FiledDate.Equals(input.FiledDate))
                ) &&
                (
                    this.BillingTransactionId == input.BillingTransactionId ||
                    (this.BillingTransactionId != null &&
                    this.BillingTransactionId.Equals(input.BillingTransactionId))
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
                if (this.Value != null)
                    hashCode = hashCode * 59 + this.Value.GetHashCode();
                if (this.FiledDate != null)
                    hashCode = hashCode * 59 + this.FiledDate.GetHashCode();
                if (this.BillingTransactionId != null)
                    hashCode = hashCode * 59 + this.BillingTransactionId.GetHashCode();
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
