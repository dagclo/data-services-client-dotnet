using System.Runtime.Serialization;
using System.Text;
using Newtonsoft.Json;

namespace Quadient.DataServices.Model.Address {

  /// <summary>
  /// Defines an additional output group of fields for geocoding, enabled using the &#x60;output_groups&#x60; configuration setting.
  /// </summary>
  [DataContract]
  public class CorrectionResponseRecordGeocodes {
    /// <summary>
    /// Latitude coordinate.
    /// </summary>
    /// <value>Latitude coordinate.</value>
    [DataMember(Name="lat", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "lat")]
    public double? Lat { get; set; }

    /// <summary>
    /// Longitude coordinate.
    /// </summary>
    /// <value>Longitude coordinate.</value>
    [DataMember(Name="lng", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "lng")]
    public double? Lng { get; set; }

    /// <summary>
    /// Defines the precision of the geocodes. Different regions may use different values. The `Zip-n` value represents the precision of a US ZIP Code. The most grandular, Zip-9, matches a full 9-digit code (from an individual mail box to a city block). The least grandular, Zip-3, matches the first 3 letters of a ZIP Code (roughly at the county level). 
    /// </summary>
    /// <value>Defines the precision of the geocodes. Different regions may use different values. The `Zip-n` value represents the precision of a US ZIP Code. The most grandular, Zip-9, matches a full 9-digit code (from an individual mail box to a city block). The least grandular, Zip-3, matches the first 3 letters of a ZIP Code (roughly at the county level). </value>
    [DataMember(Name="prc", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "prc")]
    public string Prc { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class CorrectionResponseRecordGeocodes {\n");
      sb.Append("  Lat: ").Append(Lat).Append("\n");
      sb.Append("  Lng: ").Append(Lng).Append("\n");
      sb.Append("  Prc: ").Append(Prc).Append("\n");
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
