using StellaronSim.Data.Models.Generated;

namespace StellaronSim.Data.Models;

public class CharacterBase
{
    public string Name { get; init; }
    
    public int Rarity { get; init; }
    
    public Element DamageType { get; init; }
    
    public IEnumerable<Skill> Skills { get; init; }
    
    // Generated type
    internal SkillTreePoint[] SkillTreePoints { get; init; }
}