using System.Text.Json.Serialization;

namespace weather_station.Models
{
    public sealed record Info
    {
        [JsonPropertyName("name")]
        public string? Name { get; init; }
    }
}
