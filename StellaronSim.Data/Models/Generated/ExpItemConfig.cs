using System.Text.Json.Serialization;

namespace StellaronSim.Data.Models.Generated;

#pragma warning disable CS8618, CS8601, CS8603
public class ExpItemConfig
{
    [JsonPropertyName("itemId")]
    public long ItemId { get; set; }

    [JsonPropertyName("cost")]
    public long Cost { get; set; }
}