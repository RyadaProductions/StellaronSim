using System.Text.Json.Serialization;

namespace StellaronSim.Data.Models;

#pragma warning disable CS8618, CS8601, CS8603
public class Character
{
    [JsonPropertyName("name")]
    public string Name { get; set; }

    [JsonPropertyName("spRequirement")]
    public long SpRequirement { get; set; }

    [JsonPropertyName("rarity")]
    public long Rarity { get; set; }

    [JsonPropertyName("miniIconPath")]
    public string MiniIconPath { get; set; }

    [JsonPropertyName("damageType")]
    public DamageType DamageType { get; set; }

    [JsonPropertyName("damageTypeId")]
    public long DamageTypeId { get; set; }

    [JsonPropertyName("baseTypeId")]
    public long BaseTypeId { get; set; }

    [JsonPropertyName("itemReferences")]
    public Archive ItemReferences { get; set; }

    [JsonPropertyName("levelData")]
    public CharacterLevelDatum[] LevelData { get; set; }

    [JsonPropertyName("ranks")]
    public object[] Ranks { get; set; }

    [JsonPropertyName("skillGrouping")]
    public long[][] SkillGrouping { get; set; }

    [JsonPropertyName("skills")]
    public SkillElement[] Skills { get; set; }

    [JsonPropertyName("skillTreePoints")]
    public SkillTreePoint[] SkillTreePoints { get; set; }

    [JsonPropertyName("relicRecommend")]
    public RelicRecommend RelicRecommend { get; set; }

    [JsonPropertyName("voiceItems")]
    public object[] VoiceItems { get; set; }

    [JsonPropertyName("storyItems")]
    public object[] StoryItems { get; set; }

    [JsonPropertyName("archive")]
    public Archive Archive { get; set; }

    [JsonPropertyName("calculator")]
    public CharacterCalculator Calculator { get; set; }

    [JsonPropertyName("pageId")]
    public string PageId { get; set; }
}