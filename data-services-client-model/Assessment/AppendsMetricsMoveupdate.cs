/* 
 * Data Quality Assessment
 *
 * Allows users to assess the Quadient Data Services before buying. This service runs assessment jobs based on real data, but does not give back the records that have been corrected. Rather, it provides \"assessment metrics\" which can be used to determine and explain the value of using Data Services. 
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
using SwaggerDateConverter = Quadient.DataServices.Model.Client.SwaggerDateConverter;

namespace Quadient.DataServices.Model.Assessment
{
	/// <summary>
	/// AppendsMetricsMoveupdate
	/// </summary>
	[DataContract]
	public partial class AppendsMetricsMoveupdate : IEquatable<AppendsMetricsMoveupdate>, IValidatableObject
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="AppendsMetricsMoveupdate" /> class.
		/// </summary>
		/// <param name="Count">Number of records processed with the Move Update registry.</param>
		/// <param name="NoMatch">Number of records that did not match the Move Update registry.</param>
		/// <param name="MovedAway">Number of records that had a match in the Move Update registry but the new address is not known.</param>
		/// <param name="NewAddress">Number of records that had a match in the Move Update registry with a new address.</param>
		public AppendsMetricsMoveupdate(int? Count = default(int?), int? NoMatch = default(int?), int? MovedAway = default(int?), int? NewAddress = default(int?))
		{
			this.Count = Count;
			this.NoMatch = NoMatch;
			this.MovedAway = MovedAway;
			this.NewAddress = NewAddress;
		}
		
		/// <summary>
		/// Number of records processed with the Move Update registry
		/// </summary>
		/// <value>Number of records processed with the Move Update registry</value>
		[DataMember(Name="count", EmitDefaultValue=false)]
		public int? Count { get; set; }

		/// <summary>
		/// Number of records that did not match the Move Update registry
		/// </summary>
		/// <value>Number of records that did not match the Move Update registry</value>
		[DataMember(Name="no_match", EmitDefaultValue=false)]
		public int? NoMatch { get; set; }

		/// <summary>
		/// Number of records that had a match in the Move Update registry but the new address is not known
		/// </summary>
		/// <value>Number of records that had a match in the Move Update registry but the new address is not known</value>
		[DataMember(Name="moved_away", EmitDefaultValue=false)]
		public int? MovedAway { get; set; }

		/// <summary>
		/// Number of records that had a match in the Move Update registry with a new address
		/// </summary>
		/// <value>Number of records that had a match in the Move Update registry with a new address</value>
		[DataMember(Name="new_address", EmitDefaultValue=false)]
		public int? NewAddress { get; set; }

		/// <summary>
		/// Returns the string presentation of the object
		/// </summary>
		/// <returns>String presentation of the object</returns>
		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.Append("class AppendsMetricsMoveupdate {\n");
			sb.Append("  Count: ").Append(Count).Append("\n");
			sb.Append("  NoMatch: ").Append(NoMatch).Append("\n");
			sb.Append("  MovedAway: ").Append(MovedAway).Append("\n");
			sb.Append("  NewAddress: ").Append(NewAddress).Append("\n");
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
			return this.Equals(input as AppendsMetricsMoveupdate);
		}

		/// <summary>
		/// Returns true if AppendsMetricsMoveupdate instances are equal
		/// </summary>
		/// <param name="input">Instance of AppendsMetricsMoveupdate to be compared</param>
		/// <returns>Boolean</returns>
		public bool Equals(AppendsMetricsMoveupdate input)
		{
			if (input == null)
				return false;

			return 
				(
					this.Count == input.Count ||
					(this.Count != null &&
					this.Count.Equals(input.Count))
				) && 
				(
					this.NoMatch == input.NoMatch ||
					(this.NoMatch != null &&
					this.NoMatch.Equals(input.NoMatch))
				) && 
				(
					this.MovedAway == input.MovedAway ||
					(this.MovedAway != null &&
					this.MovedAway.Equals(input.MovedAway))
				) && 
				(
					this.NewAddress == input.NewAddress ||
					(this.NewAddress != null &&
					this.NewAddress.Equals(input.NewAddress))
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
				if (this.Count != null)
					hashCode = hashCode * 59 + this.Count.GetHashCode();
				if (this.NoMatch != null)
					hashCode = hashCode * 59 + this.NoMatch.GetHashCode();
				if (this.MovedAway != null)
					hashCode = hashCode * 59 + this.MovedAway.GetHashCode();
				if (this.NewAddress != null)
					hashCode = hashCode * 59 + this.NewAddress.GetHashCode();
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
