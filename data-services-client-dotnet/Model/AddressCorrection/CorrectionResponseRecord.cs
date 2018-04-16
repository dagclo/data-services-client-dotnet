using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;
using Newtonsoft.Json;

namespace Quadient.DataServices.Model.AddressCorrection {

  /// <summary>
  /// 
  /// </summary>
  [DataContract]
  public class CorrectionResponseRecord {
    /// <summary>
    /// Gets or Sets Address
    /// </summary>
    [DataMember(Name="address", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "address")]
    public CorrectionResponseAddress Address { get; set; }

    /// <summary>
    /// Gets or Sets Geocodes
    /// </summary>
    [DataMember(Name="geocodes", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "geocodes")]
    public CorrectionResponseRecordGeocodes Geocodes { get; set; }

    /// <summary>
    /// Defines an additional output group of fields for presorting, enabled using the `output_groups` configuration setting.
    /// </summary>
    /// <value>Defines an additional output group of fields for presorting, enabled using the `output_groups` configuration setting.</value>
    [DataMember(Name="presort", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "presort")]
    public Object Presort { get; set; }

    /// <summary>
    /// Gets or Sets MoveUpdate
    /// </summary>
    [DataMember(Name="move_update", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "move_update")]
    public CorrectionResponseRecordMoveUpdate MoveUpdate { get; set; }

    /// <summary>
    /// Gets or Sets AddressTraits
    /// </summary>
    [DataMember(Name="address_traits", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "address_traits")]
    public CorrectionResponseRecordAddressTraits AddressTraits { get; set; }

    /// <summary>
    /// An array of suggested addresses, provided for cases in which the processing is unable to determine the address definitively, but finds candidates for suggestion. 
    /// </summary>
    /// <value>An array of suggested addresses, provided for cases in which the processing is unable to determine the address definitively, but finds candidates for suggestion. </value>
    [DataMember(Name="suggestions", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "suggestions")]
    public List<CorrectionResponseAddress> Suggestions { get; set; }

    /// <summary>
    /// Gets or Sets Outcome
    /// </summary>
    [DataMember(Name="outcome", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "outcome")]
    public OutcomeDefinition Outcome { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class CorrectionResponseRecord {\n");
      sb.Append("  Address: ").Append(Address).Append("\n");
      sb.Append("  Geocodes: ").Append(Geocodes).Append("\n");
      sb.Append("  Presort: ").Append(Presort).Append("\n");
      sb.Append("  MoveUpdate: ").Append(MoveUpdate).Append("\n");
      sb.Append("  AddressTraits: ").Append(AddressTraits).Append("\n");
      sb.Append("  Suggestions: ").Append(Suggestions).Append("\n");
      sb.Append("  Outcome: ").Append(Outcome).Append("\n");
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
