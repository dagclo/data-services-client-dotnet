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
  public class UsageQueryResponseTotal {
    /// <summary>
    /// Defines a set of usage metrics for each of the services that has been consumed in total.
    /// </summary>
    /// <value>Defines a set of usage metrics for each of the services that has been consumed in total.</value>
    [DataMember(Name="service-use", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "service-use")]
    public Object ServiceUse { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class UsageQueryResponseTotal {\n");
      sb.Append("  ServiceUse: ").Append(ServiceUse).Append("\n");
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
