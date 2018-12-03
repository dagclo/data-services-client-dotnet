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
    /// FileTableItem
    /// </summary>
    [DataContract]
    public partial class FileTableItem : IEquatable<FileTableItem>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="FileTableItem" /> class.
        /// </summary>
        /// <param name="Index">A zero-based index of the table. Needed as a way to reference the table for data transformations..</param>
        /// <param name="Name">Name.</param>
        /// <param name="Columns">Provides a list of the columns found in the table..</param>
        /// <param name="SampleRecords">Provides a sample set of records (up to five). These sample records are provided for convenience when displaying data back to the user. If more records are needed, use the query endpoint instead. .</param>
        public FileTableItem(int? Index = default(int?), string Name = default(string), List<FileColumnItem> Columns = default(List<FileColumnItem>), List<List<string>> SampleRecords = default(List<List<string>>))
        {
            this.Index = Index;
            this.Name = Name;
            this.Columns = Columns;
            this.SampleRecords = SampleRecords;
        }
        
        /// <summary>
        /// A zero-based index of the table. Needed as a way to reference the table for data transformations.
        /// </summary>
        /// <value>A zero-based index of the table. Needed as a way to reference the table for data transformations.</value>
        [DataMember(Name="index", EmitDefaultValue=false)]
        public int? Index { get; set; }

        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }

        /// <summary>
        /// Provides a list of the columns found in the table.
        /// </summary>
        /// <value>Provides a list of the columns found in the table.</value>
        [DataMember(Name="columns", EmitDefaultValue=false)]
        public List<FileColumnItem> Columns { get; set; }

        /// <summary>
        /// Provides a sample set of records (up to five). These sample records are provided for convenience when displaying data back to the user. If more records are needed, use the query endpoint instead. 
        /// </summary>
        /// <value>Provides a sample set of records (up to five). These sample records are provided for convenience when displaying data back to the user. If more records are needed, use the query endpoint instead. </value>
        [DataMember(Name="sample_records", EmitDefaultValue=false)]
        public List<List<string>> SampleRecords { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class FileTableItem {\n");
            sb.Append("  Index: ").Append(Index).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Columns: ").Append(Columns).Append("\n");
            sb.Append("  SampleRecords: ").Append(SampleRecords).Append("\n");
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
            return this.Equals(input as FileTableItem);
        }

        /// <summary>
        /// Returns true if FileTableItem instances are equal
        /// </summary>
        /// <param name="input">Instance of FileTableItem to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(FileTableItem input)
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
                    this.Columns == input.Columns ||
                    this.Columns != null &&
                    this.Columns.SequenceEqual(input.Columns)
                ) && 
                (
                    this.SampleRecords == input.SampleRecords ||
                    this.SampleRecords != null &&
                    this.SampleRecords.SequenceEqual(input.SampleRecords)
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
                if (this.Columns != null)
                    hashCode = hashCode * 59 + this.Columns.GetHashCode();
                if (this.SampleRecords != null)
                    hashCode = hashCode * 59 + this.SampleRecords.GetHashCode();
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
