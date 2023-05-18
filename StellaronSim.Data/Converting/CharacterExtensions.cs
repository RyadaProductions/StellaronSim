using System.Collections.ObjectModel;
using System.Data;
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
            Rarity = Convert.ToInt32(character.Rarity),
            DamageType = character.DamageType.ToElement(),
            Skills = character.Skills,
            BaseStats = new ReadOnlyCollection<CharacterStats>(baseStats),
            PerLevelStats = new ReadOnlyCollection<CharacterStats>(growthStats),
            SkillTreePoints = character.SkillTreePoints
        };
    }
}