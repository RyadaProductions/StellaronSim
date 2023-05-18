using System.Text.Json.Serialization;

namespace StellaronSim.Data.Models.Generated;

#pragma warning disable CS8618, CS8601, CS8603
internal class Equipment
{
    [JsonPropertyName("name")]
    public string Name { get; set; }

    [JsonPropertyName("rarity")]
    public long Rarity { get; set; }

    [JsonPropertyName("iconPath")]
    public string IconPath { get; set; }

    [JsonPropertyName("baseTypeId")]
    public long BaseTypeId { get; set; }

    [JsonPropertyName("itemReferences")]
    public Archive ItemReferences { get; set; }

    [JsonPropertyName("levelData")]
    public EquipmentLevelData[] LevelData { get; set; }

    [JsonPropertyName("skill")]
    public EquipmentSkill Skill { get; set; }

    [JsonPropertyName("calculator")]
    public EquipmentCalculator Calculator { get; set; }

    [JsonPropertyName("pageId")]
    [JsonConverter(typeof(ParseStringConverter))]
    public long PageId { get; set; }
}