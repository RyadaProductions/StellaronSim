namespace StellaronSim.ulatedUniverse.Abilities;

public class DamageEnemyAndAdjacent : Skill
{
    readonly Element _element;
    readonly int _damage;
    readonly int _adjacentDamage;
    readonly int _toughnessDamage;
    readonly bool _isDotDmg;

    public DamageEnemyAndAdjacent(Element element, int damage, int adjacentDamage, int toughnessDamage)
    {
        _element = element;
        _damage = damage;
        _adjacentDamage = adjacentDamage;
        _toughnessDamage = toughnessDamage;
    }

    public override void Use(CharacterInBattle caster, IEnumerable<CharacterInBattle> targets)
    {
        var target = targets.Single();
        target.Damage(caster, _element, _damage, _toughnessDamage, false);
        target.OnLeft?.Damage(caster, _element, _adjacentDamage, _toughnessDamage, false);
        target.OnRight?.Damage(caster, _element, _adjacentDamage, _toughnessDamage, false);
    }
}
