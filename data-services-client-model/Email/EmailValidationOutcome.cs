using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;
using Newtonsoft.Json;

namespace Quadient.DataServices.Model.Email {

  /// <summary>
  /// 
  /// </summary>
  [DataContract]
  public class EmailValidationOutcome : Dictionary<String, string> {
    /// <summary>
    /// The final status of the object.
    /// </summary>
    /// <value>The final status of the object.</value>
    [DataMember(Name="category", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "category")]
    public string Category { get; set; }

    /// <summary>
    /// An object that contains correction codes as keys. The values may be either a string message or another object that contains additional information.
    /// </summary>
    /// <value>An object that contains correction codes as keys. The values may be either a string message or another object that contains additional information.</value>
    [DataMember(Name="codes", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "codes")]
    public Dictionary<string, string> Codes { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class EmailValidationOutcome {\n");
      sb.Append("  Category: ").Append(Category).Append("\n");
      sb.Append("  Codes: ").Append(Codes).Append("\n");
      sb.Append("}\n");
      return sb.ToString();
    }

    /// <summary>
    /// Get the JSON string presentation of the object
    /// </summary>
    /// <returns>JSON string presentation of the object</returns>
    public  new string ToJson() {
      return JsonConvert.SerializeObject(this, Formatting.Indented);
    }

}
}
