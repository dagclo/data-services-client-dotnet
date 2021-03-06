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
	/// JobInformationResponseAssessmentMetricsRecordinfo
	/// </summary>
	[DataContract]
	public partial class JobInformationResponseAssessmentMetricsRecordinfo : IEquatable<JobInformationResponseAssessmentMetricsRecordinfo>, IValidatableObject
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="JobInformationResponseAssessmentMetricsRecordinfo" /> class.
		/// </summary>
		/// <param name="RecordCount">RecordCount.</param>
		/// <param name="BlankValues">BlankValues.</param>
		/// <param name="NullValues">NullValues.</param>
		public JobInformationResponseAssessmentMetricsRecordinfo(int? RecordCount = default(int?), int? BlankValues = default(int?), int? NullValues = default(int?))
		{
			this.RecordCount = RecordCount;
			this.BlankValues = BlankValues;
			this.NullValues = NullValues;
		}
		
		/// <summary>
		/// Gets or Sets RecordCount
		/// </summary>
		[DataMember(Name="record-count", EmitDefaultValue=false)]
		public int? RecordCount { get; set; }

		/// <summary>
		/// Gets or Sets BlankValues
		/// </summary>
		[DataMember(Name="blank-values", EmitDefaultValue=false)]
		public int? BlankValues { get; set; }

		/// <summary>
		/// Gets or Sets NullValues
		/// </summary>
		[DataMember(Name="null-values", EmitDefaultValue=false)]
		public int? NullValues { get; set; }

		/// <summary>
		/// Returns the string presentation of the object
		/// </summary>
		/// <returns>String presentation of the object</returns>
		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.Append("class JobInformationResponseAssessmentMetricsRecordinfo {\n");
			sb.Append("  RecordCount: ").Append(RecordCount).Append("\n");
			sb.Append("  BlankValues: ").Append(BlankValues).Append("\n");
			sb.Append("  NullValues: ").Append(NullValues).Append("\n");
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
			return this.Equals(input as JobInformationResponseAssessmentMetricsRecordinfo);
		}

		/// <summary>
		/// Returns true if JobInformationResponseAssessmentMetricsRecordinfo instances are equal
		/// </summary>
		/// <param name="input">Instance of JobInformationResponseAssessmentMetricsRecordinfo to be compared</param>
		/// <returns>Boolean</returns>
		public bool Equals(JobInformationResponseAssessmentMetricsRecordinfo input)
		{
			if (input == null)
				return false;

			return 
				(
					this.RecordCount == input.RecordCount ||
					(this.RecordCount != null &&
					this.RecordCount.Equals(input.RecordCount))
				) && 
				(
					this.BlankValues == input.BlankValues ||
					(this.BlankValues != null &&
					this.BlankValues.Equals(input.BlankValues))
				) && 
				(
					this.NullValues == input.NullValues ||
					(this.NullValues != null &&
					this.NullValues.Equals(input.NullValues))
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
				if (this.RecordCount != null)
					hashCode = hashCode * 59 + this.RecordCount.GetHashCode();
				if (this.BlankValues != null)
					hashCode = hashCode * 59 + this.BlankValues.GetHashCode();
				if (this.NullValues != null)
					hashCode = hashCode * 59 + this.NullValues.GetHashCode();
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
