using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;
using Newtonsoft.Json;

namespace Quadient.DataServices.Model.AddressCorrection {

  /// <summary>
  /// 
  /// </summary>
  [DataContract]
  public class CorrectionRequest {
    /// <summary>
    /// Gets or Sets Addresses
    /// </summary>
    [DataMember(Name="addresses", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "addresses")]
    public List<CorrectionRequestAddress> Addresses { get; set; }

    /// <summary>
    /// Gets or Sets Configuration
    /// </summary>
    [DataMember(Name="configuration", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "configuration")]
    public CorrectionRequestConfiguration Configuration { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class CorrectionRequest {\n");
      sb.Append("  Addresses: ").Append(Addresses).Append("\n");
      sb.Append("  Configuration: ").Append(Configuration).Append("\n");
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
