using System.Text.Json;
using System.Text.Json.Serialization;

namespace StellaronSim.Data.Models;

#pragma warning disable CS8618, CS8601, CS8603
internal class KeyConverter : JsonConverter<Key>
{
    public override bool CanConvert(Type t) => t == typeof(Key);

    public override Key Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
    {
        var value = reader.GetString();
        return value switch
        {
            "<span style=\"color:#00FF9C;\">Wind</span> DMG Boost" => Key.SpanStyleColor00Ff9CWindSpanDmgBoost,
            "<span style=\"color:#47C7FD;\">Ice</span> DMG Boost" => Key.SpanStyleColor47C7FdIceSpanDmgBoost,
            "<span style=\"color:#7788ff;\">Quantum</span> DMG Boost" => Key.SpanStyleColor7788FfQuantumSpanDmgBoost,
            "<span style=\"color:#F4D258;\">Imaginary</span> DMG Boost" =>
                Key.SpanStyleColorF4D258ImaginarySpanDmgBoost,
            "<span style=\"color:#F84F36;\">Fire</span> DMG Boost" => Key.SpanStyleColorF84F36FireSpanDmgBoost,
            "<span style=\"color:#FFFFFF;\">Physical</span> DMG Boost" => Key.SpanStyleColorFfffffPhysicalSpanDmgBoost,
            "<span style=\"color:#c75de2;\">Lightning</span> DMG Boost" =>
                Key.SpanStyleColorC75De2LightningSpanDmgBoost,
            "ATK" => Key.Atk,
            "Break Effect" => Key.BreakEffect,
            "CRIT DMG" => Key.CritDmg,
            "CRIT Rate" => Key.CritRate,
            "DEF" => Key.Def,
            "Effect Hit Rate" => Key.EffectHitRate,
            "Effect RES" => Key.EffectRes,
            "HP" => Key.Hp,
            _ => throw new Exception("Cannot unmarshal type Key")
        };
    }

    public override void Write(Utf8JsonWriter writer, Key value, JsonSerializerOptions options)
    {
        switch (value)
        {
            case Key.SpanStyleColor00Ff9CWindSpanDmgBoost:
                JsonSerializer.Serialize(writer, "<span style=\"color:#00FF9C;\">Wind</span> DMG Boost", options);
                return;
            case Key.SpanStyleColor47C7FdIceSpanDmgBoost:
                JsonSerializer.Serialize(writer, "<span style=\"color:#47C7FD;\">Ice</span> DMG Boost", options);
                return;
            case Key.SpanStyleColor7788FfQuantumSpanDmgBoost:
                JsonSerializer.Serialize(writer, "<span style=\"color:#7788ff;\">Quantum</span> DMG Boost", options);
                return;
            case Key.SpanStyleColorF4D258ImaginarySpanDmgBoost:
                JsonSerializer.Serialize(writer, "<span style=\"color:#F4D258;\">Imaginary</span> DMG Boost", options);
                return;
            case Key.SpanStyleColorF84F36FireSpanDmgBoost:
                JsonSerializer.Serialize(writer, "<span style=\"color:#F84F36;\">Fire</span> DMG Boost", options);
                return;
            case Key.SpanStyleColorFfffffPhysicalSpanDmgBoost:
                JsonSerializer.Serialize(writer, "<span style=\"color:#FFFFFF;\">Physical</span> DMG Boost", options);
                return;
            case Key.SpanStyleColorC75De2LightningSpanDmgBoost:
                JsonSerializer.Serialize(writer, "<span style=\"color:#c75de2;\">Lightning</span> DMG Boost", options);
                return;
            case Key.Atk:
                JsonSerializer.Serialize(writer, "ATK", options);
                return;
            case Key.BreakEffect:
                JsonSerializer.Serialize(writer, "Break Effect", options);
                return;
            case Key.CritDmg:
                JsonSerializer.Serialize(writer, "CRIT DMG", options);
                return;
            case Key.CritRate:
                JsonSerializer.Serialize(writer, "CRIT Rate", options);
                return;
            case Key.Def:
                JsonSerializer.Serialize(writer, "DEF", options);
                return;
            case Key.EffectHitRate:
                JsonSerializer.Serialize(writer, "Effect Hit Rate", options);
                return;
            case Key.EffectRes:
                JsonSerializer.Serialize(writer, "Effect RES", options);
                return;
            case Key.Hp:
                JsonSerializer.Serialize(writer, "HP", options);
                return;
            default:
                throw new Exception("Cannot marshal type Key");
        }
    }

    public static readonly KeyConverter Singleton = new KeyConverter();
}