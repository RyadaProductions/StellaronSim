using System.Text.Json.Serialization;

namespace StellaronSim.Data.Models.Generated;

#pragma warning disable CS8618, CS8601, CS8603
public class ItemReference
{
    [JsonPropertyName("id")]
    public long Id { get; set; }

    [JsonPropertyName("type")]
    public long Type { get; set; }

    [JsonPropertyName("purposeId")]
    public long PurposeId { get; set; }

    [JsonPropertyName("iconPath")]
    public string IconPath { get; set; }

    [JsonPropertyName("name")]
    public string Name { get; set; }

    [JsonPropertyName("desc")]
    public string Desc { get; set; }

    [JsonPropertyName("lore")]
    public string Lore { get; set; }

    [JsonPropertyName("purpose")]
    public Purpose Purpose { get; set; }

    [JsonPropertyName("rarity")]
    public long Rarity { get; set; }

    [JsonPropertyName("rewardPath")]
    public string RewardPath { get; set; }

    [JsonPropertyName("comeFrom")]
    public object[] ComeFrom { get; set; }
}