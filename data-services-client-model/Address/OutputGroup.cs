/* 
 * Address Correction
 *
 * The Address Correction data service validates and corrects postal addresses from around the world.  The service is currently available for the following countries: United States, United Kingdom, and Canada. Address correction standardizes address spellings, abbreviations, and formats, adds additional delivery information, such as geocodes, and verifies the deliverability of each address.  It improves your delivery success odds by correcting incorrect information, such as postal codes and typos in street names, and verifying delivery target names.  Key functionality: * Corrects the spelling of street names and cities. * Standardizes address formats and abbreviations, based on country ID. * Enriches output with deliverability information for an address, such as USPS DPV® confirmation and geocoding coordinates. * Provides easy-to-understand correction status, codes, and messages.
 *
 * OpenAPI spec version: 1.0.12
 * 
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */

using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Quadient.DataServices.Model.Address
{
    /// <summary>
    /// Defines a group of output fields that can be enabled on demand. The following output groups are available:  * &#x60;presort&#x60; contains output fields that are necessary for performing mail sortation (&#39;presort&#39;) with the resulting addresses. Due to the country-specific nature of presorting, the fields in this output group varies by country. * &#x60;geocodes&#x60; contains output fields that are used for specifying geographical coordinates on a map. * &#x60;move_update&#x60; contains output fields that are needed for performing move_update processing. * &#x60;address_traits&#x60; contains additional traits orelements of an address. 
    /// </summary>
    /// <value>Defines a group of output fields that can be enabled on demand. The following output groups are available:  * &#x60;presort&#x60; contains output fields that are necessary for performing mail sortation (&#39;presort&#39;) with the resulting addresses. Due to the country-specific nature of presorting, the fields in this output group varies by country. * &#x60;geocodes&#x60; contains output fields that are used for specifying geographical coordinates on a map. * &#x60;move_update&#x60; contains output fields that are needed for performing move_update processing. * &#x60;address_traits&#x60; contains additional traits orelements of an address. </value>
    
    [JsonConverter(typeof(StringEnumConverter))]
    
    public enum OutputGroup
    {
        
        /// <summary>
        /// Enum Presort for value: presort
        /// </summary>
        [EnumMember(Value = "presort")]
        Presort = 1,
        
        /// <summary>
        /// Enum Geocodes for value: geocodes
        /// </summary>
        [EnumMember(Value = "geocodes")]
        Geocodes = 2,
        
        /// <summary>
        /// Enum Moveupdate for value: move_update
        /// </summary>
        [EnumMember(Value = "move_update")]
        Moveupdate = 3,
        
        /// <summary>
        /// Enum Addresstraits for value: address_traits
        /// </summary>
        [EnumMember(Value = "address_traits")]
        Addresstraits = 4
    }

}
