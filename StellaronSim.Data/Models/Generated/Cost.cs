using System.Text.Json.Serialization;

namespace StellaronSim.Data.Models.Generated;

#pragma warning disable CS8618, CS8601, CS8603
internal class Cost
{
    [JsonPropertyName("id")]
    public long Id { get; set; }

    [JsonPropertyName("count")]
    public long Count { get; set; }
}