using System.Runtime.Serialization;
using System.Text;
using Newtonsoft.Json;

namespace Quadient.DataServices.Model.AddressCorrection {

  /// <summary>
  /// Defines an output group that contains additional address elements, enabled using the &#x60;output_groups&#x60; configuration setting. The availability of individual properties of this group varies depending on country.
  /// </summary>
  [DataContract]
  public class CorrectionResponseRecordAddressTraits {
    /// <summary>
    /// Abbreviated version of city name when applicable. Currently available for United States addresses only.
    /// </summary>
    /// <value>Abbreviated version of city name when applicable. Currently available for United States addresses only.</value>
    [DataMember(Name="city_abbreviated", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "city_abbreviated")]
    public string CityAbbreviated { get; set; }

    /// <summary>
    /// Unique county code. Currently available for United States addresses only.
    /// </summary>
    /// <value>Unique county code. Currently available for United States addresses only.</value>
    [DataMember(Name="county_code", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "county_code")]
    public string CountyCode { get; set; }

    /// <summary>
    /// Unique delivery point code. Currently available for United States addresses only.
    /// </summary>
    /// <value>Unique delivery point code. Currently available for United States addresses only.</value>
    [DataMember(Name="dpc", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "dpc")]
    public string Dpc { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class CorrectionResponseRecordAddressTraits {\n");
      sb.Append("  CityAbbreviated: ").Append(CityAbbreviated).Append("\n");
      sb.Append("  CountyCode: ").Append(CountyCode).Append("\n");
      sb.Append("  Dpc: ").Append(Dpc).Append("\n");
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
