using System.Text.Json.Serialization;

namespace StellaronSim.Data.Models.Generated;

#pragma warning disable CS8618, CS8601, CS8603
internal class SkillElement
{
    [JsonPropertyName("id")]
    public long Id { get; set; }

    [JsonPropertyName("name")]
    public string Name { get; set; }

    [JsonPropertyName("descHash")]
    public string DescHash { get; set; }

    [JsonPropertyName("iconPath")]
    public string IconPath { get; set; }

    [JsonPropertyName("levelReq")]
    public long LevelReq { get; set; }

    [JsonPropertyName("promotionReq")]
    public long PromotionReq { get; set; }

    [JsonPropertyName("levelData")]
    public SkillLevelData[] LevelData { get; set; }

    [JsonPropertyName("ultimateCost")]
    public long UltimateCost { get; set; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("tagHash")]
    public TagHash? TagHash { get; set; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("typeDescHash")]
    public TypeDescHash? TypeDescHash { get; set; }
}