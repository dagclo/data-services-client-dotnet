/* 
 * Walk Sequence
 *
 * The Walk Sequence service performs USPS® CASS™ processing and appends USPS Walk Sequence numbers to mail pieces. Mailings that target specific ZIP Codes or neighborhoods are good candidates for the Walk Sequence service.	A mailing that is sorted in Walk Sequence order may qualify for USPS High Density and Saturation mailing discounts. Adding Walk Sqeunce data to mailings can lower your postage costs.	## Job execution  The general flow to execute a batch job is to:  1. Create a job, specifying its configuration properties, and upload and download schema (input fields and output fields). You cannot change the job's configuration after creation.	2. Upload the records you want to process via one or more calls to the `/jobs/{job_id}/records` endpoint. Records are uploaded in blocks. The records are stored on the server for processing.	3. Initiate processing by calling the `/jobs/{job_id}/_run` endpoint. 4. Wait for the job status to be updated to `SUCCESS` or `FAILED`. 5. Download the records. 6. Delete the job when you are done by requesting a `DELETE` on the `/jobs/{job_id}` endpoint, which removes both the input and output records.  ## Records  The upload of records must be complete prior to running the service. Records are categorized as `input` or `output`. The schema (fields and order) of the records is defined via the job creation call.	## Pagination Records for a job are broken into pages (`page_id`) for retrieval. The collection of record page IDs is available via the `/jobs/{job_id}/records/pages` endpoint. Retrieve this collection as a precursor to downloading records. Each record page can then be retrieved by the client. Page IDs are immutable and can be retrieved in parallel. Record pages may also be retrieved multiple times if needed. 
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

namespace Quadient.DataServices.Model.UsBatch
{
	/// <summary>
	/// JobSummaryCollection
	/// </summary>
	[DataContract]
	public partial class JobSummaryCollection : IEquatable<JobSummaryCollection>, IValidatableObject
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="JobSummaryCollection" /> class.
		/// </summary>
		/// <param name="Jobs">Jobs.</param>
		public JobSummaryCollection(List<JobSummary> Jobs = default(List<JobSummary>))
		{
			this.Jobs = Jobs;
		}
		
		/// <summary>
		/// Gets or Sets Jobs
		/// </summary>
		[DataMember(Name="jobs", EmitDefaultValue=false)]
		public List<JobSummary> Jobs { get; set; }

		/// <summary>
		/// Returns the string presentation of the object
		/// </summary>
		/// <returns>String presentation of the object</returns>
		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.Append("class JobSummaryCollection {\n");
			sb.Append("  Jobs: ").Append(Jobs).Append("\n");
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
			return this.Equals(input as JobSummaryCollection);
		}

		/// <summary>
		/// Returns true if JobSummaryCollection instances are equal
		/// </summary>
		/// <param name="input">Instance of JobSummaryCollection to be compared</param>
		/// <returns>Boolean</returns>
		public bool Equals(JobSummaryCollection input)
		{
			if (input == null)
				return false;

			return 
				(
					this.Jobs == input.Jobs ||
					this.Jobs != null &&
					this.Jobs.SequenceEqual(input.Jobs)
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
				if (this.Jobs != null)
					hashCode = hashCode * 59 + this.Jobs.GetHashCode();
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
