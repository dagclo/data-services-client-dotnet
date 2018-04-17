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
  public class JobInformationResponse {
    /// <summary>
    /// The job's unique ID.
    /// </summary>
    /// <value>The job's unique ID.</value>
    [DataMember(Name="job_id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "job_id")]
    public string JobId { get; set; }

    /// <summary>
    /// The originating product/application/service for which this job was created.
    /// </summary>
    /// <value>The originating product/application/service for which this job was created.</value>
    [DataMember(Name="origin", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "origin")]
    public string Origin { get; set; }

    /// <summary>
    /// The user_id of the job's owner.
    /// </summary>
    /// <value>The user_id of the job's owner.</value>
    [DataMember(Name="owner", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "owner")]
    public string Owner { get; set; }

    /// <summary>
    /// The parent job's job_id. May be null if the job does not have a parent job.
    /// </summary>
    /// <value>The parent job's job_id. May be null if the job does not have a parent job.</value>
    [DataMember(Name="parent_job", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "parent_job")]
    public string ParentJob { get; set; }

    /// <summary>
    /// The time of job creation
    /// </summary>
    /// <value>The time of job creation</value>
    [DataMember(Name="created_at", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "created_at")]
    public DateTime? CreatedAt { get; set; }

    /// <summary>
    /// Gets or Sets JobStatus
    /// </summary>
    [DataMember(Name="job_status", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "job_status")]
    public JobStatus JobStatus { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class JobInformationResponse {\n");
      sb.Append("  JobId: ").Append(JobId).Append("\n");
      sb.Append("  Origin: ").Append(Origin).Append("\n");
      sb.Append("  Owner: ").Append(Owner).Append("\n");
      sb.Append("  ParentJob: ").Append(ParentJob).Append("\n");
      sb.Append("  CreatedAt: ").Append(CreatedAt).Append("\n");
      sb.Append("  JobStatus: ").Append(JobStatus).Append("\n");
      sb.Append("}\n");
      return sb.ToString();
    }

    /// <summary>
    /// Get the JSON string presentation of the object
    /// </summary>
    /// <returns>JSON string presentation of the object</returns>
    public string ToJson() {
      return JsonConvert.SerializeObject(this, Formatting.Indented);
    }

}
}
