using System.Text.Json.Serialization;

namespace Dotnet_RPG6.Models
{
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum RPGClass
    {
        Knight = 1,
        Mage = 2,
        Cleric = 3
    }
}
