using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;
using Newtonsoft.Json;

namespace Quadient.DataServices.Model.Address {

  /// <summary>
  /// The address that results and is output after correction. This object contains the information needed to represent the address in a variety of ways, but the printed address always contains  the following fields, separated on individual lines: * organization * address_lines * regional_lines * country
  /// </summary>
  [DataContract]
  public class CorrectionResponseAddress : BaseAddress {
    /// <summary>
    /// A set of lines that presents the regional lines of an address block. Depending on the country, this typically consists of postal code, and city and state or province.
    /// </summary>
    /// <value>A set of lines that presents the regional lines of an address block. Depending on the country, this typically consists of postal code, and city and state or province.</value>
    [DataMember(Name="regional_lines", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "regional_lines")]
    public List<string> RegionalLines { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class CorrectionResponseAddress {\n");
      sb.Append("  RegionalLines: ").Append(RegionalLines).Append("\n");
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
