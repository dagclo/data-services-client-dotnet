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
	/// JobInformationResponseAssessmentMetricsAddresscorrection
	/// </summary>
	[DataContract]
	public partial class JobInformationResponseAssessmentMetricsAddresscorrection : IEquatable<JobInformationResponseAssessmentMetricsAddresscorrection>, IValidatableObject
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="JobInformationResponseAssessmentMetricsAddresscorrection" /> class.
		/// </summary>
		/// <param name="Count">Count.</param>
		/// <param name="Geocodes">Geocodes.</param>
		/// <param name="Category">Category.</param>
		public JobInformationResponseAssessmentMetricsAddresscorrection(int? Count = default(int?), JobInformationResponseAssessmentMetricsAddresscorrectionGeocodes Geocodes = default(JobInformationResponseAssessmentMetricsAddresscorrectionGeocodes), CategoryMetrics Category = default(CategoryMetrics))
		{
			this.Count = Count;
			this.Geocodes = Geocodes;
			this.Category = Category;
		}
		
		/// <summary>
		/// Gets or Sets Count
		/// </summary>
		[DataMember(Name="count", EmitDefaultValue=false)]
		public int? Count { get; set; }

		/// <summary>
		/// Gets or Sets Geocodes
		/// </summary>
		[DataMember(Name="geocodes", EmitDefaultValue=false)]
		public JobInformationResponseAssessmentMetricsAddresscorrectionGeocodes Geocodes { get; set; }

		/// <summary>
		/// Gets or Sets Category
		/// </summary>
		[DataMember(Name="category", EmitDefaultValue=false)]
		public CategoryMetrics Category { get; set; }

		/// <summary>
		/// Returns the string presentation of the object
		/// </summary>
		/// <returns>String presentation of the object</returns>
		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.Append("class JobInformationResponseAssessmentMetricsAddresscorrection {\n");
			sb.Append("  Count: ").Append(Count).Append("\n");
			sb.Append("  Geocodes: ").Append(Geocodes).Append("\n");
			sb.Append("  Category: ").Append(Category).Append("\n");
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
			return this.Equals(input as JobInformationResponseAssessmentMetricsAddresscorrection);
		}

		/// <summary>
		/// Returns true if JobInformationResponseAssessmentMetricsAddresscorrection instances are equal
		/// </summary>
		/// <param name="input">Instance of JobInformationResponseAssessmentMetricsAddresscorrection to be compared</param>
		/// <returns>Boolean</returns>
		public bool Equals(JobInformationResponseAssessmentMetricsAddresscorrection input)
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
					this.Geocodes == input.Geocodes ||
					(this.Geocodes != null &&
					this.Geocodes.Equals(input.Geocodes))
				) && 
				(
					this.Category == input.Category ||
					(this.Category != null &&
					this.Category.Equals(input.Category))
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
				if (this.Geocodes != null)
					hashCode = hashCode * 59 + this.Geocodes.GetHashCode();
				if (this.Category != null)
					hashCode = hashCode * 59 + this.Category.GetHashCode();
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
