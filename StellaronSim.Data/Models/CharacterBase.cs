namespace StellaronSim.Data.Models;

public class CharacterBase
{
    public string Name { get; init; }
    
    public int Rarity { get; init; }
    
    public Element DamageType { get; init; }
    
    public IReadOnlyCollection<Skill> Skills { get; init; }
    
    public SkillTree SkillTree { get; init; }
    
    public int UltimateCost { get; init; }
}