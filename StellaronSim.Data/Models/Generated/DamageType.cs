using System.Text.Json.Serialization;

namespace StellaronSim.Data.Models.Generated;

#pragma warning disable CS8618, CS8601, CS8603
internal class DamageType
{
    [JsonPropertyName("id")]
    public long Id { get; set; }

    [JsonPropertyName("iconPath")]
    public string IconPath { get; set; }

    [JsonPropertyName("color")]
    public string Color { get; set; }

    [JsonPropertyName("name")]
    public string Name { get; set; }

    [JsonPropertyName("rarity")]
    public long Rarity { get; set; }
}