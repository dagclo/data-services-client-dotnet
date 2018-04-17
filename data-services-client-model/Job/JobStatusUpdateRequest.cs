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
  public class JobStatusUpdateRequest {
    /// <summary>
    /// Gets or Sets JobStatus
    /// </summary>
    [DataMember(Name="job_status", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "job_status")]
    public JobStatus JobStatus { get; set; }

    /// <summary>
    /// Any additional details about the job status change.
    /// </summary>
    /// <value>Any additional details about the job status change.</value>
    [DataMember(Name="job_status_details", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "job_status_details")]
    public Object JobStatusDetails { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class JobStatusUpdateRequest {\n");
      sb.Append("  JobStatus: ").Append(JobStatus).Append("\n");
      sb.Append("  JobStatusDetails: ").Append(JobStatusDetails).Append("\n");
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
