using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StellaronSim.ulatedUniverse.Abilities;

namespace StellaronSim.ulatedUniverse;

public class FollowUpAttack
{
    public FollowUpAttack(Skill ability, IEnumerable<Character> targets)
    {
        Ability = ability;
        Targets = targets.ToArray();
    }

    public Skill Ability { get; }
    public IReadOnlyList<Character> Targets { get; }
}
