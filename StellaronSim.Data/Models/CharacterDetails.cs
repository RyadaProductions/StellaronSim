namespace StellaronSim.Data.Models;

public class CharacterDetails : CharacterBase
{
    public IReadOnlyCollection<CharacterStats> BaseStats { get; init; }
    
    public IReadOnlyCollection<CharacterStats> PerLevelStats { get; init; }
}