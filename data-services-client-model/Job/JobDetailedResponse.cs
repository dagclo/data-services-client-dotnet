using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace Quadient.DataServices.Model.Job {

  /// <summary>
  /// 
  /// </summary>
  [DataContract]
  public class JobDetailedResponse : JobInformationResponse {
    /// <summary>
    /// Any additional details pertaining to the most recent job status change
    /// </summary>
    /// <value>Any additional details pertaining to the most recent job status change</value>
    [DataMember(Name="job_status_details", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "job_status_details")]
    public Object JobStatusDetails { get; set; }

    /// <summary>
    /// The user_id of the user who created the job.
    /// </summary>
    /// <value>The user_id of the user who created the job.</value>
    [DataMember(Name="created_by", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "created_by")]
    public string CreatedBy { get; set; }

    /// <summary>
    /// The time of job creation
    /// </summary>
    /// <value>The time of job creation</value>
    [DataMember(Name="created_at", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "created_at")]
    public DateTime? CreatedAt { get; set; }

    /// <summary>
    /// The last time of updating the job
    /// </summary>
    /// <value>The last time of updating the job</value>
    [DataMember(Name="updated_at", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "updated_at")]
    public DateTime? UpdatedAt { get; set; }

    /// <summary>
    /// An array of the expected services that this job will be consuming, referred to by their service_id.
    /// </summary>
    /// <value>An array of the expected services that this job will be consuming, referred to by their service_id.</value>
    [DataMember(Name="expected_services", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "expected_services")]
    public List<string> ExpectedServices { get; set; }

    /// <summary>
    /// The expected amount of records that will be processed by the `expected_services` in this job
    /// </summary>
    /// <value>The expected amount of records that will be processed by the `expected_services` in this job</value>
    [DataMember(Name="expected_record_count", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "expected_record_count")]
    public long? ExpectedRecordCount { get; set; }

    /// <summary>
    /// Any additional details about the job.
    /// </summary>
    /// <value>Any additional details about the job.</value>
    [DataMember(Name="additional_details", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "additional_details")]
    public Object AdditionalDetails { get; set; }

    /// <summary>
    /// Gets or Sets Usage
    /// </summary>
    [DataMember(Name="usage", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "usage")]
    public UsageAggregation Usage { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class JobDetailedResponse {\n");
      sb.Append("  JobStatusDetails: ").Append(JobStatusDetails).Append("\n");
      sb.Append("  CreatedBy: ").Append(CreatedBy).Append("\n");
      sb.Append("  CreatedAt: ").Append(CreatedAt).Append("\n");
      sb.Append("  UpdatedAt: ").Append(UpdatedAt).Append("\n");
      sb.Append("  ExpectedServices: ").Append(ExpectedServices).Append("\n");
      sb.Append("  ExpectedRecordCount: ").Append(ExpectedRecordCount).Append("\n");
      sb.Append("  AdditionalDetails: ").Append(AdditionalDetails).Append("\n");
      sb.Append("  Usage: ").Append(Usage).Append("\n");
      sb.Append("}\n");
      return sb.ToString();
    }

    /// <summary>
    /// Get the JSON string presentation of the object
    /// </summary>
    /// <returns>JSON string presentation of the object</returns>
    public  new string ToJson() {
      return JsonConvert.SerializeObject(this, Formatting.Indented);
    }

}
}
