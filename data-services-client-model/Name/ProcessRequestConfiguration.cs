using System.Runtime.Serialization;
using System.Text;
using Newtonsoft.Json;

namespace Quadient.DataServices.Model.Name {

  /// <summary>
  /// 
  /// </summary>
  [DataContract]
  public class ProcessRequestConfiguration {
    /// <summary>
    /// Indicates whether to enable capitalization support, meaning that the service will correct the text case of name tokens. 
    /// </summary>
    /// <value>Indicates whether to enable capitalization support, meaning that the service will correct the text case of name tokens. </value>
    [DataMember(Name="enable_capitalization", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "enable_capitalization")]
    public bool? EnableCapitalization { get; set; }

    /// <summary>
    /// Indicates whether to enable the nickname lookup feature. Disable to turn off the lookup into the nickname knowledge data for each name. 
    /// </summary>
    /// <value>Indicates whether to enable the nickname lookup feature. Disable to turn off the lookup into the nickname knowledge data for each name. </value>
    [DataMember(Name="enable_nicknames", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "enable_nicknames")]
    public bool? EnableNicknames { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class ProcessRequestConfiguration {\n");
      sb.Append("  EnableCapitalization: ").Append(EnableCapitalization).Append("\n");
      sb.Append("  EnableNicknames: ").Append(EnableNicknames).Append("\n");
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
