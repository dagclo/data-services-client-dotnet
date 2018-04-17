using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;
using Newtonsoft.Json;

namespace Quadient.DataServices.Model.Country {

  /// <summary>
  /// Results from country standardization.
  /// </summary>
  [DataContract]
  public class CountryStandardizationResponse {
    /// <summary>
    /// Output localization of country name
    /// </summary>
    /// <value>Output localization of country name</value>
    [DataMember(Name="language", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "language")]
    public string Language { get; set; }

    /// <summary>
    /// Gets or Sets Countries
    /// </summary>
    [DataMember(Name="countries", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "countries")]
    public List<OutputCountry> Countries { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class CountryStandardizationResponse {\n");
      sb.Append("  Language: ").Append(Language).Append("\n");
      sb.Append("  Countries: ").Append(Countries).Append("\n");
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
