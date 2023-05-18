using System.Text.Json.Serialization;

namespace StellaronSim.Data.Models.Generated;

#pragma warning disable CS8618, CS8601, CS8603
internal class RelicRecommend
{
    [JsonPropertyName("twoPcSets")]
    public object[] TwoPcSets { get; set; }

    [JsonPropertyName("fourPcSets")]
    public object[] FourPcSets { get; set; }

    [JsonPropertyName("props")]
    public object[] Props { get; set; }
}