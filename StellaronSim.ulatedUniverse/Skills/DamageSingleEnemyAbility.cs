namespace StellaronSim.ulatedUniverse.Abilities;

public class DamageSingleEnemyAbility : Skill
{
    readonly Element _attackElement;
    readonly float _damage;
    private readonly int _toughnessDamage;

    public DamageSingleEnemyAbility(Element attackElement, float damage, int toughnessDamage)
    {
        _attackElement = attackElement;
        _damage = damage;
        _toughnessDamage = toughnessDamage;
    }

    public override void Use(CharacterInBattle caster, IEnumerable<CharacterInBattle> targets)
    {
        var target = targets.Single();
        target.Damage(caster, _attackElement, _damage, _toughnessDamage, false);
    }
}
