using System.Text.Json;
using System.Text.Json.Serialization;

namespace StellaronSim.Data.Models;

#pragma warning disable CS8618, CS8601, CS8603
internal class PurposeConverter : JsonConverter<Purpose>
{
    public override bool CanConvert(Type t) => t == typeof(Purpose);

    public override Purpose Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
    {
        var value = reader.GetString();
        return value switch
        {
            "Character Ascension Materials" => Purpose.CharacterAscensionMaterials,
            "Character EXP Material" => Purpose.CharacterExpMaterial,
            "Common currency" => Purpose.CommonCurrency,
            "Light Cone EXP Material" => Purpose.LightConeExpMaterial,
            "Trace Material<br />Character Ascension Materials" => Purpose.TraceMaterialBrCharacterAscensionMaterials,
            "Trace Material<br />Light Cone Ascension Material" => Purpose.TraceMaterialBrLightConeAscensionMaterial,
            "Trace Materials" => Purpose.TraceMaterials,
            _ => throw new Exception("Cannot unmarshal type Purpose")
        };
    }

    public override void Write(Utf8JsonWriter writer, Purpose value, JsonSerializerOptions options)
    {
        switch (value)
        {
            case Purpose.CharacterAscensionMaterials:
                JsonSerializer.Serialize(writer, "Character Ascension Materials", options);
                return;
            case Purpose.CharacterExpMaterial:
                JsonSerializer.Serialize(writer, "Character EXP Material", options);
                return;
            case Purpose.CommonCurrency:
                JsonSerializer.Serialize(writer, "Common currency", options);
                return;
            case Purpose.LightConeExpMaterial:
                JsonSerializer.Serialize(writer, "Light Cone EXP Material", options);
                return;
            case Purpose.TraceMaterialBrCharacterAscensionMaterials:
                JsonSerializer.Serialize(writer, "Trace Material<br />Character Ascension Materials", options);
                return;
            case Purpose.TraceMaterialBrLightConeAscensionMaterial:
                JsonSerializer.Serialize(writer, "Trace Material<br />Light Cone Ascension Material", options);
                return;
            case Purpose.TraceMaterials:
                JsonSerializer.Serialize(writer, "Trace Materials", options);
                return;
            default:
                throw new Exception("Cannot marshal type Purpose");
        }
    }

    public static readonly PurposeConverter Singleton = new PurposeConverter();
}