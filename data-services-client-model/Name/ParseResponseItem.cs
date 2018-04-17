using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;
using Newtonsoft.Json;

namespace Quadient.DataServices.Model.Name {

  /// <summary>
  /// Response item containing the results of parsing.
  /// </summary>
  [DataContract]
  public class ParseResponseItem {
    /// <summary>
    /// The optional identifier provided for this name on input.
    /// </summary>
    /// <value>The optional identifier provided for this name on input.</value>
    [DataMember(Name="id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "id")]
    public string Id { get; set; }

    /// <summary>
    /// The name(s) identified in the input. Usually the array has just one value, but depending on the settomg of the `multi_entity_handling` configuration property, the service may return more than one. It will return zero in case of empty or skipped input.
    /// </summary>
    /// <value>The name(s) identified in the input. Usually the array has just one value, but depending on the settomg of the `multi_entity_handling` configuration property, the service may return more than one. It will return zero in case of empty or skipped input.</value>
    [DataMember(Name="names", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "names")]
    public List<NameDetailsOut> Names { get; set; }

    /// <summary>
    /// Gets or Sets Outcome
    /// </summary>
    [DataMember(Name="outcome", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "outcome")]
    public OutcomeDefinition Outcome { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class ParseResponseItem {\n");
      sb.Append("  Id: ").Append(Id).Append("\n");
      sb.Append("  Names: ").Append(Names).Append("\n");
      sb.Append("  Outcome: ").Append(Outcome).Append("\n");
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
