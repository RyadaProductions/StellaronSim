using StellaronSim.ulatedUniverse.Abilities;
using System.Diagnostics;

namespace StellaronSim.ulatedUniverse;

public class Character
{
    public Character(string name, int level, int maxHP, int currentHP, int maxEnergy, int currentEnergy, float speed, float breakEffect, int? toughness, IEnumerable<Element>? weaknesses, bool eliteOrBoss, IEnumerable<Skill> skills)
    {
        Debug.Assert(!toughness.HasValue || toughness % 30 == 0); // The Toughness value of enemies is always a multiple of 30.  https://honkai-star-rail.fandom.com/wiki/Toughness
        if (toughness is null && weaknesses != null && weaknesses.Any())
        {
            throw new ArgumentException("Character must have toughness if it has a weakness.");
        }
        MaxHP = maxHP;
        CurrentHP = currentHP;
        MaxEnergy = maxEnergy;
        CurrentEnergy = currentEnergy;
        Speed = speed;
        BreakEffect = breakEffect;
        ToughnessBase = toughness;
        EliteOrBoss = eliteOrBoss;
        Weaknesses = weaknesses?.ToHashSet() ?? new HashSet<Element>();
        Name = name;
        Level = level;
        Skills = skills.ToList();
    }

    public List<Skill> Skills { get; internal set; }
    public float Speed { get; }
    public float BreakEffect { get; }
    public int? ToughnessBase { get; }
    public bool EliteOrBoss { get; }
    public IReadOnlySet<Element> Weaknesses { get; }
    public string Name { get; }
    public int Level { get; }
    public int MaxHP { get; }
    public int CurrentHP { get; protected set; }
    public int MaxEnergy { get; }
    public int CurrentEnergy { get; }

    public int Def => 200 + 10 * Level;

}