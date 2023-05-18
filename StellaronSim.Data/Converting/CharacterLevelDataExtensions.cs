using System.Diagnostics.Contracts;
using StellaronSim.Data.Models;
using StellaronSim.Data.Models.Generated;

namespace StellaronSim.Data.Converting;

internal static class CharacterLevelDataExtensions
{
    [Pure]
    internal static CharacterStats ToBaseCharacterStats(this CharacterLevelData levelData)
    {
        return new CharacterStats
        {
            Aggro = levelData.Aggro,
            CritDamage = levelData.Cdmg,
            CritRate = levelData.Crate,
            Promotion = levelData.Promotion,
            Attack = levelData.AttackBase,
            Defence = levelData.DefenseBase,
            Speed = levelData.SpeedBase,
            Health = levelData.HpBase
        };
    }
    
    [Pure]
    internal static CharacterStats ToGrowthCharacterStats(this CharacterLevelData levelData)
    {
        return new CharacterStats
        {
            Aggro = levelData.Aggro,
            CritDamage = levelData.Cdmg,
            CritRate = levelData.Crate,
            Promotion = levelData.Promotion,
            Attack = levelData.AttackAdd,
            Defence = levelData.DefenseAdd,
            Speed = levelData.SpeedAdd,
            Health = levelData.HpAdd
        };
    }
    
    [Pure]
    internal static CharacterStats ToCharacterStatsAtLevel(this CharacterLevelData levelData, int level)
    {
        return new CharacterStats
        {
            Aggro = levelData.Aggro,
            CritDamage = levelData.Cdmg,
            CritRate = levelData.Crate,
            Promotion = levelData.Promotion,
            Attack = levelData.AttackBase + (levelData.AttackAdd * level),
            Defence = levelData.DefenseBase + (levelData.DefenseAdd * level),
            Speed = levelData.SpeedBase + (levelData.SpeedAdd * level),
            Health = levelData.HpBase + (levelData.HpAdd * level)
        };
    }
}