using System.Runtime.Serialization;
using System.Text;
using Newtonsoft.Json;

namespace Quadient.DataServices.Model.Phone {

  /// <summary>
  /// 
  /// </summary>
  [DataContract]
  public class PhoneValidationResponseRecordPhoneNumberFormats {
    /// <summary>
    /// The `International` formatted phone number, which is consistent with the definition in ITU-T Recommendation E123.
    /// </summary>
    /// <value>The `International` formatted phone number, which is consistent with the definition in ITU-T Recommendation E123.</value>
    [DataMember(Name="International", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "International")]
    public string International { get; set; }

    /// <summary>
    /// The `National` formatted phone number, which is consistent with the definition in ITU-T Recommendation E123.
    /// </summary>
    /// <value>The `National` formatted phone number, which is consistent with the definition in ITU-T Recommendation E123.</value>
    [DataMember(Name="National", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "National")]
    public string National { get; set; }

    /// <summary>
    /// The `E164` formatted phone number, which is similar to the `International`, but does not have any formatting.
    /// </summary>
    /// <value>The `E164` formatted phone number, which is similar to the `International`, but does not have any formatting.</value>
    [DataMember(Name="E164", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "E164")]
    public string E164 { get; set; }

    /// <summary>
    /// The `RFC3966` formatted phone number, which is similar to the `International` format, but has all spaces and other separating symbols replaced with hyphens and has any phone number extension appended with \";ext=\". It also has a prefix of `tel:` added.
    /// </summary>
    /// <value>The `RFC3966` formatted phone number, which is similar to the `International` format, but has all spaces and other separating symbols replaced with hyphens and has any phone number extension appended with \";ext=\". It also has a prefix of `tel:` added.</value>
    [DataMember(Name="RFC3966", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "RFC3966")]
    public string RFC3966 { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class PhoneValidationResponseRecordPhoneNumberFormats {\n");
      sb.Append("  International: ").Append(International).Append("\n");
      sb.Append("  National: ").Append(National).Append("\n");
      sb.Append("  E164: ").Append(E164).Append("\n");
      sb.Append("  RFC3966: ").Append(RFC3966).Append("\n");
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
