using System.Data;
using StellaronSim.Data.Converting;
using StellaronSim.Data.Models;
using StellaronSim.Data.Models.Generated;

namespace StellaronSim.Data;

public class Database
{
    private readonly CalculatorConfig _simulationData;
    
    private const int MaxLevelAllowed = 80;

    public Database(string json)
    {
        // TODO: add a way to just supply the json location instead of the actual json data (and reinit maybe?)
        _simulationData = CalculatorConfig.FromJson(json);
    }

    private Character GetInternalCharacter(string characterName)
    {
        if (!_simulationData.Characters.ContainsKey(characterName))
            throw new ArgumentException($"character with name {characterName} does not exist", nameof(characterName));

        return _simulationData.Characters[characterName];
    }

    public CharacterDetails GetCharacter(string characterName)
    {
        return GetInternalCharacter(characterName).ToCharacterDetails();
    }
    
    public CharacterStats GetStatsAtLevel(string characterName, int level)
    {
        if (level is <= 0 or > MaxLevelAllowed)
            throw new ArgumentOutOfRangeException(nameof(level), "level is not allowed to be smaller than 0 or bigger than 80");
        
        var character = GetInternalCharacter(characterName);
        var levelData = character.LevelData
            .Where(x => x.MaxLevel > level)
            .MinBy(x => x.MaxLevel);
        
        if (levelData is null)
            throw new DataException("Can't find data for specified level in levelData. Data might be corrupt");
        
        return levelData.ToCharacterStatsAtLevel(level);
    }
}