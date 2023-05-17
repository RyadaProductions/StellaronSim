using System.Text.Json.Serialization;

namespace StellaronSim.Data.Models.Generated;

#pragma warning disable CS8618, CS8601, CS8603
public class ItemFilter
{
    [JsonPropertyName("name")]
    public string Name { get; set; }

    [JsonPropertyName("group")]
    public string Group { get; set; }

    [JsonPropertyName("dataKey")]
    public string DataKey { get; set; }

    [JsonPropertyName("dataValue")]
    public long DataValue { get; set; }

    [JsonPropertyName("rarity")]
    public long Rarity { get; set; }

    [JsonPropertyName("type")]
    public long Type { get; set; }
}