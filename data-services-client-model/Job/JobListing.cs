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
  public class JobListing {
    /// <summary>
    /// The number of jobs returned.
    /// </summary>
    /// <value>The number of jobs returned.</value>
    [DataMember(Name="count", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "count")]
    public int? Count { get; set; }

    /// <summary>
    /// Gets or Sets Jobs
    /// </summary>
    [DataMember(Name="jobs", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "jobs")]
    public List<JobInformationResponse> Jobs { get; set; }

    /// <summary>
    /// The number of jobs found.
    /// </summary>
    /// <value>The number of jobs found.</value>
    [DataMember(Name="total", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "total")]
    public int? Total { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class JobListing {\n");
      sb.Append("  Count: ").Append(Count).Append("\n");
      sb.Append("  Jobs: ").Append(Jobs).Append("\n");
      sb.Append("  Total: ").Append(Total).Append("\n");
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
