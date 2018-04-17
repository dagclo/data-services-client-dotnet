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
  public class UsageQueryGroupItem {
    /// <summary>
    /// The value of the group, e.g. the date, the job_id or whatever was used as the group parameter of the query
    /// </summary>
    /// <value>The value of the group, e.g. the date, the job_id or whatever was used as the group parameter of the query</value>
    [DataMember(Name="group_value", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "group_value")]
    public string GroupValue { get; set; }

    /// <summary>
    /// Defines a set of usage metrics for each of the services that has been consumed in this group.
    /// </summary>
    /// <value>Defines a set of usage metrics for each of the services that has been consumed in this group.</value>
    [DataMember(Name="usage", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "usage")]
    public Object Usage { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class UsageQueryGroupItem {\n");
      sb.Append("  GroupValue: ").Append(GroupValue).Append("\n");
      sb.Append("  Usage: ").Append(Usage).Append("\n");
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
