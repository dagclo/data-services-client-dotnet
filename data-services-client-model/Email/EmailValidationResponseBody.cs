using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;
using Newtonsoft.Json;

namespace Quadient.DataServices.Model.Email {

  /// <summary>
  /// 
  /// </summary>
  [DataContract]
  public class EmailValidationResponseBody {
    /// <summary>
    /// Gets or Sets EmailRecords
    /// </summary>
    [DataMember(Name="email_records", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "email_records")]
    public List<EmailValidationResponse> EmailRecords { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class EmailValidationResponseBody {\n");
      sb.Append("  EmailRecords: ").Append(EmailRecords).Append("\n");
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
