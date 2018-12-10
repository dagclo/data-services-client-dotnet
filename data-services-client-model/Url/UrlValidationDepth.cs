/* 
 * URL Validation
 *
 * The URL Validation service is used to confirm that a particular URL, or multiple URLs, is valid and safe to use. For example, if you are designing a communication for customers and want to include a URL, you can check that the URL goes to a valid, active website before sending the communication.   The service validates web page addresses that use the HTTP and HTTPS application protocols. It does not process web addresses that are in the IPv4 and IPv6 address format.	## Key functionality:	* Validates URLs to a level specified and configured by the user.  * Validates the existence of domains and conformity to patterns.  * Checks whether a web server is responsive when queried for the URL.	* Handles complexities, such as URL redirection.  * Adds missing URL pieces, such as scheme, and removes noise from the input.	* Provides codes to warn the user of authentication requirements, browser-specific URL length restrictions, and so forth. 
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

namespace Quadient.DataServices.Model.Url
{
	/// <summary>
	/// Defines the level of URL validation to apply. Specify a level to match the processing needs of your business workflow. * Shallow - Validates the format of the input URL. This level of validation does not contact a web server. * Moderate - Validates URL format, and verifies that DNS resolution of the host name succeeds and that a web server is running on that host and port. The test is against the root (/) path of the web server. * Deep - Validates URL format, verifies DNS resolution of the host name, and further tests that a HEAD request for the full URL has a successful response. If the HEAD request fails, a GET request is then tested. 
	/// </summary>
	/// <value>Defines the level of URL validation to apply. Specify a level to match the processing needs of your business workflow. * Shallow - Validates the format of the input URL. This level of validation does not contact a web server. * Moderate - Validates URL format, and verifies that DNS resolution of the host name succeeds and that a web server is running on that host and port. The test is against the root (/) path of the web server. * Deep - Validates URL format, verifies DNS resolution of the host name, and further tests that a HEAD request for the full URL has a successful response. If the HEAD request fails, a GET request is then tested. </value>
	
	[JsonConverter(typeof(StringEnumConverter))]
	
	public enum UrlValidationDepth
	{
		
		/// <summary>
		/// Enum Shallow for value: Shallow
		/// </summary>
		[EnumMember(Value = "Shallow")]
		Shallow = 1,
		
		/// <summary>
		/// Enum Moderate for value: Moderate
		/// </summary>
		[EnumMember(Value = "Moderate")]
		Moderate = 2,
		
		/// <summary>
		/// Enum Deep for value: Deep
		/// </summary>
		[EnumMember(Value = "Deep")]
		Deep = 3
	}
}
