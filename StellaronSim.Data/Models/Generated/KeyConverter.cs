using System.Text.Json;
using System.Text.Json.Serialization;

namespace StellaronSim.Data.Models.Generated;

#pragma warning disable CS8618, CS8601, CS8603
internal class KeyConverter : JsonConverter<Key>
{
    public override bool CanConvert(Type t) => t == typeof(Key);

    public override Key Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
    {
        var value = reader.GetString();
        return value switch
        {
            "<span style=\"color:#00FF9C;\">Wind</span> DMG Boost" => Key.WindDmgBoost,
            "<span style=\"color:#47C7FD;\">Ice</span> DMG Boost" => Key.IceDmgBoost,
            "<span style=\"color:#7788ff;\">Quantum</span> DMG Boost" => Key.QuantumDmgBoost,
            "<span style=\"color:#F4D258;\">Imaginary</span> DMG Boost" =>
                Key.ImaginaryDmgBoost,
            "<span style=\"color:#F84F36;\">Fire</span> DMG Boost" => Key.FireDmgBoost,
            "<span style=\"color:#FFFFFF;\">Physical</span> DMG Boost" => Key.PhysicalDmgBoost,
            "<span style=\"color:#c75de2;\">Lightning</span> DMG Boost" =>
                Key.LightningDmgBoost,
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
            case Key.WindDmgBoost:
                JsonSerializer.Serialize(writer, "<span style=\"color:#00FF9C;\">Wind</span> DMG Boost", options);
                return;
            case Key.IceDmgBoost:
                JsonSerializer.Serialize(writer, "<span style=\"color:#47C7FD;\">Ice</span> DMG Boost", options);
                return;
            case Key.QuantumDmgBoost:
                JsonSerializer.Serialize(writer, "<span style=\"color:#7788ff;\">Quantum</span> DMG Boost", options);
                return;
            case Key.ImaginaryDmgBoost:
                JsonSerializer.Serialize(writer, "<span style=\"color:#F4D258;\">Imaginary</span> DMG Boost", options);
                return;
            case Key.FireDmgBoost:
                JsonSerializer.Serialize(writer, "<span style=\"color:#F84F36;\">Fire</span> DMG Boost", options);
                return;
            case Key.PhysicalDmgBoost:
                JsonSerializer.Serialize(writer, "<span style=\"color:#FFFFFF;\">Physical</span> DMG Boost", options);
                return;
            case Key.LightningDmgBoost:
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