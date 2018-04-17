using System.Runtime.Serialization;
using System.Text;
using Newtonsoft.Json;

namespace Quadient.DataServices.Model.Country {

  /// <summary>
  /// A country standardization result
  /// </summary>
  [DataContract]
  public class StandardCountry {
    /// <summary>
    /// String from the request.
    /// </summary>
    /// <value>String from the request.</value>
    [DataMember(Name="input", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "input")]
    public string Input { get; set; }

    /// <summary>
    /// Country name
    /// </summary>
    /// <value>Country name</value>
    [DataMember(Name="name", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "name")]
    public string Name { get; set; }

    /// <summary>
    /// Two letter ISO 3166-1 (alpha 2) code
    /// </summary>
    /// <value>Two letter ISO 3166-1 (alpha 2) code</value>
    [DataMember(Name="iso2", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "iso2")]
    public string Iso2 { get; set; }

    /// <summary>
    /// Three letter ISO 3166-1 (alpha 3) code
    /// </summary>
    /// <value>Three letter ISO 3166-1 (alpha 3) code</value>
    [DataMember(Name="iso3", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "iso3")]
    public string Iso3 { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class StandardCountry {\n");
      sb.Append("  Input: ").Append(Input).Append("\n");
      sb.Append("  Name: ").Append(Name).Append("\n");
      sb.Append("  Iso2: ").Append(Iso2).Append("\n");
      sb.Append("  Iso3: ").Append(Iso3).Append("\n");
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
