/* 
 * ETL service
 *
 * The Extract, Transform Load (ETL) service handles data representation changes before or after applying Quadient Data Services that process the data.  The service aids in dealing with files and tables and transformations between the two. Usually, a data service is able to consume table data with certain schema requirements. The ETL service enables a user to upload a file and have it transformed into a shape that is consumeable by the service. 
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

namespace Quadient.DataServices.Model.Etl
{
	/// <summary>
	/// QueryResponse
	/// </summary>
	[DataContract]
	public partial class QueryResponse : IEquatable<QueryResponse>, IValidatableObject
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="QueryResponse" /> class.
		/// </summary>
		/// <param name="EndOfTable">A boolean determining whether or not more records exist in the file..</param>
		/// <param name="Records">Records.</param>
		public QueryResponse(bool? EndOfTable = default(bool?), List<List<string>> Records = default(List<List<string>>))
		{
			this.EndOfTable = EndOfTable;
			this.Records = Records;
		}
		
		/// <summary>
		/// A boolean determining whether or not more records exist in the file.
		/// </summary>
		/// <value>A boolean determining whether or not more records exist in the file.</value>
		[DataMember(Name="end_of_table", EmitDefaultValue=false)]
		public bool? EndOfTable { get; set; }

		/// <summary>
		/// Gets or Sets Records
		/// </summary>
		[DataMember(Name="records", EmitDefaultValue=false)]
		public List<List<string>> Records { get; set; }

		/// <summary>
		/// Returns the string presentation of the object
		/// </summary>
		/// <returns>String presentation of the object</returns>
		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.Append("class QueryResponse {\n");
			sb.Append("  EndOfTable: ").Append(EndOfTable).Append("\n");
			sb.Append("  Records: ").Append(Records).Append("\n");
			sb.Append("}\n");
			return sb.ToString();
		}
  
		/// <summary>
		/// Returns the JSON string presentation of the object
		/// </summary>
		/// <returns>JSON string presentation of the object</returns>
		public string ToJson()
		{
			return JsonConvert.SerializeObject(this, Formatting.Indented);
		}

		/// <summary>
		/// Returns true if objects are equal
		/// </summary>
		/// <param name="input">Object to be compared</param>
		/// <returns>Boolean</returns>
		public override bool Equals(object input)
		{
			return this.Equals(input as QueryResponse);
		}

		/// <summary>
		/// Returns true if QueryResponse instances are equal
		/// </summary>
		/// <param name="input">Instance of QueryResponse to be compared</param>
		/// <returns>Boolean</returns>
		public bool Equals(QueryResponse input)
		{
			if (input == null)
				return false;

			return 
				(
					this.EndOfTable == input.EndOfTable ||
					(this.EndOfTable != null &&
					this.EndOfTable.Equals(input.EndOfTable))
				) && 
				(
					this.Records == input.Records ||
					this.Records != null &&
					this.Records.SequenceEqual(input.Records)
				);
		}

		/// <summary>
		/// Gets the hash code
		/// </summary>
		/// <returns>Hash code</returns>
		public override int GetHashCode()
		{
			unchecked // Overflow is fine, just wrap
			{
				int hashCode = 41;
				if (this.EndOfTable != null)
					hashCode = hashCode * 59 + this.EndOfTable.GetHashCode();
				if (this.Records != null)
					hashCode = hashCode * 59 + this.Records.GetHashCode();
				return hashCode;
			}
		}

		/// <summary>
		/// To validate all properties of the instance
		/// </summary>
		/// <param name="validationContext">Validation context</param>
		/// <returns>Validation Result</returns>
		IEnumerable<ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
		{
			yield break;
		}
	}

}