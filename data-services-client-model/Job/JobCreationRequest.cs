using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace Quadient.DataServices.Model.Job {

  /// <summary>
  /// 
  /// </summary>
  [DataContract]
  public class JobCreationRequest {
    /// <summary>
    /// The originating product/application/service for which this job is being created.
    /// </summary>
    /// <value>The originating product/application/service for which this job is being created.</value>
    [DataMember(Name="origin", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "origin")]
    public string Origin { get; set; }

    /// <summary>
    /// The user_id of the job's owner.
    /// </summary>
    /// <value>The user_id of the job's owner.</value>
    [DataMember(Name="owner", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "owner")]
    public string Owner { get; set; }

    /// <summary>
    /// The tenant the job is associated with.  Required if user has multiple tenants, optional otherwise.
    /// </summary>
    /// <value>The tenant the job is associated with.  Required if user has multiple tenants, optional otherwise.</value>
    [DataMember(Name="tenant", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "tenant")]
    public string Tenant { get; set; }

    /// <summary>
    /// The (optional) parent job's job_id. This may be specified if the job should have a declared child-relationship with a parent job.
    /// </summary>
    /// <value>The (optional) parent job's job_id. This may be specified if the job should have a declared child-relationship with a parent job.</value>
    [DataMember(Name="parent_job", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "parent_job")]
    public string ParentJob { get; set; }

    /// <summary>
    /// An array of the expected services that this job will be consuming, referred to by their service_id.
    /// </summary>
    /// <value>An array of the expected services that this job will be consuming, referred to by their service_id.</value>
    [DataMember(Name="expected_services", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "expected_services")]
    public List<string> ExpectedServices { get; set; }

    /// <summary>
    /// The expected amount of records that will be processed by the `expected_services` in this job
    /// </summary>
    /// <value>The expected amount of records that will be processed by the `expected_services` in this job</value>
    [DataMember(Name="expected_record_count", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "expected_record_count")]
    public long? ExpectedRecordCount { get; set; }

    /// <summary>
    /// Gets or Sets JobStatus
    /// </summary>
    [DataMember(Name="job_status", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "job_status")]
    public JobStatus JobStatus { get; set; }

    /// <summary>
    /// Any additional details about the job.
    /// </summary>
    /// <value>Any additional details about the job.</value>
    [DataMember(Name="additional_details", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "additional_details")]
    public Object AdditionalDetails { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class JobCreationRequest {\n");
      sb.Append("  Origin: ").Append(Origin).Append("\n");
      sb.Append("  Owner: ").Append(Owner).Append("\n");
      sb.Append("  Tenant: ").Append(Tenant).Append("\n");
      sb.Append("  ParentJob: ").Append(ParentJob).Append("\n");
      sb.Append("  ExpectedServices: ").Append(ExpectedServices).Append("\n");
      sb.Append("  ExpectedRecordCount: ").Append(ExpectedRecordCount).Append("\n");
      sb.Append("  JobStatus: ").Append(JobStatus).Append("\n");
      sb.Append("  AdditionalDetails: ").Append(AdditionalDetails).Append("\n");
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
