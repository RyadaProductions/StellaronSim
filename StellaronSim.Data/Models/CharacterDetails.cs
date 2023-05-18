using StellaronSim.Data.Models.Generated;

namespace StellaronSim.Data.Models;

public class CharacterDetails
{
    public string Name { get; init; }
    
    public int Rarity { get; init; }
    
    public Element DamageType { get; init; }
    
    public IReadOnlyCollection<CharacterStats> BaseStats { get; init; }
    
    public IReadOnlyCollection<CharacterStats> PerLevelStats { get; init; }
    
    // GeneratedType
    internal SkillElement[] Skills { get; init; }
    
    // Generated type
    internal SkillTreePoint[] SkillTreePoints { get; init; }
}