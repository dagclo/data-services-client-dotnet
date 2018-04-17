using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;
using Newtonsoft.Json;

namespace Quadient.DataServices.Model.Email {

  /// <summary>
  /// 
  /// </summary>
  [DataContract]
  public class EmailValidationRequest {
    /// <summary>
    /// Gets or Sets Configuration
    /// </summary>
    [DataMember(Name="configuration", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "configuration")]
    public EmailValidationRequestConfiguration Configuration { get; set; }

    /// <summary>
    /// The set of email addresses to be processed for validity.
    /// </summary>
    /// <value>The set of email addresses to be processed for validity.</value>
    [DataMember(Name="email_records", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "email_records")]
    public List<EmailAddress> EmailRecords { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class EmailValidationRequest {\n");
      sb.Append("  Configuration: ").Append(Configuration).Append("\n");
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
