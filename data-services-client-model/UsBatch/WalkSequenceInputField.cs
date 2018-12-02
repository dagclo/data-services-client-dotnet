/* 
 * Walk Sequence
 *
 * The Walk Sequence service performs USPS® CASS™ processing and appends USPS Walk Sequence numbers to mail pieces. Mailings that target specific ZIP Codes or neighborhoods are good candidates for the Walk Sequence service.  A mailing that is sorted in Walk Sequence order may qualify for USPS High Density and Saturation mailing discounts. Adding Walk Sqeunce data to mailings can lower your postage costs.  ## Job execution  The general flow to execute a batch job is to:  1. Create a job, specifying its configuration properties, and upload and download schema (input fields and output fields). You cannot change the job's configuration after creation.  2. Upload the records you want to process via one or more calls to the `/jobs/{job_id}/records` endpoint. Records are uploaded in blocks. The records are stored on the server for processing.  3. Initiate processing by calling the `/jobs/{job_id}/_run` endpoint. 4. Wait for the job status to be updated to `SUCCESS` or `FAILED`. 5. Download the records. 6. Delete the job when you are done by requesting a `DELETE` on the `/jobs/{job_id}` endpoint, which removes both the input and output records.  ## Records  The upload of records must be complete prior to running the service. Records are categorized as `input` or `output`. The schema (fields and order) of the records is defined via the job creation call.  ## Pagination Records for a job are broken into pages (`page_id`) for retrieval. The collection of record page IDs is available via the `/jobs/{job_id}/records/pages` endpoint. Retrieve this collection as a precursor to downloading records. Each record page can then be retrieved by the client. Page IDs are immutable and can be retrieved in parallel. Record pages may also be retrieved multiple times if needed. 
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
    /// Defines WalkSequenceInputField
    /// </summary>
    
    [JsonConverter(typeof(StringEnumConverter))]
    
    public enum WalkSequenceInputField
    {
        
        /// <summary>
        /// Enum Id for value: id
        /// </summary>
        [EnumMember(Value = "id")]
        Id = 1,
        
        /// <summary>
        /// Enum Addressblock for value: address_block
        /// </summary>
        [EnumMember(Value = "address_block")]
        Addressblock = 2,
        
        /// <summary>
        /// Enum Organization for value: organization
        /// </summary>
        [EnumMember(Value = "organization")]
        Organization = 3,
        
        /// <summary>
        /// Enum Urbanization for value: urbanization
        /// </summary>
        [EnumMember(Value = "urbanization")]
        Urbanization = 4,
        
        /// <summary>
        /// Enum Addressline1 for value: address_line_1
        /// </summary>
        [EnumMember(Value = "address_line_1")]
        Addressline1 = 5,
        
        /// <summary>
        /// Enum Addressline2 for value: address_line_2
        /// </summary>
        [EnumMember(Value = "address_line_2")]
        Addressline2 = 6,
        
        /// <summary>
        /// Enum Citystatezip for value: city_state_zip
        /// </summary>
        [EnumMember(Value = "city_state_zip")]
        Citystatezip = 7,
        
        /// <summary>
        /// Enum City for value: city
        /// </summary>
        [EnumMember(Value = "city")]
        City = 8,
        
        /// <summary>
        /// Enum State for value: state
        /// </summary>
        [EnumMember(Value = "state")]
        State = 9,
        
        /// <summary>
        /// Enum Zipcode for value: zip_code
        /// </summary>
        [EnumMember(Value = "zip_code")]
        Zipcode = 10,
        
        /// <summary>
        /// Enum Country for value: country
        /// </summary>
        [EnumMember(Value = "country")]
        Country = 11,
        
        /// <summary>
        /// Enum Custom1 for value: custom_1
        /// </summary>
        [EnumMember(Value = "custom_1")]
        Custom1 = 12,
        
        /// <summary>
        /// Enum Custom2 for value: custom_2
        /// </summary>
        [EnumMember(Value = "custom_2")]
        Custom2 = 13,
        
        /// <summary>
        /// Enum Custom3 for value: custom_3
        /// </summary>
        [EnumMember(Value = "custom_3")]
        Custom3 = 14,
        
        /// <summary>
        /// Enum Custom4 for value: custom_4
        /// </summary>
        [EnumMember(Value = "custom_4")]
        Custom4 = 15,
        
        /// <summary>
        /// Enum Custom5 for value: custom_5
        /// </summary>
        [EnumMember(Value = "custom_5")]
        Custom5 = 16,
        
        /// <summary>
        /// Enum Custom6 for value: custom_6
        /// </summary>
        [EnumMember(Value = "custom_6")]
        Custom6 = 17,
        
        /// <summary>
        /// Enum Custom7 for value: custom_7
        /// </summary>
        [EnumMember(Value = "custom_7")]
        Custom7 = 18,
        
        /// <summary>
        /// Enum Custom8 for value: custom_8
        /// </summary>
        [EnumMember(Value = "custom_8")]
        Custom8 = 19,
        
        /// <summary>
        /// Enum Custom9 for value: custom_9
        /// </summary>
        [EnumMember(Value = "custom_9")]
        Custom9 = 20,
        
        /// <summary>
        /// Enum Custom10 for value: custom_10
        /// </summary>
        [EnumMember(Value = "custom_10")]
        Custom10 = 21
    }
}
