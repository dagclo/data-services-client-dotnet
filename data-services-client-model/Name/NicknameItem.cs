using System.Runtime.Serialization;
using System.Text;
using Newtonsoft.Json;

namespace Quadient.DataServices.Model.Name {

  /// <summary>
  /// 
  /// </summary>
  [DataContract]
  public class NicknameItem {
    /// <summary>
    /// Describes in which field the potential nickname was found.
    /// </summary>
    /// <value>Describes in which field the potential nickname was found.</value>
    [DataMember(Name="field", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "field")]
    public string Field { get; set; }

    /// <summary>
    /// The original input name part that may have a nickname or may be a nickname.
    /// </summary>
    /// <value>The original input name part that may have a nickname or may be a nickname.</value>
    [DataMember(Name="orig", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "orig")]
    public string Orig { get; set; }

    /// <summary>
    /// The name part that may be a alternate for the original input.
    /// </summary>
    /// <value>The name part that may be a alternate for the original input.</value>
    [DataMember(Name="alternate", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "alternate")]
    public string Alternate { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class NicknameItem {\n");
      sb.Append("  Field: ").Append(Field).Append("\n");
      sb.Append("  Orig: ").Append(Orig).Append("\n");
      sb.Append("  Alternate: ").Append(Alternate).Append("\n");
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
