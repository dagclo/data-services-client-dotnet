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
    /// QueryRequest
    /// </summary>
    [DataContract]
    public partial class QueryRequest : IEquatable<QueryRequest>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="QueryRequest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected QueryRequest() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="QueryRequest" /> class.
        /// </summary>
        /// <param name="TableIndex">The table index to query. (required).</param>
        /// <param name="Limit">The maximum number of records to return. (default to 1000).</param>
        /// <param name="Offset">The first record (1-based) to return..</param>
        public QueryRequest(int? TableIndex = default(int?), int? Limit = 1000, int? Offset = default(int?))
        {
            // to ensure "TableIndex" is required (not null)
            if (TableIndex == null)
            {
                throw new InvalidDataException("TableIndex is a required property for QueryRequest and cannot be null");
            }
            else
            {
                this.TableIndex = TableIndex;
            }
            // use default value if no "Limit" provided
            if (Limit == null)
            {
                this.Limit = 1000;
            }
            else
            {
                this.Limit = Limit;
            }
            this.Offset = Offset;
        }
        
        /// <summary>
        /// The table index to query.
        /// </summary>
        /// <value>The table index to query.</value>
        [DataMember(Name="table_index", EmitDefaultValue=false)]
        public int? TableIndex { get; set; }

        /// <summary>
        /// The maximum number of records to return.
        /// </summary>
        /// <value>The maximum number of records to return.</value>
        [DataMember(Name="limit", EmitDefaultValue=false)]
        public int? Limit { get; set; }

        /// <summary>
        /// The first record (1-based) to return.
        /// </summary>
        /// <value>The first record (1-based) to return.</value>
        [DataMember(Name="offset", EmitDefaultValue=false)]
        public int? Offset { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class QueryRequest {\n");
            sb.Append("  TableIndex: ").Append(TableIndex).Append("\n");
            sb.Append("  Limit: ").Append(Limit).Append("\n");
            sb.Append("  Offset: ").Append(Offset).Append("\n");
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
            return this.Equals(input as QueryRequest);
        }

        /// <summary>
        /// Returns true if QueryRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of QueryRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(QueryRequest input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.TableIndex == input.TableIndex ||
                    (this.TableIndex != null &&
                    this.TableIndex.Equals(input.TableIndex))
                ) && 
                (
                    this.Limit == input.Limit ||
                    (this.Limit != null &&
                    this.Limit.Equals(input.Limit))
                ) && 
                (
                    this.Offset == input.Offset ||
                    (this.Offset != null &&
                    this.Offset.Equals(input.Offset))
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
                if (this.TableIndex != null)
                    hashCode = hashCode * 59 + this.TableIndex.GetHashCode();
                if (this.Limit != null)
                    hashCode = hashCode * 59 + this.Limit.GetHashCode();
                if (this.Offset != null)
                    hashCode = hashCode * 59 + this.Offset.GetHashCode();
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
            // Limit (int?) maximum
            if(this.Limit > (int?)10000)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Limit, must be a value less than or equal to 10000.", new [] { "Limit" });
            }

            yield break;
        }
    }

}
