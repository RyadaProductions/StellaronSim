using System.Text.Json;
using System.Text.Json.Serialization;

namespace StellaronSim.Data.Models.Generated;

#pragma warning disable CS8618, CS8601, CS8603
internal class TypeDescHashConverter : JsonConverter<TypeDescHash>
{
    public override bool CanConvert(Type t) => t == typeof(TypeDescHash);

    public override TypeDescHash Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
    {
        var value = reader.GetString();
        return value switch
        {
            "" => TypeDescHash.Empty,
            "Basic ATK" => TypeDescHash.BasicAtk,
            "Skill" => TypeDescHash.Skill,
            "Talent" => TypeDescHash.Talent,
            "Technique" => TypeDescHash.Technique,
            "Ultimate" => TypeDescHash.Ultimate,
            _ => throw new Exception("Cannot unmarshal type TypeDescHash")
        };
    }

    public override void Write(Utf8JsonWriter writer, TypeDescHash value, JsonSerializerOptions options)
    {
        switch (value)
        {
            case TypeDescHash.Empty:
                JsonSerializer.Serialize(writer, "", options);
                return;
            case TypeDescHash.BasicAtk:
                JsonSerializer.Serialize(writer, "Basic ATK", options);
                return;
            case TypeDescHash.Skill:
                JsonSerializer.Serialize(writer, "Skill", options);
                return;
            case TypeDescHash.Talent:
                JsonSerializer.Serialize(writer, "Talent", options);
                return;
            case TypeDescHash.Technique:
                JsonSerializer.Serialize(writer, "Technique", options);
                return;
            case TypeDescHash.Ultimate:
                JsonSerializer.Serialize(writer, "Ultimate", options);
                return;
            default:
                throw new Exception("Cannot marshal type TypeDescHash");
        }
    }

    public static readonly TypeDescHashConverter Singleton = new TypeDescHashConverter();
}