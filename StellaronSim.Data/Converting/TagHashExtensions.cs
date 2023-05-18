using System.Data;
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
            throw new DataException($"Database is either corrupted or contains non existing/new element. Element name: {tagHash}");

        return skillType;
    }
}