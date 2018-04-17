using System.Runtime.Serialization;
using System.Text;
using Newtonsoft.Json;

namespace Quadient.DataServices.Model.Address {

  /// <summary>
  /// Defines an additional output group of fields for move_update processing, enabled using the &#x60;output_groups&#x60; configuration setting.
  /// </summary>
  [DataContract]
  public class CorrectionResponseRecordMoveUpdate {
    /// <summary>
    /// An identifier that can be passed in with the corresponding record when running a move_update job in place of the record's address details.
    /// </summary>
    /// <value>An identifier that can be passed in with the corresponding record when running a move_update job in place of the record's address details.</value>
    [DataMember(Name="address_cookie", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "address_cookie")]
    public string AddressCookie { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class CorrectionResponseRecordMoveUpdate {\n");
      sb.Append("  AddressCookie: ").Append(AddressCookie).Append("\n");
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
