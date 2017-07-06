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
using System.Runtime.Serialization;
using System.Text;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Qlik.NPrinting.Rest.Client.Model
{
    /// <summary>
    /// UserResponseDataItem
    /// </summary>
    [DataContract]
    public partial class UserResponseDataItem :  IEquatable<UserResponseDataItem>, IValidatableObject
    {
        
        /// <summary>
        /// The locale of the user.
        /// </summary>
        /// <value>The locale of the user.</value>
        [DataMember(Name="locale", EmitDefaultValue=false)]
        public UserLocale? Locale { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="UserResponseDataItem" /> class.
        /// </summary>
        /// <param name="Id">The unique identifier of the user..</param>
        /// <param name="Email">The email address of the user..</param>
        /// <param name="Created">The creation date in RFC 3339 format based on the UTC time standard..</param>
        /// <param name="LastUpdate">The date of the last update in RFC 3339 format based on the UTC time standard..</param>
        /// <param name="Enabled">Indicates whether the user is enabled (true) or disabled..</param>
        /// <param name="Username">The name of the user..</param>
        /// <param name="Domainaccount">The domain account of the user..</param>
        /// <param name="Timezone">The timezone of the user..</param>
        /// <param name="Locale">The locale of the user..</param>
        /// <param name="Folder">The folder of the user..</param>
        /// <param name="Subfolder">The subfolder of the user..</param>
        public UserResponseDataItem(Guid Id = default(Guid), string Email = default(string), DateTime? Created = default(DateTime?), DateTime? LastUpdate = default(DateTime?), bool? Enabled = default(bool?), string Username = default(string), string Domainaccount = default(string), string Timezone = default(string), UserLocale? Locale = default(UserLocale?), string Folder = default(string), string Subfolder = default(string))
        {
            this.Id = Id;
            this.Email = Email;
            this.Created = Created;
            this.LastUpdate = LastUpdate;
            this.Enabled = Enabled;
            this.Username = Username;
            this.Domainaccount = Domainaccount;
            this.Timezone = Timezone;
            this.Locale = Locale;
            this.Folder = Folder;
            this.Subfolder = Subfolder;
        }
        
        /// <summary>
        /// The unique identifier of the user.
        /// </summary>
        /// <value>The unique identifier of the user.</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public Guid Id { get; set; }
        /// <summary>
        /// The email address of the user.
        /// </summary>
        /// <value>The email address of the user.</value>
        [DataMember(Name="email", EmitDefaultValue=false)]
        public string Email { get; set; }
        /// <summary>
        /// The creation date in RFC 3339 format based on the UTC time standard.
        /// </summary>
        /// <value>The creation date in RFC 3339 format based on the UTC time standard.</value>
        [DataMember(Name="created", EmitDefaultValue=false)]
        public DateTime? Created { get; set; }
        /// <summary>
        /// The date of the last update in RFC 3339 format based on the UTC time standard.
        /// </summary>
        /// <value>The date of the last update in RFC 3339 format based on the UTC time standard.</value>
        [DataMember(Name="lastUpdate", EmitDefaultValue=false)]
        public DateTime? LastUpdate { get; set; }
        /// <summary>
        /// Indicates whether the user is enabled (true) or disabled.
        /// </summary>
        /// <value>Indicates whether the user is enabled (true) or disabled.</value>
        [DataMember(Name="enabled", EmitDefaultValue=false)]
        public bool? Enabled { get; set; }
        /// <summary>
        /// The name of the user.
        /// </summary>
        /// <value>The name of the user.</value>
        [DataMember(Name="username", EmitDefaultValue=false)]
        public string Username { get; set; }
        /// <summary>
        /// The domain account of the user.
        /// </summary>
        /// <value>The domain account of the user.</value>
        [DataMember(Name="domainaccount", EmitDefaultValue=false)]
        public string Domainaccount { get; set; }
        /// <summary>
        /// The timezone of the user.
        /// </summary>
        /// <value>The timezone of the user.</value>
        [DataMember(Name="timezone", EmitDefaultValue=false)]
        public string Timezone { get; set; }
        /// <summary>
        /// The folder of the user.
        /// </summary>
        /// <value>The folder of the user.</value>
        [DataMember(Name="folder", EmitDefaultValue=false)]
        public string Folder { get; set; }
        /// <summary>
        /// The subfolder of the user.
        /// </summary>
        /// <value>The subfolder of the user.</value>
        [DataMember(Name="subfolder", EmitDefaultValue=false)]
        public string Subfolder { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UserResponseDataItem {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Email: ").Append(Email).Append("\n");
            sb.Append("  Created: ").Append(Created).Append("\n");
            sb.Append("  LastUpdate: ").Append(LastUpdate).Append("\n");
            sb.Append("  Enabled: ").Append(Enabled).Append("\n");
            sb.Append("  Username: ").Append(Username).Append("\n");
            sb.Append("  Domainaccount: ").Append(Domainaccount).Append("\n");
            sb.Append("  Timezone: ").Append(Timezone).Append("\n");
            sb.Append("  Locale: ").Append(Locale).Append("\n");
            sb.Append("  Folder: ").Append(Folder).Append("\n");
            sb.Append("  Subfolder: ").Append(Subfolder).Append("\n");
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
            return this.Equals(obj as UserResponseDataItem);
        }

        /// <summary>
        /// Returns true if UserResponseDataItem instances are equal
        /// </summary>
        /// <param name="other">Instance of UserResponseDataItem to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(UserResponseDataItem other)
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
                    this.Email == other.Email ||
                    this.Email != null &&
                    this.Email.Equals(other.Email)
                ) && 
                (
                    this.Created == other.Created ||
                    this.Created != null &&
                    this.Created.Equals(other.Created)
                ) && 
                (
                    this.LastUpdate == other.LastUpdate ||
                    this.LastUpdate != null &&
                    this.LastUpdate.Equals(other.LastUpdate)
                ) && 
                (
                    this.Enabled == other.Enabled ||
                    this.Enabled != null &&
                    this.Enabled.Equals(other.Enabled)
                ) && 
                (
                    this.Username == other.Username ||
                    this.Username != null &&
                    this.Username.Equals(other.Username)
                ) && 
                (
                    this.Domainaccount == other.Domainaccount ||
                    this.Domainaccount != null &&
                    this.Domainaccount.Equals(other.Domainaccount)
                ) && 
                (
                    this.Timezone == other.Timezone ||
                    this.Timezone != null &&
                    this.Timezone.Equals(other.Timezone)
                ) && 
                (
                    this.Locale == other.Locale ||
                    this.Locale != null &&
                    this.Locale.Equals(other.Locale)
                ) && 
                (
                    this.Folder == other.Folder ||
                    this.Folder != null &&
                    this.Folder.Equals(other.Folder)
                ) && 
                (
                    this.Subfolder == other.Subfolder ||
                    this.Subfolder != null &&
                    this.Subfolder.Equals(other.Subfolder)
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
                if (this.Email != null)
                    hash = hash * 59 + this.Email.GetHashCode();
                if (this.Created != null)
                    hash = hash * 59 + this.Created.GetHashCode();
                if (this.LastUpdate != null)
                    hash = hash * 59 + this.LastUpdate.GetHashCode();
                if (this.Enabled != null)
                    hash = hash * 59 + this.Enabled.GetHashCode();
                if (this.Username != null)
                    hash = hash * 59 + this.Username.GetHashCode();
                if (this.Domainaccount != null)
                    hash = hash * 59 + this.Domainaccount.GetHashCode();
                if (this.Timezone != null)
                    hash = hash * 59 + this.Timezone.GetHashCode();
                if (this.Locale != null)
                    hash = hash * 59 + this.Locale.GetHashCode();
                if (this.Folder != null)
                    hash = hash * 59 + this.Folder.GetHashCode();
                if (this.Subfolder != null)
                    hash = hash * 59 + this.Subfolder.GetHashCode();
                return hash;
            }
        }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        { 
            yield break;
        }
    }

}
