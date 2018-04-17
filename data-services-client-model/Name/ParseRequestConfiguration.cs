using System.Runtime.Serialization;
using System.Text;
using Newtonsoft.Json;

namespace Quadient.DataServices.Model.Name {

  /// <summary>
  /// 
  /// </summary>
  [DataContract]
  public class ParseRequestConfiguration {
    /// <summary>
    /// Indicates whether to enable capitalization support, meaning that the service will correct the text case of name tokens. 
    /// </summary>
    /// <value>Indicates whether to enable capitalization support, meaning that the service will correct the text case of name tokens. </value>
    [DataMember(Name="enable_capitalization", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "enable_capitalization")]
    public bool? EnableCapitalization { get; set; }

    /// <summary>
    /// Indicates whether to enable the nickname lookup feature. Disable to turn off the lookup into the nickname knowledge data for each name. 
    /// </summary>
    /// <value>Indicates whether to enable the nickname lookup feature. Disable to turn off the lookup into the nickname knowledge data for each name. </value>
    [DataMember(Name="enable_nicknames", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "enable_nicknames")]
    public bool? EnableNicknames { get; set; }

    /// <summary>
    /// Determines whether middle names are included in the output and how they are handled. The following options are available: * `Separate` uses a parser with middle name awareness and puts the middle name tokens into the separate `middle_name` field. * `Allocate` uses a parser without middle name awareness and allocates the tokens into the most appropriate given or family name fields.  
    /// </summary>
    /// <value>Determines whether middle names are included in the output and how they are handled. The following options are available: * `Separate` uses a parser with middle name awareness and puts the middle name tokens into the separate `middle_name` field. * `Allocate` uses a parser without middle name awareness and allocates the tokens into the most appropriate given or family name fields.  </value>
    [DataMember(Name="middle_name_handling", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "middle_name_handling")]
    public string MiddleNameHandling { get; set; }

    /// <summary>
    /// Determines how to handle generation titles. The following options are available: * `Separate` keeps generation titles in the separate `generation_title` attribute. * `Familyname` always appends generation titles to the family name. * `Omit` removes generation titles. 
    /// </summary>
    /// <value>Determines how to handle generation titles. The following options are available: * `Separate` keeps generation titles in the separate `generation_title` attribute. * `Familyname` always appends generation titles to the family name. * `Omit` removes generation titles. </value>
    [DataMember(Name="generation_title_handling", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "generation_title_handling")]
    public string GenerationTitleHandling { get; set; }

    /// <summary>
    /// The default `country` value to apply to names where no country is supplied. The ISO 3166 2-letter country code is preferred. 
    /// </summary>
    /// <value>The default `country` value to apply to names where no country is supplied. The ISO 3166 2-letter country code is preferred. </value>
    [DataMember(Name="default_country", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "default_country")]
    public string DefaultCountry { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class ParseRequestConfiguration {\n");
      sb.Append("  EnableCapitalization: ").Append(EnableCapitalization).Append("\n");
      sb.Append("  EnableNicknames: ").Append(EnableNicknames).Append("\n");
      sb.Append("  MiddleNameHandling: ").Append(MiddleNameHandling).Append("\n");
      sb.Append("  GenerationTitleHandling: ").Append(GenerationTitleHandling).Append("\n");
      sb.Append("  DefaultCountry: ").Append(DefaultCountry).Append("\n");
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
