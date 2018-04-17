using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;
using Newtonsoft.Json;

namespace Quadient.DataServices.Model.Name {

  /// <summary>
  /// 
  /// </summary>
  [DataContract]
  public class NameDetailsOut : NameDetailsIn {
    /// <summary>
    /// An optional array of potential nicknames for the name parts of the person. 
    /// </summary>
    /// <value>An optional array of potential nicknames for the name parts of the person. </value>
    [DataMember(Name="nicknames", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "nicknames")]
    public List<NicknameItem> Nicknames { get; set; }

    /// <summary>
    /// One or more words that serve as the prefix to the first family name of the person. 
    /// </summary>
    /// <value>One or more words that serve as the prefix to the first family name of the person. </value>
    [DataMember(Name="family_name_prefix", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "family_name_prefix")]
    public string FamilyNamePrefix { get; set; }

    /// <summary>
    /// If the family name contains prefixes, this field provides the family name without any prefixes. 
    /// </summary>
    /// <value>If the family name contains prefixes, this field provides the family name without any prefixes. </value>
    [DataMember(Name="family_name_without_prefix", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "family_name_without_prefix")]
    public string FamilyNameWithoutPrefix { get; set; }

    /// <summary>
    /// The representation of the full name without any salutation, honorific or title elements. This always equates to the concatenation of `given_name`, `middle_name`, `family_name`, and `generation_title`. The treatment of the `generation_title` element depends on the `generation_title_handling` configuration. 
    /// </summary>
    /// <value>The representation of the full name without any salutation, honorific or title elements. This always equates to the concatenation of `given_name`, `middle_name`, `family_name`, and `generation_title`. The treatment of the `generation_title` element depends on the `generation_title_handling` configuration. </value>
    [DataMember(Name="full_name", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "full_name")]
    public string FullName { get; set; }

    /// <summary>
    /// The gender of the person. 
    /// </summary>
    /// <value>The gender of the person. </value>
    [DataMember(Name="gender", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "gender")]
    public string Gender { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class NameDetailsOut {\n");
      sb.Append("  Nicknames: ").Append(Nicknames).Append("\n");
      sb.Append("  FamilyNamePrefix: ").Append(FamilyNamePrefix).Append("\n");
      sb.Append("  FamilyNameWithoutPrefix: ").Append(FamilyNameWithoutPrefix).Append("\n");
      sb.Append("  FullName: ").Append(FullName).Append("\n");
      sb.Append("  Gender: ").Append(Gender).Append("\n");
      sb.Append("}\n");
      return sb.ToString();
    }

    /// <summary>
    /// Get the JSON string presentation of the object
    /// </summary>
    /// <returns>JSON string presentation of the object</returns>
    public  new string ToJson() {
      return JsonConvert.SerializeObject(this, Formatting.Indented);
    }

}
}
