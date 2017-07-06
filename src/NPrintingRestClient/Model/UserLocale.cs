using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Qlik.NPrinting.Rest.Client.Model
{
    /// <summary>
    /// The locale of the user.
    /// </summary>
    /// <value>The locale of the user.</value>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum UserLocale
    {

        /// <summary>
        /// Enum De for "de"
        /// </summary>
        [EnumMember(Value = "de")]
        De,

        /// <summary>
        /// Enum En for "en"
        /// </summary>
        [EnumMember(Value = "en")]
        En,

        /// <summary>
        /// Enum Es for "es"
        /// </summary>
        [EnumMember(Value = "es")]
        Es,

        /// <summary>
        /// Enum Fr for "fr"
        /// </summary>
        [EnumMember(Value = "fr")]
        Fr,

        /// <summary>
        /// Enum It for "it"
        /// </summary>
        [EnumMember(Value = "it")]
        It,

        /// <summary>
        /// Enum Pt for "pt"
        /// </summary>
        [EnumMember(Value = "pt")]
        Pt,

        /// <summary>
        /// Enum Zh for "zh"
        /// </summary>
        [EnumMember(Value = "zh")]
        Zh,

        /// <summary>
        /// Enum Ja for "ja"
        /// </summary>
        [EnumMember(Value = "ja")]
        Ja
    }
}
