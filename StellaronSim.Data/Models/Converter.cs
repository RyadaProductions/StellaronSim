using System.Text.Json;

namespace StellaronSim.Data.Models;

#pragma warning disable CS8618, CS8601, CS8603
internal static class Converter
{
    public static readonly JsonSerializerOptions Settings = new(JsonSerializerDefaults.General)
    {
        Converters =
        {
            TagHashConverter.Singleton,
            TypeDescHashConverter.Singleton,
            IconPathConverter.Singleton,
            NameConverter.Singleton,
            KeyConverter.Singleton,
            PurposeConverter.Singleton,
            new DateOnlyConverter(),
            new TimeOnlyConverter(),
            IsoDateTimeOffsetConverter.Singleton
        },
    };
}