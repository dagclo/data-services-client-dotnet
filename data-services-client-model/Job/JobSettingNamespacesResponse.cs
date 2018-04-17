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
  public class JobSettingNamespacesResponse {
    /// <summary>
    /// An object containing namespace as key and hrefs as values
    /// </summary>
    /// <value>An object containing namespace as key and hrefs as values</value>
    [DataMember(Name="namespaces", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "namespaces")]
    public Object Namespaces { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class JobSettingNamespacesResponse {\n");
      sb.Append("  Namespaces: ").Append(Namespaces).Append("\n");
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
