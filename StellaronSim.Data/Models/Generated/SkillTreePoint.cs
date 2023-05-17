using System.Text.Json.Serialization;

namespace StellaronSim.Data.Models.Generated;

#pragma warning disable CS8618, CS8601, CS8603
public class SkillTreePoint
{
    [JsonPropertyName("id")]
    public long Id { get; set; }

    [JsonPropertyName("type")]
    public long Type { get; set; }

    [JsonPropertyName("children")]
    public SkillTreePoint[] Children { get; set; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("embedBonusSkill")]
    public SkillElement EmbedBonusSkill { get; set; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("embedBuff")]
    public EmbedBuff EmbedBuff { get; set; }
}