/* 
 * Walk Sequence
 *
 * Performs USPS CASS processing and appends USPS Walk Sequence numbers to mail pieces. Properly walk sequenced mailings may qualify for USPS mailing discounts.  ## Job execution  The general flow to execute a batch job is to:  1. Create a job, specifying configuration properties, upload and download schema (input fields and output fields). Job configuration cannot be changed after creation.  2. Upload records to process via one or more calls to the `/jobs/{job_id}/records` endpoint. Records are uploaded in blocks. The records are stored on the server for processing.  3. Initiate processing by calling the `/jobs/{job_id}/_run` endpoint. 4. Wait for the job status to enter `SUCCESS` or `FAILED`. 5. Download the records. 6. Delete job when you are done with it via a `DELETE` on the `/jobs/{job_id}` endpoint, removing input and output records.  ## Records  Records must be uploaded completely prior to running the service. Records are categorized as `input` or `output`. The schema (fields and order) of the records are defined via the job creation call.  ## Pagination Records for a job are broken into pages (`page_id`) for retrieval. The collection of record page ids are available via the `/jobs/{job_id}/records/pages` endpoint. Retrieve this collection as a precursor to downloading records. Each record page can then be retrieved by the client. Page IDs are immutable and can be retrieved in parallel. Record pages may also be retrieved multiple times if needed. 
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
    /// Defines JobStatus
    /// </summary>
    
    [JsonConverter(typeof(StringEnumConverter))]
    
    public enum JobStatus
    {
        
        /// <summary>
        /// Enum CREATED for value: CREATED
        /// </summary>
        [EnumMember(Value = "CREATED")]
        CREATED = 1,
        
        /// <summary>
        /// Enum READYTORUN for value: READY_TO_RUN
        /// </summary>
        [EnumMember(Value = "READY_TO_RUN")]
        READYTORUN = 2,
        
        /// <summary>
        /// Enum RUNNING for value: RUNNING
        /// </summary>
        [EnumMember(Value = "RUNNING")]
        RUNNING = 3,
        
        /// <summary>
        /// Enum SUCCESS for value: SUCCESS
        /// </summary>
        [EnumMember(Value = "SUCCESS")]
        SUCCESS = 4,
        
        /// <summary>
        /// Enum FAILURE for value: FAILURE
        /// </summary>
        [EnumMember(Value = "FAILURE")]
        FAILURE = 5,
        
        /// <summary>
        /// Enum DELETED for value: DELETED
        /// </summary>
        [EnumMember(Value = "DELETED")]
        DELETED = 6
    }
}
