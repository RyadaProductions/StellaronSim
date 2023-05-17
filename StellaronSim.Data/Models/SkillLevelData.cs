using System.Text.Json.Serialization;

namespace StellaronSim.Data.Models;

#pragma warning disable CS8618, CS8601, CS8603
public class SkillLevelData
{
    [JsonPropertyName("level")]
    public long Level { get; set; }

    [JsonPropertyName("params")]
    public double[] Params { get; set; }

    [JsonPropertyName("cost")]
    public Cost[] Cost { get; set; }
}