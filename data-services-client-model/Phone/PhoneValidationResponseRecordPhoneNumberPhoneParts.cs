using System.Runtime.Serialization;
using System.Text;
using Newtonsoft.Json;

namespace Quadient.DataServices.Model.Phone {

  /// <summary>
  /// 
  /// </summary>
  [DataContract]
  public class PhoneValidationResponseRecordPhoneNumberPhoneParts {
    /// <summary>
    /// Gets or Sets CountryCallingCode
    /// </summary>
    [DataMember(Name="country_calling_code", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "country_calling_code")]
    public int? CountryCallingCode { get; set; }

    /// <summary>
    /// Gets or Sets NationalNumber
    /// </summary>
    [DataMember(Name="national_number", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "national_number")]
    public long? NationalNumber { get; set; }

    /// <summary>
    /// Gets or Sets Extension
    /// </summary>
    [DataMember(Name="extension", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "extension")]
    public string Extension { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class PhoneValidationResponseRecordPhoneNumberPhoneParts {\n");
      sb.Append("  CountryCallingCode: ").Append(CountryCallingCode).Append("\n");
      sb.Append("  NationalNumber: ").Append(NationalNumber).Append("\n");
      sb.Append("  Extension: ").Append(Extension).Append("\n");
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
