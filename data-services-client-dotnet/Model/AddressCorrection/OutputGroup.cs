using System.Runtime.Serialization;
using System.Text;
using Newtonsoft.Json;

namespace Quadient.DataServices.Model.AddressCorrection {

  /// <summary>
  /// Defines a group of output fields that can be enabled on demand. The following output groups are available:  * &#x60;presort&#x60; contains output fields that are necessary for performing mail sortation (&#39;presort&#39;) with the resulting addresses. Due to the country-specific nature of presorting, the fields in this output group varies by country. * &#x60;geocodes&#x60; contains output fields that are used for specifying geographical coordinates on a map. * &#x60;move_update&#x60; contains output fields that are needed for performing move_update processing. * &#x60;address_traits&#x60; contains additional traits orelements of an address. 
  /// </summary>
  [DataContract]
  public class OutputGroup {

    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class OutputGroup {\n");
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
