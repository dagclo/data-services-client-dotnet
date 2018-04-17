using System.Runtime.Serialization;
using System.Text;
using Newtonsoft.Json;

namespace Quadient.DataServices.Model.Phone {

  /// <summary>
  /// 
  /// </summary>
  [DataContract]
  public class PhoneValidationRequestRecord {
    /// <summary>
    /// User-specified reference id or name for the job. For example, My Job ID..
    /// </summary>
    /// <value>User-specified reference id or name for the job. For example, My Job ID..</value>
    [DataMember(Name="id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "id")]
    public string Id { get; set; }

    /// <summary>
    /// The country code or name. The ISO 3166 2-letter country code is preferred.
    /// </summary>
    /// <value>The country code or name. The ISO 3166 2-letter country code is preferred.</value>
    [DataMember(Name="country", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "country")]
    public string Country { get; set; }

    /// <summary>
    /// The phone number to be validated.
    /// </summary>
    /// <value>The phone number to be validated.</value>
    [DataMember(Name="phone_number", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "phone_number")]
    public string PhoneNumber { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class PhoneValidationRequestRecord {\n");
      sb.Append("  Id: ").Append(Id).Append("\n");
      sb.Append("  Country: ").Append(Country).Append("\n");
      sb.Append("  PhoneNumber: ").Append(PhoneNumber).Append("\n");
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
