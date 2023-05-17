using System.Diagnostics;

namespace StellaronSim.ulatedUniverse.Abilities;

public class PrepareSkill : Skill
{
    readonly Skill? _baseSkill;
    readonly Skill _preparedSkill;

    /// <param name="baseSkill">Base skill effect other than preparing the attack. For example, Imaginary Weaver 'Reverberating Carol' skill prepare an attack and damage enemies in the same turn.</param>
    public PrepareSkill(Skill? baseSkill, Skill preparedSkill)
    {
        _baseSkill = baseSkill;
        _preparedSkill = preparedSkill;
    }

    public override void Use(CharacterInBattle caster, IEnumerable<CharacterInBattle> targets)
    {
        if (_baseSkill != null)
        {
            _baseSkill.Use(caster, targets);
        }
        else
        {
            Debug.Assert(!targets.Any());
        }
        var wrapper = new PrepareSkillWrapper(caster.Skills, _preparedSkill);
        caster.Skills = new List<Skill> { wrapper };
    }

    /// <summary>
    /// Blocks casters skills until used
    /// </summary>
    class PrepareSkillWrapper : Skill
    {
        readonly List<Skill> _skills;
        readonly Skill _preparedSkill;

        public PrepareSkillWrapper(List<Skill> skills, Skill preparedSkill)
        {
            _skills = skills;
            _preparedSkill = preparedSkill;
        }

        public override void Use(CharacterInBattle caster, IEnumerable<CharacterInBattle> targets)
        {
            caster.Skills = _skills;
            _preparedSkill.Use(caster, targets);
        }
    }
}