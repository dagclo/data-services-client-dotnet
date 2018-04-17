using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;
using Newtonsoft.Json;

namespace Quadient.DataServices.Model.Phone {

  /// <summary>
  /// 
  /// </summary>
  [DataContract]
  public class PhoneValidationRequest {
    /// <summary>
    /// Gets or Sets Configuration
    /// </summary>
    [DataMember(Name="configuration", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "configuration")]
    public PhoneValidationRequestConfiguration Configuration { get; set; }

    /// <summary>
    /// The set of phone numbers to be processed for validity
    /// </summary>
    /// <value>The set of phone numbers to be processed for validity</value>
    [DataMember(Name="phone_numbers", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "phone_numbers")]
    public List<PhoneValidationRequestRecord> PhoneNumbers { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class PhoneValidationRequest {\n");
      sb.Append("  Configuration: ").Append(Configuration).Append("\n");
      sb.Append("  PhoneNumbers: ").Append(PhoneNumbers).Append("\n");
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
