using System.Runtime.Serialization;
using System.Text;
using Newtonsoft.Json;

namespace Quadient.DataServices.Model.Phone {

  /// <summary>
  /// 
  /// </summary>
  [DataContract]
  public class PhoneValidationResponseRecordPhoneNumber {
    /// <summary>
    /// User-specified reference id or name as passed in.
    /// </summary>
    /// <value>User-specified reference id or name as passed in.</value>
    [DataMember(Name="id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "id")]
    public string Id { get; set; }

    /// <summary>
    /// The processed phone number. If the phone number is recognized as valid, then the returned value is the same as presented by the `E164` format. If the phone number is not recognized, the service attempts to make individual `phone_number` values as comparable as possible, by applying the basic logic of the `E164` format, that is, trimming of white spaces, dashes, dots, and so forth.  The logic behind this is that even in cases where the service is unable to validate the phone number, the resulting string may be more useful in further data quality analysis. For example, the string will have a higher degree of similarity to other phone numbers to which it may be compared. 
    /// </summary>
    /// <value>The processed phone number. If the phone number is recognized as valid, then the returned value is the same as presented by the `E164` format. If the phone number is not recognized, the service attempts to make individual `phone_number` values as comparable as possible, by applying the basic logic of the `E164` format, that is, trimming of white spaces, dashes, dots, and so forth.  The logic behind this is that even in cases where the service is unable to validate the phone number, the resulting string may be more useful in further data quality analysis. For example, the string will have a higher degree of similarity to other phone numbers to which it may be compared. </value>
    [DataMember(Name="phone_number", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "phone_number")]
    public string PhoneNumber { get; set; }

    /// <summary>
    /// Gets or Sets Formats
    /// </summary>
    [DataMember(Name="formats", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "formats")]
    public PhoneValidationResponseRecordPhoneNumberFormats Formats { get; set; }

    /// <summary>
    /// The type of phone number.
    /// </summary>
    /// <value>The type of phone number.</value>
    [DataMember(Name="phone_type", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "phone_type")]
    public string PhoneType { get; set; }

    /// <summary>
    /// Gets or Sets PhoneParts
    /// </summary>
    [DataMember(Name="phone_parts", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "phone_parts")]
    public PhoneValidationResponseRecordPhoneNumberPhoneParts PhoneParts { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class PhoneValidationResponseRecordPhoneNumber {\n");
      sb.Append("  Id: ").Append(Id).Append("\n");
      sb.Append("  PhoneNumber: ").Append(PhoneNumber).Append("\n");
      sb.Append("  Formats: ").Append(Formats).Append("\n");
      sb.Append("  PhoneType: ").Append(PhoneType).Append("\n");
      sb.Append("  PhoneParts: ").Append(PhoneParts).Append("\n");
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
