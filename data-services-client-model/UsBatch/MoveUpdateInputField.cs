/* 
 * US Move Update
 *
 * This service offers the ability to update addresses of organizations and persons who have moved in the United States.  ## Job execution  The general flow to execute a batch job is to:  1. Create a job, specifying configuration properties, upload and download schema (input fields and output fields). Job configuration cannot be changed after creation.  2. Upload records to process via one or more calls to the `/jobs/{job_id}/records` endpoint. Records are uploaded in blocks. The records are stored on the server for processing.  3. Initiate processing by calling the `/jobs/{job_id}/_run` endpoint. 4. Wait for the job status to enter `SUCCESS` or `FAILED`. 5. Download the records. 6. Delete job when you are done with it via a `DELETE` on the `/jobs/{job_id}` endpoint, removing input and output records.  ## Records  Records must be uploaded completely prior to running the service. Records are categorized as `input` or `output`. The schema (fields and order) of the records are defined via the job creation call.  ## Paginationchange Records for a job are broken into pages (`page_id`) for retrieval. The collection of record page ids are available via the `/jobs/{job_id}/records/pages` endpoint. Retrieve this collection as a precursor to downloading records. Each record page can then be retrieved by the client. Page IDs are immutable and can be retrieved in parallel. Record pages may also be retrieved multiple times if needed. 
 *
 * OpenAPI spec version: 0.1.0
 * 
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using SwaggerDateConverter = Quadient.DataServices.Model.Client.SwaggerDateConverter;

namespace Quadient.DataServies.Model.UsBatch
{
    /// <summary>
    /// Defines MoveUpdateInputField
    /// </summary>
    
    [JsonConverter(typeof(StringEnumConverter))]
    
    public enum MoveUpdateInputField
    {
        
        id = 1,
        
        address_line_1 = 2,
        
        address_line_2 = 3,
        
        business = 4,
        
        city = 5,
        
        state = 6,
        
        zip_code = 7,
        
        city_state_zip = 8,
        
        full_name = 9,
        
        first_name = 10,
        
        middle_name = 11,
        
        last_name = 12,
        
        custom_1 = 13,
        
        custom_2 = 14,
        
        custom_3 = 15,
        
        custom_4 = 16,
        
        custom_5 = 17,
        
        custom_6 = 18,
        
        custom_7 = 19,
        
        custom_8 = 20,
        
        custom_9 = 21,
        
        custom_10 = 22
    }
    
}
