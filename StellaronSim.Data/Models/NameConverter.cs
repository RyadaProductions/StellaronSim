using System.Text.Json;
using System.Text.Json.Serialization;

namespace StellaronSim.Data.Models;

#pragma warning disable CS8618, CS8601, CS8603
internal class NameConverter : JsonConverter<Name>
{
    public override bool CanConvert(Type t) => t == typeof(Name);

    public override Name Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
    {
        var value = reader.GetString();
        return value switch
        {
            "ATK Boost" => Name.AtkBoost,
            "Break Enhance" => Name.BreakEnhance,
            "CRIT DMG Boost" => Name.CritDmgBoost,
            "CRIT Rate Boost" => Name.CritRateBoost,
            "DEF Boost" => Name.DefBoost,
            "DMG Boost: Fire" => Name.DmgBoostFire,
            "DMG Boost: Ice" => Name.DmgBoostIce,
            "DMG Boost: Imaginary" => Name.DmgBoostImaginary,
            "DMG Boost: Lightning" => Name.DmgBoostLightning,
            "DMG Boost: Physical" => Name.DmgBoostPhysical,
            "DMG Boost: Quantum" => Name.DmgBoostQuantum,
            "DMG Boost: Wind" => Name.DmgBoostWind,
            "Effect Hit Rate Boost" => Name.EffectHitRateBoost,
            "Effect RES Boost" => Name.EffectResBoost,
            "HP Boost" => Name.HpBoost,
            _ => throw new Exception("Cannot unmarshal type Name")
        };
    }

    public override void Write(Utf8JsonWriter writer, Name value, JsonSerializerOptions options)
    {
        switch (value)
        {
            case Name.AtkBoost:
                JsonSerializer.Serialize(writer, "ATK Boost", options);
                return;
            case Name.BreakEnhance:
                JsonSerializer.Serialize(writer, "Break Enhance", options);
                return;
            case Name.CritDmgBoost:
                JsonSerializer.Serialize(writer, "CRIT DMG Boost", options);
                return;
            case Name.CritRateBoost:
                JsonSerializer.Serialize(writer, "CRIT Rate Boost", options);
                return;
            case Name.DefBoost:
                JsonSerializer.Serialize(writer, "DEF Boost", options);
                return;
            case Name.DmgBoostFire:
                JsonSerializer.Serialize(writer, "DMG Boost: Fire", options);
                return;
            case Name.DmgBoostIce:
                JsonSerializer.Serialize(writer, "DMG Boost: Ice", options);
                return;
            case Name.DmgBoostImaginary:
                JsonSerializer.Serialize(writer, "DMG Boost: Imaginary", options);
                return;
            case Name.DmgBoostLightning:
                JsonSerializer.Serialize(writer, "DMG Boost: Lightning", options);
                return;
            case Name.DmgBoostPhysical:
                JsonSerializer.Serialize(writer, "DMG Boost: Physical", options);
                return;
            case Name.DmgBoostQuantum:
                JsonSerializer.Serialize(writer, "DMG Boost: Quantum", options);
                return;
            case Name.DmgBoostWind:
                JsonSerializer.Serialize(writer, "DMG Boost: Wind", options);
                return;
            case Name.EffectHitRateBoost:
                JsonSerializer.Serialize(writer, "Effect Hit Rate Boost", options);
                return;
            case Name.EffectResBoost:
                JsonSerializer.Serialize(writer, "Effect RES Boost", options);
                return;
            case Name.HpBoost:
                JsonSerializer.Serialize(writer, "HP Boost", options);
                return;
            default:
                throw new Exception("Cannot marshal type Name");
        }
    }

    public static readonly NameConverter Singleton = new NameConverter();
}