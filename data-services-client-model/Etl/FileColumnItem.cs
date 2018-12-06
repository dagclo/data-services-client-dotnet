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
	/// FileColumnItem
	/// </summary>
	[DataContract]
	public partial class FileColumnItem : IEquatable<FileColumnItem>, IValidatableObject
	{
		/// <summary>
		/// A suggested field mapping against common Quadient Data Services fields.
		/// </summary>
		/// <value>A suggested field mapping against common Quadient Data Services fields.</value>
		[JsonConverter(typeof(StringEnumConverter))]
		public enum SuggestedFieldEnum
		{
			
			/// <summary>
			/// Enum Givenname for value: given_name
			/// </summary>
			[EnumMember(Value = "given_name")]
			Givenname = 1,
			
			/// <summary>
			/// Enum Middlename for value: middle_name
			/// </summary>
			[EnumMember(Value = "middle_name")]
			Middlename = 2,
			
			/// <summary>
			/// Enum Familyname for value: family_name
			/// </summary>
			[EnumMember(Value = "family_name")]
			Familyname = 3,
			
			/// <summary>
			/// Enum Fullname for value: full_name
			/// </summary>
			[EnumMember(Value = "full_name")]
			Fullname = 4,
			
			/// <summary>
			/// Enum Organization for value: organization
			/// </summary>
			[EnumMember(Value = "organization")]
			Organization = 5,
			
			/// <summary>
			/// Enum Emailaddress for value: email_address
			/// </summary>
			[EnumMember(Value = "email_address")]
			Emailaddress = 6,
			
			/// <summary>
			/// Enum Phonenumber for value: phone_number
			/// </summary>
			[EnumMember(Value = "phone_number")]
			Phonenumber = 7,
			
			/// <summary>
			/// Enum Country for value: country
			/// </summary>
			[EnumMember(Value = "country")]
			Country = 8,
			
			/// <summary>
			/// Enum County for value: county
			/// </summary>
			[EnumMember(Value = "county")]
			County = 9,
			
			/// <summary>
			/// Enum Provinceorstate for value: province_or_state
			/// </summary>
			[EnumMember(Value = "province_or_state")]
			Provinceorstate = 10,
			
			/// <summary>
			/// Enum Postalcode for value: postal_code
			/// </summary>
			[EnumMember(Value = "postal_code")]
			Postalcode = 11,
			
			/// <summary>
			/// Enum City for value: city
			/// </summary>
			[EnumMember(Value = "city")]
			City = 12,
			
			/// <summary>
			/// Enum Addressline for value: address_line
			/// </summary>
			[EnumMember(Value = "address_line")]
			Addressline = 13
		}

		/// <summary>
		/// A suggested field mapping against common Quadient Data Services fields.
		/// </summary>
		/// <value>A suggested field mapping against common Quadient Data Services fields.</value>
		[DataMember(Name="suggested_field", EmitDefaultValue=false)]
		public SuggestedFieldEnum? SuggestedField { get; set; }
		/// <summary>
		/// Initializes a new instance of the <see cref="FileColumnItem" /> class.
		/// </summary>
		/// <param name="Index">A zero-based index of the column. Needed as a way to reference the column for data transformations..</param>
		/// <param name="Name">The name of the column in the file..</param>
		/// <param name="SuggestedField">A suggested field mapping against common Quadient Data Services fields..</param>
		public FileColumnItem(int? Index = default(int?), string Name = default(string), SuggestedFieldEnum? SuggestedField = default(SuggestedFieldEnum?))
		{
			this.Index = Index;
			this.Name = Name;
			this.SuggestedField = SuggestedField;
		}
		
		/// <summary>
		/// A zero-based index of the column. Needed as a way to reference the column for data transformations.
		/// </summary>
		/// <value>A zero-based index of the column. Needed as a way to reference the column for data transformations.</value>
		[DataMember(Name="index", EmitDefaultValue=false)]
		public int? Index { get; set; }

		/// <summary>
		/// The name of the column in the file.
		/// </summary>
		/// <value>The name of the column in the file.</value>
		[DataMember(Name="name", EmitDefaultValue=false)]
		public string Name { get; set; }


		/// <summary>
		/// Returns the string presentation of the object
		/// </summary>
		/// <returns>String presentation of the object</returns>
		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.Append("class FileColumnItem {\n");
			sb.Append("  Index: ").Append(Index).Append("\n");
			sb.Append("  Name: ").Append(Name).Append("\n");
			sb.Append("  SuggestedField: ").Append(SuggestedField).Append("\n");
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
			return this.Equals(input as FileColumnItem);
		}

		/// <summary>
		/// Returns true if FileColumnItem instances are equal
		/// </summary>
		/// <param name="input">Instance of FileColumnItem to be compared</param>
		/// <returns>Boolean</returns>
		public bool Equals(FileColumnItem input)
		{
			if (input == null)
				return false;

			return 
				(
					this.Index == input.Index ||
					(this.Index != null &&
					this.Index.Equals(input.Index))
				) && 
				(
					this.Name == input.Name ||
					(this.Name != null &&
					this.Name.Equals(input.Name))
				) && 
				(
					this.SuggestedField == input.SuggestedField ||
					(this.SuggestedField != null &&
					this.SuggestedField.Equals(input.SuggestedField))
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
				if (this.Index != null)
					hashCode = hashCode * 59 + this.Index.GetHashCode();
				if (this.Name != null)
					hashCode = hashCode * 59 + this.Name.GetHashCode();
				if (this.SuggestedField != null)
					hashCode = hashCode * 59 + this.SuggestedField.GetHashCode();
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