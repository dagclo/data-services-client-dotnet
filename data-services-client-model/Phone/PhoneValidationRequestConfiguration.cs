using System.Runtime.Serialization;
using System.Text;
using Newtonsoft.Json;

namespace Quadient.DataServices.Model.Phone {

  /// <summary>
  /// Configuration options to set for the data quality engine. Omit if you want to use the default behavior. The default behavior assumes that the phone number includes a country code.
  /// </summary>
  [DataContract]
  public class PhoneValidationRequestConfiguration {
    /// <summary>
    /// The default `country` value to apply to phone numbers where no country is supplied.  The ISO 3166-2 two-letter country code is preferred.
    /// </summary>
    /// <value>The default `country` value to apply to phone numbers where no country is supplied.  The ISO 3166-2 two-letter country code is preferred.</value>
    [DataMember(Name="default_country", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "default_country")]
    public string DefaultCountry { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class PhoneValidationRequestConfiguration {\n");
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
