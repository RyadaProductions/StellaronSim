using System.Collections.ObjectModel;
using System.Diagnostics.Contracts;
using StellaronSim.Data.Models;
using StellaronSim.Data.Models.Generated;

namespace StellaronSim.Data.Converting;

internal static class CharacterExtensions
{
    [Pure]
    internal static CharacterDetails ToCharacterDetails(this Character character)
    {
        IList<CharacterStats> baseStats = new List<CharacterStats>();
        IList<CharacterStats> growthStats = new List<CharacterStats>();

        foreach (var levelData in character.LevelData)
        {
            baseStats.Add(levelData.ToBaseCharacterStats());
            growthStats.Add(levelData.ToGrowthCharacterStats());
        }

        return new CharacterDetails
        {
            Name = character.Name,
            Rarity = character.Rarity.ToInt(),
            DamageType = character.DamageType.ToElement(),
            Skills = character.Skills.Select(x => x.ToSkill()).ToList(),
            BaseStats = baseStats.AsReadOnly(),
            PerLevelStats = growthStats.AsReadOnly(),
            SkillTree = character.SkillTreePoints.ToSkillTree(),
            UltimateCost = character.Skills.First(x => x.UltimateCost > 0).UltimateCost.ToInt()
        };
    }
}