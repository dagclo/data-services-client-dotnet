using System.Runtime.Serialization;
using System.Text;
using Newtonsoft.Json;

namespace Quadient.DataServices.Model.Name {

  /// <summary>
  /// 
  /// </summary>
  [DataContract]
  public class NameDetailsIn {
    /// <summary>
    /// A greeting used in a letter or other written or non-written communication ([Read more](https://en.wikipedia.org/wiki/Salutation)). 
    /// </summary>
    /// <value>A greeting used in a letter or other written or non-written communication ([Read more](https://en.wikipedia.org/wiki/Salutation)). </value>
    [DataMember(Name="salutation", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "salutation")]
    public string Salutation { get; set; }

    /// <summary>
    /// A title that conveys esteem or respect when used in addressing or referring to a person ([Read more](https://en.wikipedia.org/wiki/Honorific)). 
    /// </summary>
    /// <value>A title that conveys esteem or respect when used in addressing or referring to a person ([Read more](https://en.wikipedia.org/wiki/Honorific)). </value>
    [DataMember(Name="honorific", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "honorific")]
    public string Honorific { get; set; }

    /// <summary>
    /// A title or function, typically professional or academic, that comes before the name parts. 
    /// </summary>
    /// <value>A title or function, typically professional or academic, that comes before the name parts. </value>
    [DataMember(Name="title_before", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "title_before")]
    public string TitleBefore { get; set; }

    /// <summary>
    /// One or more name parts or initials that make up what is commonly known as the \"given name\" or \"first name\" of the person. 
    /// </summary>
    /// <value>One or more name parts or initials that make up what is commonly known as the \"given name\" or \"first name\" of the person. </value>
    [DataMember(Name="given_name", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "given_name")]
    public string GivenName { get; set; }

    /// <summary>
    /// One or more name parts or initials that make up what is commonly known as the \"middle name\" of the person. 
    /// </summary>
    /// <value>One or more name parts or initials that make up what is commonly known as the \"middle name\" of the person. </value>
    [DataMember(Name="middle_name", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "middle_name")]
    public string MiddleName { get; set; }

    /// <summary>
    /// One or more name parts or initials that make up what is commonly known as the \"family name\", \"last name\" or \"surname\" of the person. 
    /// </summary>
    /// <value>One or more name parts or initials that make up what is commonly known as the \"family name\", \"last name\" or \"surname\" of the person. </value>
    [DataMember(Name="family_name", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "family_name")]
    public string FamilyName { get; set; }

    /// <summary>
    /// A title related to a person's family or generation status. 
    /// </summary>
    /// <value>A title related to a person's family or generation status. </value>
    [DataMember(Name="generation_title", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "generation_title")]
    public string GenerationTitle { get; set; }

    /// <summary>
    /// A title, typically professional or academic, that comes after the name parts. 
    /// </summary>
    /// <value>A title, typically professional or academic, that comes after the name parts. </value>
    [DataMember(Name="title_after", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "title_after")]
    public string TitleAfter { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class NameDetailsIn {\n");
      sb.Append("  Salutation: ").Append(Salutation).Append("\n");
      sb.Append("  Honorific: ").Append(Honorific).Append("\n");
      sb.Append("  TitleBefore: ").Append(TitleBefore).Append("\n");
      sb.Append("  GivenName: ").Append(GivenName).Append("\n");
      sb.Append("  MiddleName: ").Append(MiddleName).Append("\n");
      sb.Append("  FamilyName: ").Append(FamilyName).Append("\n");
      sb.Append("  GenerationTitle: ").Append(GenerationTitle).Append("\n");
      sb.Append("  TitleAfter: ").Append(TitleAfter).Append("\n");
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
