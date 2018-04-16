using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;
using Newtonsoft.Json;
using Quadient.DataServices.Api;

namespace Quadient.DataServices.Model.AddressCorrection {

  /// <summary>
  /// 
  /// </summary>
  [DataContract]
  public class CorrectionResponse: IResponse<CorrectionResponse>
  {
    /// <summary>
    /// Gets or Sets Addresses
    /// </summary>
    [DataMember(Name="addresses", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "addresses")]
    public List<CorrectionResponseRecord> Addresses { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class CorrectionResponse {\n");
      sb.Append("  Addresses: ").Append(Addresses).Append("\n");
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
