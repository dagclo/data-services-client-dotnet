using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;
using Newtonsoft.Json;

namespace Quadient.DataServices.Model.Address {

  /// <summary>
  /// 
  /// </summary>
  [DataContract]
  public class OutcomeDefinition {
    /// <summary>
    /// An object that contains correction codes as keys. Codes prefixed with C describe a correction. Codes prefixed with E describe an error with input. These records are skipped or are invalid. The values may be either a string message or another object that contains additional information. More than one code may be returned. * `C10` - Street corrected. * `C11` - House number appended or corrected. * `C12` - Postal code appended or corrected. * `C13` - City appended or corrected. * `C14` - Province or state appended or corrected. * `C15` - County appended or corrected. * `C16` - Country standardized. * `C17` - Building corrected. * `C18` - Organization corrected. * `C19` - Converted to new address. * `C20` - Geocode appended. * `C21` - Post Office Box updated or appended. * `E10` - Country unsupported; record is skipped. * `E11` - No address lines. * `E12` - Too many address lines. * `E13` - No country specified. * `E14` - Could not identify country. * `E15` - Street invalid or missing. * `E16` - House number invalid or missing. * `E17` - Postal code invalid. * `E18` - City invalid. * `E19` - Province or state invalid. * `E20` - Unit number invalid. * `E21` - Unit number missing. * `E22` - Input value(s) too long. * `E23` - Address is not applicable for mail delivery. * `E24` - Urbanization invalid or missing. * `E25` - No geocode available. * `E26` - Locality invalid or missing. * `E27` - Building invalid or missing. * `E28` - Post Office Box invalid or missing. * `E29` - Skipped due to unexpected error. 
    /// </summary>
    /// <value>An object that contains correction codes as keys. Codes prefixed with C describe a correction. Codes prefixed with E describe an error with input. These records are skipped or are invalid. The values may be either a string message or another object that contains additional information. More than one code may be returned. * `C10` - Street corrected. * `C11` - House number appended or corrected. * `C12` - Postal code appended or corrected. * `C13` - City appended or corrected. * `C14` - Province or state appended or corrected. * `C15` - County appended or corrected. * `C16` - Country standardized. * `C17` - Building corrected. * `C18` - Organization corrected. * `C19` - Converted to new address. * `C20` - Geocode appended. * `C21` - Post Office Box updated or appended. * `E10` - Country unsupported; record is skipped. * `E11` - No address lines. * `E12` - Too many address lines. * `E13` - No country specified. * `E14` - Could not identify country. * `E15` - Street invalid or missing. * `E16` - House number invalid or missing. * `E17` - Postal code invalid. * `E18` - City invalid. * `E19` - Province or state invalid. * `E20` - Unit number invalid. * `E21` - Unit number missing. * `E22` - Input value(s) too long. * `E23` - Address is not applicable for mail delivery. * `E24` - Urbanization invalid or missing. * `E25` - No geocode available. * `E26` - Locality invalid or missing. * `E27` - Building invalid or missing. * `E28` - Post Office Box invalid or missing. * `E29` - Skipped due to unexpected error. </value>
    [DataMember(Name="codes", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "codes")]
    public Dictionary<string, string> Codes { get; set; }

    /// <summary>
    /// The final status of the object.
    /// </summary>
    /// <value>The final status of the object.</value>
    [DataMember(Name="category", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "category")]
    public string Category { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class OutcomeDefinition {\n");
      sb.Append("  Codes: ").Append(Codes).Append("\n");
      sb.Append("  Category: ").Append(Category).Append("\n");
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
