/* 
 * Walk Sequence
 *
 * The Walk Sequence service performs USPS® CASS™ processing and appends USPS Walk Sequence numbers to mail pieces. Mailings that target specific ZIP Codes or neighborhoods are good candidates for the Walk Sequence service.  A mailing that is sorted in Walk Sequence order may qualify for USPS High Density and Saturation mailing discounts. Adding Walk Sqeunce data to mailings can lower your postage costs.  ## Job execution  The general flow to execute a batch job is to:  1. Create a job, specifying its configuration properties, and upload and download schema (input fields and output fields). You cannot change the job's configuration after creation.  2. Upload the records you want to process via one or more calls to the `/jobs/{job_id}/records` endpoint. Records are uploaded in blocks. The records are stored on the server for processing.  3. Initiate processing by calling the `/jobs/{job_id}/_run` endpoint. 4. Wait for the job status to be updated to `SUCCESS` or `FAILED`. 5. Download the records. 6. Delete the job when you are done by requesting a `DELETE` on the `/jobs/{job_id}` endpoint, which removes both the input and output records.  ## Records  The upload of records must be complete prior to running the service. Records are categorized as `input` or `output`. The schema (fields and order) of the records is defined via the job creation call.  ## Pagination Records for a job are broken into pages (`page_id`) for retrieval. The collection of record page IDs is available via the `/jobs/{job_id}/records/pages` endpoint. Retrieve this collection as a precursor to downloading records. Each record page can then be retrieved by the client. Page IDs are immutable and can be retrieved in parallel. Record pages may also be retrieved multiple times if needed. 
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
    /// Controls where any address unit information (for example, apartment or suite number) is to be placed.
    /// </summary>
    /// <value>Controls where any address unit information (for example, apartment or suite number) is to be placed.</value>
    
    [JsonConverter(typeof(StringEnumConverter))]
    
    public enum UnitPlacement
    {
        
        /// <summary>
        /// Enum Ondeliveryline for value: on_delivery_line
        /// </summary>
        [EnumMember(Value = "on_delivery_line")]
        Ondeliveryline = 1,
        
        /// <summary>
        /// Enum Abovedeliverylineifempty for value: above_delivery_line_if_empty
        /// </summary>
        [EnumMember(Value = "above_delivery_line_if_empty")]
        Abovedeliverylineifempty = 2,
        
        /// <summary>
        /// Enum Abovedeliverylinealways for value: above_delivery_line_always
        /// </summary>
        [EnumMember(Value = "above_delivery_line_always")]
        Abovedeliverylinealways = 3
    }
}
