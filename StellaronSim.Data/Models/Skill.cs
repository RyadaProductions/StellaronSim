namespace StellaronSim.Data.Models;

public class Skill
{
    public string Name { get; init; }
    
    public SkillType Type { get; init; }
    
    public AbilityType ability { get; init; }
    
    public IReadOnlyDictionary<int, double[]> ParametersByLevel { get; init; }
}