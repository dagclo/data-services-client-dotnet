using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;
using Newtonsoft.Json;

namespace Quadient.DataServices.Model.Address {

  /// <summary>
  /// 
  /// </summary>
  [DataContract]
  public class BaseAddress {
    /// <summary>
    /// The name of the organization associated with the address.
    /// </summary>
    /// <value>The name of the organization associated with the address.</value>
    [DataMember(Name="organization", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "organization")]
    public string Organization { get; set; }

    /// <summary>
    /// The address lines, which contain street address information such as street name, house number, apartment number, and so forth.
    /// </summary>
    /// <value>The address lines, which contain street address information such as street name, house number, apartment number, and so forth.</value>
    [DataMember(Name="address_lines", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "address_lines")]
    public List<string> AddressLines { get; set; }

    /// <summary>
    /// The name of the city or post town.
    /// </summary>
    /// <value>The name of the city or post town.</value>
    [DataMember(Name="city", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "city")]
    public string City { get; set; }

    /// <summary>
    /// The name of the county.
    /// </summary>
    /// <value>The name of the county.</value>
    [DataMember(Name="county", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "county")]
    public string County { get; set; }

    /// <summary>
    /// The name or code of the state or province. For the United States and Canada, the 2-letter state  or province code is preferred and is returned in corrected responses.
    /// </summary>
    /// <value>The name or code of the state or province. For the United States and Canada, the 2-letter state  or province code is preferred and is returned in corrected responses.</value>
    [DataMember(Name="province_or_state", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "province_or_state")]
    public string ProvinceOrState { get; set; }

    /// <summary>
    /// The postal code of the address.
    /// </summary>
    /// <value>The postal code of the address.</value>
    [DataMember(Name="postal_code", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "postal_code")]
    public string PostalCode { get; set; }

    /// <summary>
    /// The country code or name. The ISO 3166 2-letter country code is preferred and is returned in corrected responses.
    /// </summary>
    /// <value>The country code or name. The ISO 3166 2-letter country code is preferred and is returned in corrected responses.</value>
    [DataMember(Name="country", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "country")]
    public string Country { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class BaseAddress {\n");
      sb.Append("  Organization: ").Append(Organization).Append("\n");
      sb.Append("  AddressLines: ").Append(AddressLines).Append("\n");
      sb.Append("  City: ").Append(City).Append("\n");
      sb.Append("  County: ").Append(County).Append("\n");
      sb.Append("  ProvinceOrState: ").Append(ProvinceOrState).Append("\n");
      sb.Append("  PostalCode: ").Append(PostalCode).Append("\n");
      sb.Append("  Country: ").Append(Country).Append("\n");
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
