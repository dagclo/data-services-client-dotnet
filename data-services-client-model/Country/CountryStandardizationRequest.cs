using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;
using Newtonsoft.Json;

namespace Quadient.DataServices.Model.Country {

  /// <summary>
  /// 
  /// </summary>
  [DataContract]
  public class CountryStandardizationRequest {
    /// <summary>
    /// Language short code. It can be empty - default value is 'en'. Api return country name in this language.
    /// </summary>
    /// <value>Language short code. It can be empty - default value is 'en'. Api return country name in this language.</value>
    [DataMember(Name="language", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "language")]
    public string Language { get; set; }

    /// <summary>
    /// Array of input countries. It can be the country code or name to search for.
    /// </summary>
    /// <value>Array of input countries. It can be the country code or name to search for.</value>
    [DataMember(Name="countries", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "countries")]
    public List<string> Countries { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class CountryStandardizationRequest {\n");
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
