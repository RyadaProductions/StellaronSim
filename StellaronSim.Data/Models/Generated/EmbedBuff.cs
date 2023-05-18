using System.Text.Json.Serialization;

namespace StellaronSim.Data.Models.Generated;

#pragma warning disable CS8618, CS8601, CS8603
internal class EmbedBuff
{
    [JsonPropertyName("id")]
    public long Id { get; set; }

    [JsonPropertyName("name")]
    public Name Name { get; set; }

    [JsonPropertyName("levelReq")]
    public long LevelReq { get; set; }

    [JsonPropertyName("promotionReq")]
    public long PromotionReq { get; set; }

    [JsonPropertyName("iconPath")]
    public IconPath IconPath { get; set; }

    [JsonPropertyName("statusList")]
    public StatusList[] StatusList { get; set; }

    [JsonPropertyName("cost")]
    public Cost[] Cost { get; set; }
}