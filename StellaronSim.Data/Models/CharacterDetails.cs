using StellaronSim.Data.Models.Generated;

namespace StellaronSim.Data.Models;

public class CharacterDetails
{
    public string Name { get; set; }
    
    public int Rarity { get; set; }
    
    public Element DamageType { get; set; }
    
    public IReadOnlyCollection<CharacterStats> BaseStats { get; set; }
    
    public IReadOnlyCollection<CharacterStats> PerLevelStats { get; set; }
    
    // GeneratedType
    public SkillElement[] Skills { get; set; }
    
    // Generated type
    public SkillTreePoint[] SkillTreePoints { get; set; }
}