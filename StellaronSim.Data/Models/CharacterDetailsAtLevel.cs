namespace StellaronSim.Data.Models;

public class CharacterDetailsAtLevel : CharacterBase
{
    public int Level { get; init; }
    
    public int MaxEnergy { get; init; }
    
    public int CurrentEnergy { get; set; }
    
    public int CurrentHealth { get; set; }
    
    public int? Toughness { get; init; }
    
    public CharacterStats Stats { get; init; }
    
    public IReadOnlyCollection<Element> Weaknesses { get; init; }
    
    public double BreakEffect { get; init; }
    
    public bool IsEliteOrBoss { get; init; }
}