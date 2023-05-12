using System.Text.Json;

namespace StellaronSim.Data.Models;

#pragma warning disable CS8618, CS8601, CS8603
public static class Serialize
{
    public static string ToJson(this CalculatorConfig self) => JsonSerializer.Serialize(self, Converter.Settings);
}