/* 
 * US-Appends
 *
 * Provides Suppression information to your US contacts. This service offers the ability to update addresses of persons who have moved, inform you in case of incarceration, death or if they have opted in to a do-not-mail registry.  ## Job execution  The general flow to execute a batch job is to:  1. Create a job, specifying configuration properties, upload and download schema (input fields and output fields). Job configuration cannot be changed after creation.  2. Upload records to process via one or more calls to the `/jobs/{job_id}/records` endpoint. Records are uploaded in blocks. The records are stored on the server for processing.  3. Initiate processing by calling the `/jobs/{job_id}/_run` endpoint. 4. Wait for the job status to enter `SUCCESS` or `FAILED`. 5. Download the records. 6. Delete job when you are done with it via a `DELETE` on the `/jobs/{job_id}` endpoint, removing input and output records.  ## Records  Records must be uploaded completely prior to running the service. Records are categorized as `input` or `output`. The schema (fields and order) of the records are defined via the job creation call.  ## Pagination Records for a job are broken into pages (`page_id`) for retrieval. The collection of record page ids are available via the `/jobs/{job_id}/records/pages` endpoint. Retrieve this collection as a precursor to downloading records. Each record page can then be retrieved by the client. Page IDs are immutable and can be retrieved in parallel. Record pages may also be retrieved multiple times if needed. 
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

namespace Quadient.DataServies.Model.UsBatch
{
    /// <summary>
    /// Defines USAppendsOutputField
    /// </summary>
    
    [JsonConverter(typeof(StringEnumConverter))]
    
    public enum USAppendsOutputField
    {
        
        id = 1,
        
        is_do_not_mail = 2,
        
        is_prison = 3,
        
        is_deceased = 4,
        
        is_nursing_home = 5,
        
        is_bankruptcy = 6,
        
        deceased_date_of_death = 7,
        
        deceased_date_of_birth = 8,
        
        apartment_unit_information = 9,
        
        apartment_address_line = 10,
        
        outcome_codes = 11,
        
        custom_1 = 12,
        
        custom_2 = 13,
        
        custom_3 = 14,
        
        custom_4 = 15,
        
        custom_5 = 16,
        
        custom_6 = 17,
        
        custom_7 = 18,
        
        custom_8 = 19,
        
        custom_9 = 20,
        
        custom_10 = 21
    }
    
}
