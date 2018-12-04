/* 
 * US Move Update
 *
 * The US Move Update service offers the ability to update addresses of persons and organizations who have moved within the United States.	## Job execution  The general flow to execute a batch job is to:  1. Create a job, specifying its configuration properties, and upload and download schema (input fields and output fields). You cannot change the job's configuration after creation.	2. Upload records to process via one or more calls to the `/jobs/{job_id}/records` endpoint. Records are uploaded in blocks. The records are stored on the server for processing.  3. Initiate processing by calling the `/jobs/{job_id}/_run` endpoint. 4. Wait for the job status to be updated to `SUCCESS` or `FAILED`. 5. Download the records. 6. Delete job when you are done by requesting a `DELETE` on the `/jobs/{job_id}` endpoint, which removes both input and output records.  ## Records  The upload of records must be complete prior to running the service. Records are categorized as `input` or `output`. The schema (fields and order) of the records is defined via the job creation call.  ## Pagination Records for a job are broken into pages (`page_id`) for retrieval. The collection of record page IDs is available via the `/jobs/{job_id}/records/pages` endpoint. Retrieve this collection as a precursor to downloading records. Each record page can then be retrieved by the client. Page IDs are immutable and can be retrieved in parallel. Record pages may also be retrieved multiple times if needed.  ## Outcome codes `move_update_outcome_codes` - - One or more of the following, space separated, are possible : * `A1` - Address verified, move lookup performed. * `E1` - Address not verified, no move lookup performed. * `C1` - Individual move  ## Outcome category `move_update_outcome_category` - possible values are: * `No change` - No move was found for the address. * `New address` - A move was found and returned. 
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
	/// MoveUpdateJobCreationRequest
	/// </summary>
	[DataContract]
	public partial class MoveUpdateJobCreationRequest : IEquatable<MoveUpdateJobCreationRequest>, IValidatableObject
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="MoveUpdateJobCreationRequest" /> class.
		/// </summary>
		/// <param name="ParentJob">The job ID of the parent job. .</param>
		/// <param name="Configuration">Configuration.</param>
		/// <param name="InputFields">InputFields.</param>
		/// <param name="OutputFields">OutputFields.</param>
		public MoveUpdateJobCreationRequest(string ParentJob = default(string), MoveUpdateConfiguration Configuration = default(MoveUpdateConfiguration), List<MoveUpdateInputField> InputFields = default(List<MoveUpdateInputField>), List<MoveUpdateOutputField> OutputFields = default(List<MoveUpdateOutputField>))
		{
			this.ParentJob = ParentJob;
			this.Configuration = Configuration;
			this.InputFields = InputFields;
			this.OutputFields = OutputFields;
		}
		
		/// <summary>
		/// The job ID of the parent job. 
		/// </summary>
		/// <value>The job ID of the parent job. </value>
		[DataMember(Name="parent_job", EmitDefaultValue=false)]
		public string ParentJob { get; set; }

		/// <summary>
		/// Gets or Sets Configuration
		/// </summary>
		[DataMember(Name="configuration", EmitDefaultValue=false)]
		public MoveUpdateConfiguration Configuration { get; set; }

		/// <summary>
		/// Gets or Sets InputFields
		/// </summary>
		[DataMember(Name="input_fields", EmitDefaultValue=false)]
		public List<MoveUpdateInputField> InputFields { get; set; }

		/// <summary>
		/// Gets or Sets OutputFields
		/// </summary>
		[DataMember(Name="output_fields", EmitDefaultValue=false)]
		public List<MoveUpdateOutputField> OutputFields { get; set; }

		/// <summary>
		/// Returns the string presentation of the object
		/// </summary>
		/// <returns>String presentation of the object</returns>
		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.Append("class MoveUpdateJobCreationRequest {\n");
			sb.Append("  ParentJob: ").Append(ParentJob).Append("\n");
			sb.Append("  Configuration: ").Append(Configuration).Append("\n");
			sb.Append("  InputFields: ").Append(InputFields).Append("\n");
			sb.Append("  OutputFields: ").Append(OutputFields).Append("\n");
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
			return this.Equals(input as MoveUpdateJobCreationRequest);
		}

		/// <summary>
		/// Returns true if MoveUpdateJobCreationRequest instances are equal
		/// </summary>
		/// <param name="input">Instance of MoveUpdateJobCreationRequest to be compared</param>
		/// <returns>Boolean</returns>
		public bool Equals(MoveUpdateJobCreationRequest input)
		{
			if (input == null)
				return false;

			return 
				(
					this.ParentJob == input.ParentJob ||
					(this.ParentJob != null &&
					this.ParentJob.Equals(input.ParentJob))
				) && 
				(
					this.Configuration == input.Configuration ||
					(this.Configuration != null &&
					this.Configuration.Equals(input.Configuration))
				) && 
				(
					this.InputFields == input.InputFields ||
					this.InputFields != null &&
					this.InputFields.SequenceEqual(input.InputFields)
				) && 
				(
					this.OutputFields == input.OutputFields ||
					this.OutputFields != null &&
					this.OutputFields.SequenceEqual(input.OutputFields)
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
				if (this.ParentJob != null)
					hashCode = hashCode * 59 + this.ParentJob.GetHashCode();
				if (this.Configuration != null)
					hashCode = hashCode * 59 + this.Configuration.GetHashCode();
				if (this.InputFields != null)
					hashCode = hashCode * 59 + this.InputFields.GetHashCode();
				if (this.OutputFields != null)
					hashCode = hashCode * 59 + this.OutputFields.GetHashCode();
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
