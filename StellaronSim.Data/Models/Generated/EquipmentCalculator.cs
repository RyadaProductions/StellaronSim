﻿using System.Text.Json.Serialization;

namespace StellaronSim.Data.Models.Generated;

#pragma warning disable CS8618, CS8601, CS8603
internal class EquipmentCalculator
{
    [JsonPropertyName("expCost")]
    public Dictionary<string, long> ExpCost { get; set; }

    [JsonPropertyName("expItemConfig")]
    public Dictionary<string, ExpItemConfig> ExpItemConfig { get; set; }

    [JsonPropertyName("sCoinId")]
    public long SCoinId { get; set; }
}