using System.Text.Json;
using System.Text.Json.Serialization;

namespace StellaronSim.Data.Models.Generated;

#pragma warning disable CS8618, CS8601, CS8603
public class CalculatorConfig
{
    [JsonPropertyName("characters")]
    public Dictionary<string, Character> Characters { get; set; }

    [JsonPropertyName("equipment")]
    public Dictionary<string, Equipment> Equipment { get; set; }

    [JsonPropertyName("itemReferences")]
    public Dictionary<string, ItemReference> ItemReferences { get; set; }

    [JsonPropertyName("itemFilters")]
    public ItemFilter[] ItemFilters { get; set; }
    
    public static CalculatorConfig FromJson(string json) => JsonSerializer.Deserialize<CalculatorConfig>(json, Converter.Settings);
}