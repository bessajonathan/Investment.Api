using Newtonsoft.Json.Converters;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace Investment.Core.Enums
{
    [JsonConverter(typeof(StringEnumConverter))]
    public enum EUserActiveType
    {
        [EnumMember(Value = "ptr4")]
        PETR4,
        [EnumMember(Value = "vale3")]
        VALE3,
        [EnumMember(Value = "mglu3")]
        MGLU3,
        [EnumMember(Value = "bcsa34")]
        BCSA34,
    }
}
