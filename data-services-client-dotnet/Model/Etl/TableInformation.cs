/* 
 * ETL service
 *
 * The Extract, Transform Load (ETL) service handles data representation changes before or after applying Quadient Data Services that process the data.  The service aids in dealing with files and tables and transformations between the two. Usually, a data service is able to consume table data with certain schema requirements. The ETL service enables a user to upload a file and have it transformed into a shape that is consumeable by the service. 
 *
 * OpenAPI spec version: 1.0
 * 
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */

using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;

namespace Quadient.DataServices.Model
{
    /// <summary>
    /// TableInformation
    /// </summary>
    [DataContract]
    public partial class TableInformation :  IEquatable<TableInformation>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TableInformation" /> class.
        /// </summary>
        /// <param name="Uri">Uri.</param>
        /// <param name="TableId">TableId.</param>
        /// <param name="ColumnNames">ColumnNames.</param>
        /// <param name="PageIds">PageIds.</param>
        public TableInformation(string Uri = default(string), string TableId = default(string), List<string> ColumnNames = default(List<string>), List<string> PageIds = default(List<string>))
        {
            this.Uri = Uri;
            this.TableId = TableId;
            this.ColumnNames = ColumnNames;
            this.PageIds = PageIds;
        }
        
        /// <summary>
        /// Gets or Sets Uri
        /// </summary>
        [DataMember(Name="uri", EmitDefaultValue=false)]
        public string Uri { get; set; }

        /// <summary>
        /// Gets or Sets TableId
        /// </summary>
        [DataMember(Name="table_id", EmitDefaultValue=false)]
        public string TableId { get; set; }

        /// <summary>
        /// Gets or Sets ColumnNames
        /// </summary>
        [DataMember(Name="column_names", EmitDefaultValue=false)]
        public List<string> ColumnNames { get; set; }

        /// <summary>
        /// Gets or Sets PageIds
        /// </summary>
        [DataMember(Name="page_ids", EmitDefaultValue=false)]
        public List<string> PageIds { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TableInformation {\n");
            sb.Append("  Uri: ").Append(Uri).Append("\n");
            sb.Append("  TableId: ").Append(TableId).Append("\n");
            sb.Append("  ColumnNames: ").Append(ColumnNames).Append("\n");
            sb.Append("  PageIds: ").Append(PageIds).Append("\n");
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
            return this.Equals(input as TableInformation);
        }

        /// <summary>
        /// Returns true if TableInformation instances are equal
        /// </summary>
        /// <param name="input">Instance of TableInformation to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TableInformation input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Uri == input.Uri ||
                    (this.Uri != null &&
                    this.Uri.Equals(input.Uri))
                ) && 
                (
                    this.TableId == input.TableId ||
                    (this.TableId != null &&
                    this.TableId.Equals(input.TableId))
                ) && 
                (
                    this.ColumnNames == input.ColumnNames ||
                    this.ColumnNames != null &&
                    this.ColumnNames.SequenceEqual(input.ColumnNames)
                ) && 
                (
                    this.PageIds == input.PageIds ||
                    this.PageIds != null &&
                    this.PageIds.SequenceEqual(input.PageIds)
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
                if (this.Uri != null)
                    hashCode = hashCode * 59 + this.Uri.GetHashCode();
                if (this.TableId != null)
                    hashCode = hashCode * 59 + this.TableId.GetHashCode();
                if (this.ColumnNames != null)
                    hashCode = hashCode * 59 + this.ColumnNames.GetHashCode();
                if (this.PageIds != null)
                    hashCode = hashCode * 59 + this.PageIds.GetHashCode();
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
