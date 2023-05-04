using System.Text.Json.Serialization;

namespace Domain.Models
{
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum RPGClass
    {
        Fighter = 1,
        Wizard = 2,
        Cleric = 3,
        Rogue = 4
    }
}
