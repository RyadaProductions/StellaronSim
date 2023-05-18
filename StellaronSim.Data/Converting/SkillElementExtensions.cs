﻿using System.Diagnostics.Contracts;
using StellaronSim.Data.Models;
using StellaronSim.Data.Models.Generated;

namespace StellaronSim.Data.Converting;

internal static class SkillElementExtensions
{
    [Pure]
    internal static Skill ToSkill(this SkillElement skillElement)
    {
        return new Skill
        {
            Name = skillElement.Name,
            Type = skillElement.TagHash.ToSkillType(),
            ability = skillElement.TypeDescHash.ToAbilityType(),
            ParametersByLevel = skillElement.LevelData.ToDictionary(levelData => Convert.ToInt32(levelData.Level), levelData => levelData.Params)
        };
    }

    [Pure]
    internal static SkillTreeNode ToSkillTreeNode(this SkillElement skillElement)
    {    
        return new SkillTreeNode
        {
            Name = skillElement.Name,
            Type = SkillTreeNodeType.Skill,
            Description = skillElement.DescHash,
            LevelRequirement = skillElement.LevelReq.ToInt(),
            PromotionRequirement = skillElement.PromotionReq.ToInt()
        };
    }
}