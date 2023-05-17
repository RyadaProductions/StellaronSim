using System.Text.Json;
using System.Text.Json.Serialization;

namespace StellaronSim.Data.Models.Generated;

#pragma warning disable CS8618, CS8601, CS8603
internal class TagHashConverter : JsonConverter<TagHash>
{
    public override bool CanConvert(Type t) => t == typeof(TagHash);

    public override TagHash Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
    {
        var value = reader.GetString();
        return value switch
        {
            "" => TagHash.Empty,
            "AoE" => TagHash.AoE,
            "Blast" => TagHash.Blast,
            "Bounce" => TagHash.Bounce,
            "Defense" => TagHash.Defense,
            "Enhance" => TagHash.Enhance,
            "Impair" => TagHash.Impair,
            "Restore" => TagHash.Restore,
            "Single Target" => TagHash.SingleTarget,
            "Support" => TagHash.Support,
            _ => throw new Exception("Cannot unmarshal type TagHash")
        };
    }

    public override void Write(Utf8JsonWriter writer, TagHash value, JsonSerializerOptions options)
    {
        switch (value)
        {
            case TagHash.Empty:
                JsonSerializer.Serialize(writer, "", options);
                return;
            case TagHash.AoE:
                JsonSerializer.Serialize(writer, "AoE", options);
                return;
            case TagHash.Blast:
                JsonSerializer.Serialize(writer, "Blast", options);
                return;
            case TagHash.Bounce:
                JsonSerializer.Serialize(writer, "Bounce", options);
                return;
            case TagHash.Defense:
                JsonSerializer.Serialize(writer, "Defense", options);
                return;
            case TagHash.Enhance:
                JsonSerializer.Serialize(writer, "Enhance", options);
                return;
            case TagHash.Impair:
                JsonSerializer.Serialize(writer, "Impair", options);
                return;
            case TagHash.Restore:
                JsonSerializer.Serialize(writer, "Restore", options);
                return;
            case TagHash.SingleTarget:
                JsonSerializer.Serialize(writer, "Single Target", options);
                return;
            case TagHash.Support:
                JsonSerializer.Serialize(writer, "Support", options);
                return;
            default:
                throw new Exception("Cannot marshal type TagHash");
        }
    }

    public static readonly TagHashConverter Singleton = new TagHashConverter();
}