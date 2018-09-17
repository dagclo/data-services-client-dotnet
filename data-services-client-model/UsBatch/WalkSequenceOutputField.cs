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

namespace Quadient.DataServies.Model.UsBatch
{
    /// <summary>
    /// Defines WalkSequenceOutputField
    /// </summary>
    
    [JsonConverter(typeof(StringEnumConverter))]
    
    public enum WalkSequenceOutputField
    {
        
        id = 1,
        
        abbreviated_city = 2,
        
        address_block = 3,
        
        address_line_1 = 4,
        
        address_line_2 = 5,
        
        address_type = 6,
        
        organization = 7,
        
        carrier_route = 8,
        
        city = 9,
        
        congressional_district = 10,
        
        country = 11,
        
        county = 12,
        
        county_code = 13,
        
        custom_1 = 14,
        
        custom_2 = 15,
        
        custom_3 = 16,
        
        custom_4 = 17,
        
        custom_5 = 18,
        
        custom_6 = 19,
        
        custom_7 = 20,
        
        custom_8 = 21,
        
        custom_9 = 22,
        
        custom_10 = 23,
        
        delivery_point = 24,
        
        dpv_coded = 25,
        
        dpv_footnote = 26,
        
        dpv_indicator = 27,
        
        delivery_type = 28,
        
        drop_type = 29,
        
        drop_count = 30,
        
        elot = 31,
        
        extra_address_information = 32,
        
        fips_code = 33,
        
        is_business = 34,
        
        is_cmra = 35,
        
        is_ews_match = 36,
        
        is_no_stat = 37,
        
        is_pbsa = 38,
        
        is_vacant = 39,
        
        is_residence = 40,
        
        is_educational_institute = 41,
        
        is_seasonally_occupied = 42,
        
        is_throwback = 43,
        
        lacs_coded = 44,
        
        lacs_link_footnote = 45,
        
        lacs_link_indicator = 46,
        
        city_state_zip = 47,
        
        matched_to_default = 48,
        
        post_directional = 49,
        
        pre_directional = 50,
        
        primary_address_line = 51,
        
        primary_number = 52,
        
        private_mailbox = 53,
        
        secondary_address_line = 54,
        
        state = 55,
        
        street_name = 56,
        
        street_suffix = 57,
        
        suite_link_footnote = 58,
        
        unit_designator = 59,
        
        unit_number = 60,
        
        urbanization = 61,
        
        uscorrection_description = 62,
        
        uscorrection_footnote = 63,
        
        walk_sequence_footnote = 64,
        
        walk_sequence_number = 65,
        
        zip_code = 66
    }
    
}
