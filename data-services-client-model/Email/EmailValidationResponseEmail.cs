using System.Runtime.Serialization;
using System.Text;
using Newtonsoft.Json;

namespace Quadient.DataServices.Model.Email {

  /// <summary>
  /// 
  /// </summary>
  [DataContract]
  public class EmailValidationResponseEmail {
    /// <summary>
    /// User-specified reference string as passed in.
    /// </summary>
    /// <value>User-specified reference string as passed in.</value>
    [DataMember(Name="id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "id")]
    public string Id { get; set; }

    /// <summary>
    /// The processed email address, adjusted as necessary.
    /// </summary>
    /// <value>The processed email address, adjusted as necessary.</value>
    [DataMember(Name="email", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "email")]
    public string Email { get; set; }

    /// <summary>
    /// The email address exists, but deliverability is unlikely.
    /// </summary>
    /// <value>The email address exists, but deliverability is unlikely.</value>
    [DataMember(Name="is_email_flagged", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "is_email_flagged")]
    public bool? IsEmailFlagged { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class EmailValidationResponseEmail {\n");
      sb.Append("  Id: ").Append(Id).Append("\n");
      sb.Append("  Email: ").Append(Email).Append("\n");
      sb.Append("  IsEmailFlagged: ").Append(IsEmailFlagged).Append("\n");
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
