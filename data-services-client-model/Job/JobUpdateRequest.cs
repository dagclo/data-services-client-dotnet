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
  public class JobUpdateRequest {
    /// <summary>
    /// Any additional details about the job.
    /// </summary>
    /// <value>Any additional details about the job.</value>
    [DataMember(Name="additional_details", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "additional_details")]
    public Object AdditionalDetails { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class JobUpdateRequest {\n");
      sb.Append("  AdditionalDetails: ").Append(AdditionalDetails).Append("\n");
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
