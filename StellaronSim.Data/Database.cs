using StellaronSim.Data.Models;
using StellaronSim.Data.Models.Generated;

namespace StellaronSim.Data;

public class Database
{
    private readonly CalculatorConfig _simulationData;

    public Database(string json)
    {
        // TODO: add a way to just supply the json location instead of the actual json data (and reinit maybe?)
        _simulationData = CalculatorConfig.FromJson(json);
    }

    public Character GetCharacter(string characterName)
    {
        if (!_simulationData.Characters.ContainsKey(characterName))
            throw new ArgumentException($"character with name {characterName} does not exist", nameof(characterName));
        
        return _simulationData.Characters[characterName];
    }
    
    public CharacterStats GetStatsAtLevel(string characterName, int level)
    {
        if (level is <= 0 or > 80)
            throw new ArgumentOutOfRangeException(nameof(level), "level is not allowed to be smaller than 0 or bigger than 80");
        
        var character = GetCharacter(characterName);
        var levelData = character.LevelData
            .Where(x => x.MaxLevel > level)
            .MinBy(x => x.MaxLevel);
        if (levelData is null) return new CharacterStats();
        
        return new CharacterStats()
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