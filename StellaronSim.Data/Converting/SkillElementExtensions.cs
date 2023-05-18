using System.Data;
using System.Diagnostics.Contracts;
using StellaronSim.Data.Models;
using StellaronSim.Data.Models.Generated;

namespace StellaronSim.Data.Converting;

internal static class SkillElementExtensions
{
    [Pure]
    internal static Skill ToSkill(this SkillElement skillElement)
    {
        if (!Enum.TryParse(skillElement.TypeDescHash.ToString(), out AbilityType abilityType))
            throw new DataException($"Database is either corrupted or contains non existing/new element. Element name: {skillElement.TypeDescHash}");
        if (!Enum.TryParse(skillElement.TagHash.ToString(), out SkillType skillType))
            throw new DataException($"Database is either corrupted or contains non existing/new element. Element name: {skillElement.TagHash}");

        return new Skill
        {
            Name = skillElement.Name,
            Type = skillType,
            ability = abilityType,
            ParametersByLevel = skillElement.LevelData.ToDictionary(levelData => Convert.ToInt32(levelData.Level), levelData => levelData.Params)
        };
    }
}