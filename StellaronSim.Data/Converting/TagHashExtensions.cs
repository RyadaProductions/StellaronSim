using System.Diagnostics.Contracts;
using StellaronSim.Data.Models;
using StellaronSim.Data.Models.Generated;

namespace StellaronSim.Data.Converting;

internal static class TagHashExtensions
{
    [Pure]
    internal static SkillType ToSkillType(this TagHash? tagHash)
    {
        if (!Enum.TryParse(tagHash.ToString(), out SkillType skillType))
            return SkillType.Empty;

        return skillType;
    }
}