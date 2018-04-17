using System.Runtime.Serialization;
using System.Text;
using Newtonsoft.Json;

namespace Quadient.DataServices.Model.Name {

  /// <summary>
  /// 
  /// </summary>
  [DataContract]
  public class ParseRequestItem {
    /// <summary>
    /// An optional identifier used to pass through to the response.
    /// </summary>
    /// <value>An optional identifier used to pass through to the response.</value>
    [DataMember(Name="id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "id")]
    public string Id { get; set; }

    /// <summary>
    /// The unstructured name string to parse.
    /// </summary>
    /// <value>The unstructured name string to parse.</value>
    [DataMember(Name="unstructured_name", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "unstructured_name")]
    public string UnstructuredName { get; set; }

    /// <summary>
    /// An optional country code for the person, which is used to apply any regional formatting rules. The ISO 3166 2-letter country code is preferred. 
    /// </summary>
    /// <value>An optional country code for the person, which is used to apply any regional formatting rules. The ISO 3166 2-letter country code is preferred. </value>
    [DataMember(Name="country", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "country")]
    public string Country { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class ParseRequestItem {\n");
      sb.Append("  Id: ").Append(Id).Append("\n");
      sb.Append("  UnstructuredName: ").Append(UnstructuredName).Append("\n");
      sb.Append("  Country: ").Append(Country).Append("\n");
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
