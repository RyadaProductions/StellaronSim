﻿using System.Text.Json.Serialization;

namespace StellaronSim.Data.Models;

#pragma warning disable CS8618, CS8601, CS8603
public class CharacterCalculator
{
    [JsonPropertyName("expCost")]
    public Dictionary<string, long> ExpCost { get; set; }

    [JsonPropertyName("expItemConfig")]
    public Dictionary<string, long> ExpItemConfig { get; set; }

    [JsonPropertyName("sCoinId")]
    public long SCoinId { get; set; }
}