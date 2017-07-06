/* 
 * Qlik NPrinting API
 *
 * You can extend your reporting system by using the Qlik NPrinting API. This API provides endpoints to perform operations on apps, On-Demand requests and results, reports, filters, and so on.  For all requests, the data returned is filtered based on user permissions. That is, if a user is not authorized to access a certain object, that object is not returned in the reponse.  API Stability: Experimental.  Deprecation period: None. Can change at any point and should be used only to evaluate upcoming functionality.     
 *
 * OpenAPI spec version: 0.2.0
 * 
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using Newtonsoft.Json;

namespace Qlik.NPrinting.Rest.Client.Model
{
    /// <summary>
    /// ReportListResponseData
    /// </summary>
    [DataContract]
    public partial class ReportListResponseData :  IEquatable<ReportListResponseData>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ReportListResponseData" /> class.
        /// </summary>
        /// <param name="TotalItems">TotalItems.</param>
        /// <param name="Offset">Offset.</param>
        /// <param name="Limit">Limit.</param>
        /// <param name="Items">Items.</param>
        public ReportListResponseData(int? TotalItems = default(int?), int? Offset = default(int?), int? Limit = default(int?), List<ReportResponseDataItem> Items = default(List<ReportResponseDataItem>))
        {
            this.TotalItems = TotalItems;
            this.Offset = Offset;
            this.Limit = Limit;
            this.Items = Items;
        }
        
        /// <summary>
        /// Gets or Sets TotalItems
        /// </summary>
        [DataMember(Name="totalItems", EmitDefaultValue=false)]
        public int? TotalItems { get; set; }
        /// <summary>
        /// Gets or Sets Offset
        /// </summary>
        [DataMember(Name="offset", EmitDefaultValue=false)]
        public int? Offset { get; set; }
        /// <summary>
        /// Gets or Sets Limit
        /// </summary>
        [DataMember(Name="limit", EmitDefaultValue=false)]
        public int? Limit { get; set; }
        /// <summary>
        /// Gets or Sets Items
        /// </summary>
        [DataMember(Name="items", EmitDefaultValue=false)]
        public List<ReportResponseDataItem> Items { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ReportListResponseData {\n");
            sb.Append("  TotalItems: ").Append(TotalItems).Append("\n");
            sb.Append("  Offset: ").Append(Offset).Append("\n");
            sb.Append("  Limit: ").Append(Limit).Append("\n");
            sb.Append("  Items: ").Append(Items).Append("\n");
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
        /// <param name="obj">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object obj)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            return this.Equals(obj as ReportListResponseData);
        }

        /// <summary>
        /// Returns true if ReportListResponseData instances are equal
        /// </summary>
        /// <param name="other">Instance of ReportListResponseData to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ReportListResponseData other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.TotalItems == other.TotalItems ||
                    this.TotalItems != null &&
                    this.TotalItems.Equals(other.TotalItems)
                ) && 
                (
                    this.Offset == other.Offset ||
                    this.Offset != null &&
                    this.Offset.Equals(other.Offset)
                ) && 
                (
                    this.Limit == other.Limit ||
                    this.Limit != null &&
                    this.Limit.Equals(other.Limit)
                ) && 
                (
                    this.Items == other.Items ||
                    this.Items != null &&
                    this.Items.SequenceEqual(other.Items)
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            // credit: http://stackoverflow.com/a/263416/677735
            unchecked // Overflow is fine, just wrap
            {
                int hash = 41;
                // Suitable nullity checks etc, of course :)
                if (this.TotalItems != null)
                    hash = hash * 59 + this.TotalItems.GetHashCode();
                if (this.Offset != null)
                    hash = hash * 59 + this.Offset.GetHashCode();
                if (this.Limit != null)
                    hash = hash * 59 + this.Limit.GetHashCode();
                if (this.Items != null)
                    hash = hash * 59 + this.Items.GetHashCode();
                return hash;
            }
        }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        { 
            yield break;
        }
    }

}
