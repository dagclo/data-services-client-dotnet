using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;
using Newtonsoft.Json;

namespace Quadient.DataServices.Model.Address {

  /// <summary>
  /// The configuration of the correction request. These values are ignored for uncorrected addresses.
  /// </summary>
  [DataContract]
  public class CorrectionRequestConfiguration {
    /// <summary>
    /// The maximum number of address lines to present on output.
    /// </summary>
    /// <value>The maximum number of address lines to present on output.</value>
    [DataMember(Name="maximum_address_line_count", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "maximum_address_line_count")]
    public int? MaximumAddressLineCount { get; set; }

    /// <summary>
    /// The maximum number of regional lines to present on output.
    /// </summary>
    /// <value>The maximum number of regional lines to present on output.</value>
    [DataMember(Name="maximum_regional_line_count", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "maximum_regional_line_count")]
    public int? MaximumRegionalLineCount { get; set; }

    /// <summary>
    /// Set the language to return on output. * `Preserve` (default) detects and preserves the input language and script. This works for Belarus, China, Greece, Japan, Kazakhstan, Macedonia, and Russia. For all other countries, it defaults to the native language and script. * `English` returns English for all countries, except Belgium, France, Germany, and the Netherlands.  * `Native` returns the country's official language in that country's script. For example, \"Copenhagen\" on input is returned as \"København\" on output. 
    /// </summary>
    /// <value>Set the language to return on output. * `Preserve` (default) detects and preserves the input language and script. This works for Belarus, China, Greece, Japan, Kazakhstan, Macedonia, and Russia. For all other countries, it defaults to the native language and script. * `English` returns English for all countries, except Belgium, France, Germany, and the Netherlands.  * `Native` returns the country's official language in that country's script. For example, \"Copenhagen\" on input is returned as \"København\" on output. </value>
    [DataMember(Name="output_language", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "output_language")]
    public Object OutputLanguage { get; set; }

    /// <summary>
    /// Gets or Sets OutputGroups
    /// </summary>
    [DataMember(Name="output_groups", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "output_groups")]
    public List<OutputGroup> OutputGroups { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class CorrectionRequestConfiguration {\n");
      sb.Append("  MaximumAddressLineCount: ").Append(MaximumAddressLineCount).Append("\n");
      sb.Append("  MaximumRegionalLineCount: ").Append(MaximumRegionalLineCount).Append("\n");
      sb.Append("  OutputLanguage: ").Append(OutputLanguage).Append("\n");
      sb.Append("  OutputGroups: ").Append(OutputGroups).Append("\n");
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
