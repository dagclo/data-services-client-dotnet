/* 
 * US Move Update
 *
 * The US Move Update service offers the ability to update addresses of persons and organizations who have moved within the United States.  ## Job execution  The general flow to execute a batch job is to:  1. Create a job, specifying its configuration properties, and upload and download schema (input fields and output fields). You cannot change the job's configuration after creation.  2. Upload records to process via one or more calls to the `/jobs/{job_id}/records` endpoint. Records are uploaded in blocks. The records are stored on the server for processing.  3. Initiate processing by calling the `/jobs/{job_id}/_run` endpoint. 4. Wait for the job status to be updated to `SUCCESS` or `FAILED`. 5. Download the records. 6. Delete job when you are done by requesting a `DELETE` on the `/jobs/{job_id}` endpoint, which removes both input and output records.  ## Records  The upload of records must be complete prior to running the service. Records are categorized as `input` or `output`. The schema (fields and order) of the records is defined via the job creation call.  ## Pagination Records for a job are broken into pages (`page_id`) for retrieval. The collection of record page IDs is available via the `/jobs/{job_id}/records/pages` endpoint. Retrieve this collection as a precursor to downloading records. Each record page can then be retrieved by the client. Page IDs are immutable and can be retrieved in parallel. Record pages may also be retrieved multiple times if needed. 
 *
 * OpenAPI spec version: 0.1.0
 * 
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */

using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.ComponentModel.DataAnnotations;
using SwaggerDateConverter = Quadient.DataServices.Model.Client.SwaggerDateConverter;

namespace Quadient.DataServices.Model.UsBatch
{
    /// <summary>
    /// &#x60;A1&#x60; - Valid address &#x60;C1&#x60; - Individual move found &#x60;C2&#x60; - Family move found &#x60;C3&#x60; - Organization move found &#x60;C4&#x60; - Moved, but no forwarding address provided &#x60;E1&#x60; - Address not valid 
    /// </summary>
    /// <value>&#x60;A1&#x60; - Valid address &#x60;C1&#x60; - Individual move found &#x60;C2&#x60; - Family move found &#x60;C3&#x60; - Organization move found &#x60;C4&#x60; - Moved, but no forwarding address provided &#x60;E1&#x60; - Address not valid </value>
    
    [JsonConverter(typeof(StringEnumConverter))]
    
    public enum MoveUpdateOutcomeCode
    {
        
        /// <summary>
        /// Enum A1 for value: A1
        /// </summary>
        [EnumMember(Value = "A1")]
        A1 = 1,
        
        /// <summary>
        /// Enum C1 for value: C1
        /// </summary>
        [EnumMember(Value = "C1")]
        C1 = 2,
        
        /// <summary>
        /// Enum C2 for value: C2
        /// </summary>
        [EnumMember(Value = "C2")]
        C2 = 3,
        
        /// <summary>
        /// Enum C3 for value: C3
        /// </summary>
        [EnumMember(Value = "C3")]
        C3 = 4,
        
        /// <summary>
        /// Enum C4 for value: C4
        /// </summary>
        [EnumMember(Value = "C4")]
        C4 = 5,
        
        /// <summary>
        /// Enum E1 for value: E1
        /// </summary>
        [EnumMember(Value = "E1")]
        E1 = 6
    }
}
