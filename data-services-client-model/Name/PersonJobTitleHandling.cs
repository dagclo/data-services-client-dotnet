/* 
 * Name validation
 *
 * The Name Validation data service parses fields, structured and unstructured,  pertaining to names in your records to offer updates, standardization, and  enrichment of name data. For example, it can provide you with information	to help you analyze and standardize customer contact data. The service is a tool to validate and parse name information and structure name parts.  It can indicate that a part of a name is missing, and assign parts of an input string.  In addition, the service can help indicate that the name belongs to a person,  with given name, middle name, and family name fields, or belongs to an organization.	You can refine the results by using the country code to map the output more closely  to that country's name usage patterns. ## Key functionality: * Formats and capitalizes name parts. Indicates how you wnat to handle different name parts. * Identifies the gender of a person based on the name. * Identifies missing name parts. * Indicates whether a particular name is typically a nickname and suggest other possible nicknames.
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

namespace Quadient.DataServices.Model.Name
{
	/// <summary>
	/// Defines personJobTitleHandling
	/// </summary>
	
	[JsonConverter(typeof(StringEnumConverter))]
	
	public enum PersonJobTitleHandling
	{
		
		/// <summary>
		/// Enum Separate for value: Separate
		/// </summary>
		[EnumMember(Value = "Separate")]
		Separate = 1,
		
		/// <summary>
		/// Enum TitleAfter for value: TitleAfter
		/// </summary>
		[EnumMember(Value = "TitleAfter")]
		TitleAfter = 2
	}
}
