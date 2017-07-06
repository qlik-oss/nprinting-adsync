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
using Newtonsoft.Json.Converters;

namespace Qlik.NPrinting.Rest.Client.Model
{
    /// <summary>
    /// ReportResponseDataItem
    /// </summary>
    [DataContract]
    public partial class ReportResponseDataItem :  IEquatable<ReportResponseDataItem>, IValidatableObject
    {
        /// <summary>
        /// The type of the report.
        /// </summary>
        /// <value>The type of the report.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum TypeEnum
        {
            
            /// <summary>
            /// Enum Excel for "Excel"
            /// </summary>
            [EnumMember(Value = "Excel")]
            Excel,
            
            /// <summary>
            /// Enum Html for "Html"
            /// </summary>
            [EnumMember(Value = "Html")]
            Html,
            
            /// <summary>
            /// Enum PowerPoint for "PowerPoint"
            /// </summary>
            [EnumMember(Value = "PowerPoint")]
            PowerPoint,
            
            /// <summary>
            /// Enum QlikEntity for "QlikEntity"
            /// </summary>
            [EnumMember(Value = "QlikEntity")]
            QlikEntity,
            
            /// <summary>
            /// Enum Word for "Word"
            /// </summary>
            [EnumMember(Value = "Word")]
            Word,
            
            /// <summary>
            /// Enum PixelPerfect for "PixelPerfect"
            /// </summary>
            [EnumMember(Value = "PixelPerfect")]
            PixelPerfect
        }


        /// <summary>
        /// Gets or Sets OutputFormats
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum OutputFormatsEnum
        {
            /// <summary>
            /// Enum Html for "html"
            /// </summary>
            [EnumMember(Value = "html")]
            Html,


            /// <summary>
            /// Enum Pdf for "pdf"
            /// </summary>
            [EnumMember(Value = "pdf")]
            Pdf,
            
            /// <summary>
            /// Enum Doc for "doc"
            /// </summary>
            [EnumMember(Value = "doc")]
            Doc,
            
            /// <summary>
            /// Enum Docx for "docx"
            /// </summary>
            [EnumMember(Value = "docx")]
            Docx,
            
            /// <summary>
            /// Enum Docm for "docm"
            /// </summary>
            [EnumMember(Value = "docm")]
            Docm,
            
            /// <summary>
            /// Enum Ppt for "ppt"
            /// </summary>
            [EnumMember(Value = "ppt")]
            Ppt,
            
            /// <summary>
            /// Enum Pptx for "pptx"
            /// </summary>
            [EnumMember(Value = "pptx")]
            Pptx,
            
            /// <summary>
            /// Enum Xsl for "xsl"
            /// </summary>
            [EnumMember(Value = "xsl")]
            Xsl,

            /// <summary>
            /// Enum xls for "xls"
            /// </summary>
            [EnumMember(Value = "xls")]
            Xls,

            /// <summary>
            /// Enum xlsx for "xlsx"
            /// </summary>
            [EnumMember(Value = "xlsx")]
            Xlsx,
            
            /// <summary>
            /// Enum Xlsm for "xlsm"
            /// </summary>
            [EnumMember(Value = "xlsm")]
            Xlsm,
            
            /// <summary>
            /// Enum Jpg for "jpg"
            /// </summary>
            [EnumMember(Value = "jpg")]
            Jpg,

            /// <summary>
            /// Enum Jpg for "jpg"
            /// </summary>
            [EnumMember(Value = "jpeg")]
            Jpeg,

            /// <summary>
            /// Enum Png for "png"
            /// </summary>
            [EnumMember(Value = "png")]
            Png,

            /// <summary>
            /// Enum Png for "png"
            /// </summary>
            [EnumMember(Value = "gif")]
            Gif,

            /// <summary>
            /// Enum Tiff for "tiff"
            /// </summary>
            [EnumMember(Value = "tiff")]
            Tiff,
            
            /// <summary>
            /// Enum Bmp for "bmp"
            /// </summary>
            [EnumMember(Value = "bmp")]
            Bmp,
            
            /// <summary>
            /// Enum Csv for "csv"
            /// </summary>
            [EnumMember(Value = "csv")]
            Csv,
            
            /// <summary>
            /// Enum Tab for "tab"
            /// </summary>
            [EnumMember(Value = "tab")]
            Tab,
            
            /// <summary>
            /// Enum Skv for "skv"
            /// </summary>
            [EnumMember(Value = "skv")]
            Skv
        }

        /// <summary>
        /// The type of the report.
        /// </summary>
        /// <value>The type of the report.</value>
        [DataMember(Name="type", EmitDefaultValue=false)]
        public TypeEnum? Type { get; set; }
        /// <summary>
        /// Gets or Sets OutputFormats
        /// </summary>
        [DataMember(Name="outputFormats", EmitDefaultValue=false)]
        public List<OutputFormatsEnum> OutputFormats { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="ReportResponseDataItem" /> class.
        /// </summary>
        /// <param name="Id">The unique identifier of the report..</param>
        /// <param name="Created">The creation date in RFC 3339 format..</param>
        /// <param name="Title">The name of the report..</param>
        /// <param name="Description">The description of the report..</param>
        /// <param name="Type">The type of the report..</param>
        /// <param name="OutputFormats">OutputFormats.</param>
        /// <param name="EntityId">The Qlik entity ID. Specified only if the report type is \&quot;QlikEntity\&quot;..</param>
        public ReportResponseDataItem(Guid Id = default(Guid), DateTime? Created = default(DateTime?), string Title = default(string), string Description = default(string), TypeEnum? Type = default(TypeEnum?), List<OutputFormatsEnum> OutputFormats = default(List<OutputFormatsEnum>), string EntityId = default(string))
        {
            this.Id = Id;
            this.Created = Created;
            this.Title = Title;
            this.Description = Description;
            this.Type = Type;
            this.OutputFormats = OutputFormats;
            this.EntityId = EntityId;
        }
        
        /// <summary>
        /// The unique identifier of the report.
        /// </summary>
        /// <value>The unique identifier of the report.</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public Guid Id { get; set; }
        /// <summary>
        /// The creation date in RFC 3339 format.
        /// </summary>
        /// <value>The creation date in RFC 3339 format.</value>
        [DataMember(Name="created", EmitDefaultValue=false)]
        public DateTime? Created { get; set; }
        /// <summary>
        /// The name of the report.
        /// </summary>
        /// <value>The name of the report.</value>
        [DataMember(Name="title", EmitDefaultValue=false)]
        public string Title { get; set; }
        /// <summary>
        /// The description of the report.
        /// </summary>
        /// <value>The description of the report.</value>
        [DataMember(Name="description", EmitDefaultValue=false)]
        public string Description { get; set; }
        /// <summary>
        /// The Qlik entity ID. Specified only if the report type is \&quot;QlikEntity\&quot;.
        /// </summary>
        /// <value>The Qlik entity ID. Specified only if the report type is \&quot;QlikEntity\&quot;.</value>
        [DataMember(Name="entityId", EmitDefaultValue=false)]
        public string EntityId { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ReportResponseDataItem {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Created: ").Append(Created).Append("\n");
            sb.Append("  Title: ").Append(Title).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  OutputFormats: ").Append(OutputFormats).Append("\n");
            sb.Append("  EntityId: ").Append(EntityId).Append("\n");
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
            return this.Equals(obj as ReportResponseDataItem);
        }

        /// <summary>
        /// Returns true if ReportResponseDataItem instances are equal
        /// </summary>
        /// <param name="other">Instance of ReportResponseDataItem to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ReportResponseDataItem other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Id == other.Id ||
                    this.Id != null &&
                    this.Id.Equals(other.Id)
                ) && 
                (
                    this.Created == other.Created ||
                    this.Created != null &&
                    this.Created.Equals(other.Created)
                ) && 
                (
                    this.Title == other.Title ||
                    this.Title != null &&
                    this.Title.Equals(other.Title)
                ) && 
                (
                    this.Description == other.Description ||
                    this.Description != null &&
                    this.Description.Equals(other.Description)
                ) && 
                (
                    this.Type == other.Type ||
                    this.Type != null &&
                    this.Type.Equals(other.Type)
                ) && 
                (
                    this.OutputFormats == other.OutputFormats ||
                    this.OutputFormats != null &&
                    this.OutputFormats.SequenceEqual(other.OutputFormats)
                ) && 
                (
                    this.EntityId == other.EntityId ||
                    this.EntityId != null &&
                    this.EntityId.Equals(other.EntityId)
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
                if (this.Id != null)
                    hash = hash * 59 + this.Id.GetHashCode();
                if (this.Created != null)
                    hash = hash * 59 + this.Created.GetHashCode();
                if (this.Title != null)
                    hash = hash * 59 + this.Title.GetHashCode();
                if (this.Description != null)
                    hash = hash * 59 + this.Description.GetHashCode();
                if (this.Type != null)
                    hash = hash * 59 + this.Type.GetHashCode();
                if (this.OutputFormats != null)
                    hash = hash * 59 + this.OutputFormats.GetHashCode();
                if (this.EntityId != null)
                    hash = hash * 59 + this.EntityId.GetHashCode();
                return hash;
            }
        }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        { 
            yield break;
        }
    }

}
