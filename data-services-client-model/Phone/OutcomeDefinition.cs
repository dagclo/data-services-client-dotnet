using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;
using Newtonsoft.Json;

namespace Quadient.DataServices.Model.Phone {

  /// <summary>
  /// 
  /// </summary>
  [DataContract]
  public class OutcomeDefinition {
    /// <summary>
    /// The final status of the object. The rules for selecting a `category` are as follows:  * Skipped: If the input `phone_number` is missing, null, blank, or entirely white spaces, `Skipped` is returned. * Invalid: If the input `phone_number` is not recognized, `Invalid` is returned. * Valid: If the input `phone_number` is recognized and matches exactly one or more of the formats, `Valid` is returned. * Corrected: If the input `phone_number`is recognized, but it does not match any of the formats, `Corrected` is returned. * Doubtful: Currently `Doubtful` is not an expected outcome category. It may be activated in later versions of the service in case a phone number is recognized but is deemed to be suspicious or otherwise unqualified. 
    /// </summary>
    /// <value>The final status of the object. The rules for selecting a `category` are as follows:  * Skipped: If the input `phone_number` is missing, null, blank, or entirely white spaces, `Skipped` is returned. * Invalid: If the input `phone_number` is not recognized, `Invalid` is returned. * Valid: If the input `phone_number` is recognized and matches exactly one or more of the formats, `Valid` is returned. * Corrected: If the input `phone_number`is recognized, but it does not match any of the formats, `Corrected` is returned. * Doubtful: Currently `Doubtful` is not an expected outcome category. It may be activated in later versions of the service in case a phone number is recognized but is deemed to be suspicious or otherwise unqualified. </value>
    [DataMember(Name="category", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "category")]
    public string Category { get; set; }

    /// <summary>
    /// An object that contains correction codes as keys. The values may be either a string message or another object that contains additional information. 
    /// </summary>
    /// <value>An object that contains correction codes as keys. The values may be either a string message or another object that contains additional information. </value>
    [DataMember(Name="codes", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "codes")]
    public Dictionary<string, string> Codes { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class OutcomeDefinition {\n");
      sb.Append("  Category: ").Append(Category).Append("\n");
      sb.Append("  Codes: ").Append(Codes).Append("\n");
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
