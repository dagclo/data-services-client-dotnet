using System.Runtime.Serialization;
using System.Text;
using Newtonsoft.Json;

namespace Quadient.DataServices.Model.Country {

  /// <summary>
  /// 
  /// </summary>
  [DataContract]
  public class OutputCountry {
    /// <summary>
    /// Gets or Sets Country
    /// </summary>
    [DataMember(Name="country", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "country")]
    public StandardCountry Country { get; set; }

    /// <summary>
    /// Gets or Sets Outcome
    /// </summary>
    [DataMember(Name="outcome", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "outcome")]
    public CountryOutcome Outcome { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class OutputCountry {\n");
      sb.Append("  Country: ").Append(Country).Append("\n");
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
