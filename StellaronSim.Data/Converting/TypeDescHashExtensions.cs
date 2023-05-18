using System.Diagnostics.Contracts;
using StellaronSim.Data.Models;
using StellaronSim.Data.Models.Generated;

namespace StellaronSim.Data.Converting;

internal static class TypeDescHashExtensions
{
    [Pure]
    internal static AbilityType ToAbilityType(this TypeDescHash? typeDescHash)
    {
        if (!Enum.TryParse(typeDescHash.ToString(), out AbilityType abilityType))
            return AbilityType.Empty;

        return abilityType;
    }
}