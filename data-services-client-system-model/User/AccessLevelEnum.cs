/* 
 * User Management
 *
 * Provides an API to:   * Enumerate the user base   * Create new users   * Gather specific user's information   * Change a user's information  User information include things like:   * Whether or not the user account is `enabled` or not   * Username/password credentials as well as API keys   * Contact information such as `first_name`, `last_name`, `organization` and `email_address`   * Group membership - membership of a `group` is used to grant access to services and features   * Tenant membership - membership of a `tenant` is used to assign users specific `roles` in a organization   * Additional details - each user may have a collection of custom key-value pairs  For details about authentication, refer to the [authentication specification](/oauth/swagger.json).
 *
 * OpenAPI spec version: 1.1.32
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
using SwaggerDateConverter = Quadient.DataServices.System.Model.Client.SwaggerDateConverter;

namespace Quadient.DataServices.System.Model.User
{
    /// <summary>
    /// Defines accessLevelEnum
    /// </summary>
    
    [JsonConverter(typeof(StringEnumConverter))]
    
    public enum AccessLevelEnum
    {
        
        /// <summary>
        /// Enum Enabledread for value: enabled_read
        /// </summary>
        [EnumMember(Value = "enabled_read")]
        Enabledread = 1,
        
        /// <summary>
        /// Enum Enabledwrite for value: enabled_write
        /// </summary>
        [EnumMember(Value = "enabled_write")]
        Enabledwrite = 2,
        
        /// <summary>
        /// Enum Enableduse for value: enabled_use
        /// </summary>
        [EnumMember(Value = "enabled_use")]
        Enableduse = 3,
        
        /// <summary>
        /// Enum Disabled for value: disabled
        /// </summary>
        [EnumMember(Value = "disabled")]
        Disabled = 4
    }
}
