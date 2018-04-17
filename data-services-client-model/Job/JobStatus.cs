using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace Quadient.DataServices.Model.Job {

  /// <summary>
  /// Defines the high-level status of a job. A job does not necessarily go through all of the states. The default initial state is &#39;CREATED&#39;. A job may be in &#x60;READY_TO_RUN&#x60; state if it has been configured and scheduled to run, but not yet picked up by any processor/worker service yet. The &#x60;STARTED&#x60; state indicates that the job is actively running. Conversely the &#x60;WAITING&#x60; state indicates that the job has started but is waiting for an external resource to provide input before the job can resume. Finally, &#x60;SUCCESS&#x60;, &#x60;CANCELLED&#x60;, &#x60;DELETED&#x60; and &#x60;FAILURE&#x60; are end states, indicating whether the job has finished successfully, was cancelled by the user, was deleted or is in a failure state.
  /// </summary>
  [DataContract]
  public class JobStatus {

    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class JobStatus {\n");
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
