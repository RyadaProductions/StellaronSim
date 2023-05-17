using System.Diagnostics;

namespace StellaronSim.ulatedUniverse.Abilities;

public abstract class Skill
{
    public abstract void Use(CharacterInBattle caster, IEnumerable<CharacterInBattle> targets);
}
