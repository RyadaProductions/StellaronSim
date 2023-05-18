using System.Text.Json.Serialization;

namespace StellaronSim.Data.Models.Generated;

#pragma warning disable CS8618, CS8601, CS8603
internal class EquipmentLevelData
{
    [JsonPropertyName("promotion")]
    public long Promotion { get; set; }

    [JsonPropertyName("maxLevel")]
    public long MaxLevel { get; set; }

    [JsonPropertyName("cost")]
    public Cost[] Cost { get; set; }

    [JsonPropertyName("attackBase")]
    public double AttackBase { get; set; }

    [JsonPropertyName("attackAdd")]
    public double AttackAdd { get; set; }

    [JsonPropertyName("hpBase")]
    public double HpBase { get; set; }

    [JsonPropertyName("hpAdd")]
    public double HpAdd { get; set; }

    [JsonPropertyName("defenseBase")]
    public double DefenseBase { get; set; }

    [JsonPropertyName("defenseAdd")]
    public double DefenseAdd { get; set; }
}