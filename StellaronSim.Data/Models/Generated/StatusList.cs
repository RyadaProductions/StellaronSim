using System.Text.Json.Serialization;

namespace StellaronSim.Data.Models.Generated;

#pragma warning disable CS8618, CS8601, CS8603
internal class StatusList
{
    [JsonPropertyName("key")]
    public Key Key { get; set; }

    [JsonPropertyName("value")]
    public double Value { get; set; }
}