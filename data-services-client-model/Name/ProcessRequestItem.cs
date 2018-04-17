using System.Runtime.Serialization;
using System.Text;
using Newtonsoft.Json;

namespace Quadient.DataServices.Model.Name {

  /// <summary>
  /// 
  /// </summary>
  [DataContract]
  public class ProcessRequestItem : NameDetailsIn {
    /// <summary>
    /// An optional identifier used to pass through to the response.
    /// </summary>
    /// <value>An optional identifier used to pass through to the response.</value>
    [DataMember(Name="id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "id")]
    public string Id { get; set; }

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
      sb.Append("class ProcessRequestItem {\n");
      sb.Append("  Id: ").Append(Id).Append("\n");
      sb.Append("  Country: ").Append(Country).Append("\n");
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
