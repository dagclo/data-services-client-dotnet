using System.Runtime.Serialization;
using System.Text;
using Newtonsoft.Json;

namespace Quadient.DataServices.Model.Email {

  /// <summary>
  /// Configuration of the correction request.
  /// </summary>
  [DataContract]
  public class EmailValidationRequestConfiguration {
    /// <summary>
    /// Default behavior outputs records in the same order they were entered. Disable that behavior for a potential increase in speed.
    /// </summary>
    /// <value>Default behavior outputs records in the same order they were entered. Disable that behavior for a potential increase in speed.</value>
    [DataMember(Name="disable_ordering", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "disable_ordering")]
    public bool? DisableOrdering { get; set; }

    /// <summary>
    /// Defines which validation method to use. \"Full\" (default) validates an email address  against multiple registries of email addresses, good and bad,  that are confirmed to be in use. \"Fast\" validates an email address only against Quadient-based information.
    /// </summary>
    /// <value>Defines which validation method to use. \"Full\" (default) validates an email address  against multiple registries of email addresses, good and bad,  that are confirmed to be in use. \"Fast\" validates an email address only against Quadient-based information.</value>
    [DataMember(Name="processing_style", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "processing_style")]
    public string ProcessingStyle { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class EmailValidationRequestConfiguration {\n");
      sb.Append("  DisableOrdering: ").Append(DisableOrdering).Append("\n");
      sb.Append("  ProcessingStyle: ").Append(ProcessingStyle).Append("\n");
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
