using System.Text.Json.Serialization;

namespace StellaronSim.Data.Models.Generated;

#pragma warning disable CS8618, CS8601, CS8603
internal class EquipmentSkill
{
    [JsonPropertyName("id")]
    public long Id { get; set; }

    [JsonPropertyName("levelData")]
    public object[] LevelData { get; set; }
}