/* 
 * Data Quality Assessment
 *
 * Allows users to assess the Quadient Data Services before buying. This service runs assessment jobs based on real data, but does not give back the records that have been corrected. Rather, it provides \"assessment metrics\" which can be used to determine and explain the value of using Data Services. 
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

namespace Quadient.DataServices.Model.Assessment
{
	/// <summary>
	/// JobCreationRequest
	/// </summary>
	[DataContract]
	public partial class JobCreationRequest : IEquatable<JobCreationRequest>, IValidatableObject
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="JobCreationRequest" /> class.
		/// </summary>
		[JsonConstructorAttribute]
		protected JobCreationRequest() { }
		/// <summary>
		/// Initializes a new instance of the <see cref="JobCreationRequest" /> class.
		/// </summary>
		/// <param name="Name">An optional user-provided name for the job..</param>
		/// <param name="Description">An optional user-provided text describing the job..</param>
		/// <param name="TableId">The ID of a table that&#39;s been prepared separately using the ETL services. Specifying this attribute means that the service will automatically start a job that&#39;s consuming data from the table. No manual uploading of records is needed in this case. The table structure must match the provided &#x60;input_fields&#x60; value. If no &#x60;input_fields&#x60; array is provided, fields will be inferred using the column names in the table. In this case the column names must match the &#x60;input_fields&#x60; names, optionally suffixed with numbers, e.g. &#x60;address_line1&#x60;, &#x60;address_line2&#x60; etc.	.</param>
		/// <param name="DefaultCountry">An optional 2 letter country code (such as \&quot;US\&quot;) that will act as a default value for records where there is no country specified..</param>
		/// <param name="ClientInformation">ClientInformation.</param>
		/// <param name="Services">Services (required).</param>
		/// <param name="InputFields">InputFields.</param>
		public JobCreationRequest(string Name = default(string), string Description = default(string), string TableId = default(string), string DefaultCountry = default(string), ClientInformation ClientInformation = default(ClientInformation), ServicesArray Services = default(ServicesArray), FieldsArray InputFields = default(FieldsArray))
		{
			// to ensure "Services" is required (not null)
			if (Services == null)
			{
				throw new InvalidDataException("Services is a required property for JobCreationRequest and cannot be null");
			}
			else
			{
				this.Services = Services;
			}
			this.Name = Name;
			this.Description = Description;
			this.TableId = TableId;
			this.DefaultCountry = DefaultCountry;
			this.ClientInformation = ClientInformation;
			this.InputFields = InputFields;
		}
		
		/// <summary>
		/// An optional user-provided name for the job.
		/// </summary>
		/// <value>An optional user-provided name for the job.</value>
		[DataMember(Name="name", EmitDefaultValue=false)]
		public string Name { get; set; }

		/// <summary>
		/// An optional user-provided text describing the job.
		/// </summary>
		/// <value>An optional user-provided text describing the job.</value>
		[DataMember(Name="description", EmitDefaultValue=false)]
		public string Description { get; set; }

		/// <summary>
		/// The ID of a table that&#39;s been prepared separately using the ETL services. Specifying this attribute means that the service will automatically start a job that&#39;s consuming data from the table. No manual uploading of records is needed in this case. The table structure must match the provided &#x60;input_fields&#x60; value. If no &#x60;input_fields&#x60; array is provided, fields will be inferred using the column names in the table. In this case the column names must match the &#x60;input_fields&#x60; names, optionally suffixed with numbers, e.g. &#x60;address_line1&#x60;, &#x60;address_line2&#x60; etc.   
		/// </summary>
		/// <value>The ID of a table that&#39;s been prepared separately using the ETL services. Specifying this attribute means that the service will automatically start a job that&#39;s consuming data from the table. No manual uploading of records is needed in this case. The table structure must match the provided &#x60;input_fields&#x60; value. If no &#x60;input_fields&#x60; array is provided, fields will be inferred using the column names in the table. In this case the column names must match the &#x60;input_fields&#x60; names, optionally suffixed with numbers, e.g. &#x60;address_line1&#x60;, &#x60;address_line2&#x60; etc.	 </value>
		[DataMember(Name="table_id", EmitDefaultValue=false)]
		public string TableId { get; set; }

		/// <summary>
		/// An optional 2 letter country code (such as \&quot;US\&quot;) that will act as a default value for records where there is no country specified.
		/// </summary>
		/// <value>An optional 2 letter country code (such as \&quot;US\&quot;) that will act as a default value for records where there is no country specified.</value>
		[DataMember(Name="default_country", EmitDefaultValue=false)]
		public string DefaultCountry { get; set; }

		/// <summary>
		/// Gets or Sets ClientInformation
		/// </summary>
		[DataMember(Name="client_information", EmitDefaultValue=false)]
		public ClientInformation ClientInformation { get; set; }

		/// <summary>
		/// Gets or Sets Services
		/// </summary>
		[DataMember(Name="services", EmitDefaultValue=false)]
		public ServicesArray Services { get; set; }

		/// <summary>
		/// Gets or Sets InputFields
		/// </summary>
		[DataMember(Name="input_fields", EmitDefaultValue=false)]
		public FieldsArray InputFields { get; set; }

		/// <summary>
		/// Returns the string presentation of the object
		/// </summary>
		/// <returns>String presentation of the object</returns>
		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.Append("class JobCreationRequest {\n");
			sb.Append("  Name: ").Append(Name).Append("\n");
			sb.Append("  Description: ").Append(Description).Append("\n");
			sb.Append("  TableId: ").Append(TableId).Append("\n");
			sb.Append("  DefaultCountry: ").Append(DefaultCountry).Append("\n");
			sb.Append("  ClientInformation: ").Append(ClientInformation).Append("\n");
			sb.Append("  Services: ").Append(Services).Append("\n");
			sb.Append("  InputFields: ").Append(InputFields).Append("\n");
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
			return this.Equals(input as JobCreationRequest);
		}

		/// <summary>
		/// Returns true if JobCreationRequest instances are equal
		/// </summary>
		/// <param name="input">Instance of JobCreationRequest to be compared</param>
		/// <returns>Boolean</returns>
		public bool Equals(JobCreationRequest input)
		{
			if (input == null)
				return false;

			return 
				(
					this.Name == input.Name ||
					(this.Name != null &&
					this.Name.Equals(input.Name))
				) && 
				(
					this.Description == input.Description ||
					(this.Description != null &&
					this.Description.Equals(input.Description))
				) && 
				(
					this.TableId == input.TableId ||
					(this.TableId != null &&
					this.TableId.Equals(input.TableId))
				) && 
				(
					this.DefaultCountry == input.DefaultCountry ||
					(this.DefaultCountry != null &&
					this.DefaultCountry.Equals(input.DefaultCountry))
				) && 
				(
					this.ClientInformation == input.ClientInformation ||
					(this.ClientInformation != null &&
					this.ClientInformation.Equals(input.ClientInformation))
				) && 
				(
					this.Services == input.Services ||
					(this.Services != null &&
					this.Services.Equals(input.Services))
				) && 
				(
					this.InputFields == input.InputFields ||
					(this.InputFields != null &&
					this.InputFields.Equals(input.InputFields))
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
				if (this.Name != null)
					hashCode = hashCode * 59 + this.Name.GetHashCode();
				if (this.Description != null)
					hashCode = hashCode * 59 + this.Description.GetHashCode();
				if (this.TableId != null)
					hashCode = hashCode * 59 + this.TableId.GetHashCode();
				if (this.DefaultCountry != null)
					hashCode = hashCode * 59 + this.DefaultCountry.GetHashCode();
				if (this.ClientInformation != null)
					hashCode = hashCode * 59 + this.ClientInformation.GetHashCode();
				if (this.Services != null)
					hashCode = hashCode * 59 + this.Services.GetHashCode();
				if (this.InputFields != null)
					hashCode = hashCode * 59 + this.InputFields.GetHashCode();
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
