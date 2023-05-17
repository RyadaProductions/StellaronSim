using StellaronSim.ulatedUniverse.Abilities;

namespace StellaronSim.ulatedUniverse;

public class CharacterInBattle : Character
{
    readonly List<StatusEffects> _statusEffects = new();

    internal CharacterInBattle(Battle battle, Character character)
        : base(name: character.Name,
               level: character.Level,
               maxHP: character.MaxHP,
               currentHP: character.CurrentHP,
               maxEnergy: character.MaxEnergy,
               currentEnergy: character.CurrentEnergy,
               speed: character.Speed,
               breakEffect: character.BreakEffect,
               toughness: character.ToughnessBase,
               weaknesses: character.Weaknesses,
               eliteOrBoss: character.EliteOrBoss, skills: character.Skills)
    {
        Battle = battle;
        BaseActionValue = 10_000 / character.Speed;
        CurrentHP = MaxHP;
        CurrentToughness = ToughnessBase;
        ActionValue = BaseActionValue;
    }

    public int? CurrentToughness { get; private set; }
    public int Shield { get; private set; }
    public float BaseActionValue { get; private set; }
    public float ActionValue { get; private set; }
    public int DisplayActionValue => (int)Math.Ceiling(ActionValue);
    public float DefReduction { get; }
    readonly Dictionary<Element, float> _resPen = new()
    {
        { Element.Fire, 0 },
        { Element.Ice, 0 },
        { Element.Imaginary, 0 },
        { Element.Lightning, 0 },
        { Element.Physical, 0 },
        { Element.Quantum, 0 },
        { Element.Wind, 0 }
    };
    readonly Dictionary<Element, float> _res = new()
    {
        { Element.Fire, 0 },
        { Element.Ice, 0 },
        { Element.Imaginary, 0 },
        { Element.Lightning, 0 },
        { Element.Physical, 0 },
        { Element.Quantum, 0 },
        { Element.Wind, 0 }
    };

    readonly Dictionary<Element, float> _dmgTakenMultiplier = new()
    {
        { Element.Fire, 0 },
        { Element.Ice, 0 },
        { Element.Imaginary, 0 },
        { Element.Lightning, 0 },
        { Element.Physical, 0 },
        { Element.Quantum, 0 },
        { Element.Wind, 0 }
    };

    readonly Dictionary<Element, float> _dotDmgTakenMultiplier = new()
    {
        { Element.Fire, 0 },
        { Element.Ice, 0 },
        { Element.Imaginary, 0 },
        { Element.Lightning, 0 },
        { Element.Physical, 0 },
        { Element.Quantum, 0 },
        { Element.Wind, 0 }
    };

    public IReadOnlyDictionary<Element, float> ResPen => _resPen;
    public IReadOnlyDictionary<Element, float> DamageRes => _res;
    public IReadOnlyList<StatusEffects> StatusEffects => _statusEffects;

    public void AdvanceAction(float advancement)
    {
        if (advancement > ActionValue) advancement = ActionValue;
        ActionValue -= advancement;
    }
    public void AdvanceActionPercent(float actionAdvancementPercent)
    {
        var oldBase = BaseActionValue;
        BaseActionValue = 10_000 / Speed;
        var old = ActionValue;
        var computedBase = ((old * BaseActionValue) / oldBase);
        var lost = BaseActionValue * (actionAdvancementPercent);
        ActionValue = computedBase - lost;
    }

    internal void Damage(CharacterInBattle attacker, Element attackElement, float baseDamage, int? toughnessDamage, bool isDotDmg)
    {
        if (Weaknesses.Contains(attackElement) && CurrentToughness.HasValue && toughnessDamage.HasValue)
        {
            bool wasBreak = CurrentToughness == 0;
            CurrentToughness -= toughnessDamage;
            if (CurrentToughness < 0) CurrentToughness = 0;
            if (!wasBreak && CurrentToughness == 0)
            {
                AdvanceActionPercent(-0.25f);

                if (attackElement == Element.Imaginary)
                {
                    AdvanceActionPercent(-0.3f * (1 + attacker.BreakEffect));
                }
                if (attackElement == Element.Quantum)
                {
                    AdvanceActionPercent(-0.2f * (1 + attacker.BreakEffect));
                }
            }
        }
        // https://www.prydwen.gg/star-rail/guides/damage-formula/
        var defMultiplier = 1 - (Def / (Def + 200 + 10 * attacker.Level));
        var resMultiplier = 1 - (_res[attackElement] - attacker._resPen[attackElement]);
        var dmgTakenMultiplier = isDotDmg ? _dmgTakenMultiplier[attackElement] : _dmgTakenMultiplier[attackElement];
        var toughnessMultiplier = CurrentToughness == 0 ? 1f : 0.9f;
        baseDamage *= baseDamage * defMultiplier * resMultiplier * dmgTakenMultiplier * toughnessMultiplier;

        // https://honkai-star-rail.fandom.com/wiki/Toughness
        var breakDmgMultiplier = attackElement switch
        {
            Element.Physical => 2.0,
            Element.Fire => 2.0,
            Element.Ice => 1.0,
            Element.Lightning => 1.0,
            Element.Wind => 1.5,
            Element.Quantum => 0.5,
            Element.Imaginary => 0.5,
            _ => throw new InvalidOperationException()
        };
        var isBreak = CurrentToughness == 0;
        var something = attacker.BaseBreakDamage * breakDmgMultiplier;
        //var vulnerabilityMultiplier = 1 + elementalVulnerability + allTypeVulnerability;
        //throw new NotImplementedException();
    }

    public void RunAction(Skill skill, IEnumerable<CharacterInBattle> targets)
    {
        skill.Use(this, targets);
        ActionValue = BaseActionValue;
    }

    float BaseBreakDamage => Level switch // https://honkai-star-rail.fandom.com/wiki/Toughness#Base_Break_DMG
    {
        1 => 54.0000f,
        2 => 58.0000f,
        3 => 62.0000f,
        4 => 67.5264f,
        5 => 70.5094f,
        6 => 73.5228f,
        7 => 76.5660f,
        8 => 79.6385f,
        9 => 82.7395f,
        10 => 85.8684f,
        11 => 91.4944f,
        12 => 97.0680f,
        13 => 102.5892f,
        14 => 108.0579f,
        15 => 113.4743f,
        16 => 118.8383f,
        17 => 124.1499f,
        18 => 129.4091f,
        19 => 134.6159f,
        20 => 139.7703f,
        21 => 149.3323f,
        22 => 158.8011f,
        23 => 168.1768f,
        24 => 177.4594f,
        25 => 186.6489f,
        26 => 195.7452f,
        27 => 204.7484f,
        28 => 213.6585f,
        29 => 222.4754f,
        30 => 231.1992f,
        31 => 246.4276f,
        32 => 261.1810f,
        33 => 275.4733f,
        34 => 289.3179f,
        35 => 302.7275f,
        36 => 315.7144f,
        37 => 328.2905f,
        38 => 340.4671f,
        39 => 352.2554f,
        40 => 363.6658f,
        41 => 408.1240f,
        42 => 451.7883f,
        43 => 494.6798f,
        44 => 536.8188f,
        45 => 578.2249f,
        46 => 618.9172f,
        47 => 658.9138f,
        48 => 698.2325f,
        49 => 736.8905f,
        50 => 774.9041f,
        51 => 871.0599f,
        52 => 964.8705f,
        53 => 1056.4206f,
        54 => 1145.7910f,
        55 => 1233.0585f,
        56 => 1318.2965f,
        57 => 1401.5750f,
        58 => 1482.9608f,
        59 => 1562.5178f,
        60 => 1640.3068f,
        61 => 1752.3215f,
        62 => 1861.9011f,
        63 => 1969.1242f,
        64 => 2074.0659f,
        65 => 2176.7983f,
        66 => 2277.3904f,
        67 => 2375.9085f,
        68 => 2472.4160f,
        69 => 2566.9739f,
        70 => 2659.6406f,
        71 => 2780.3044f,
        72 => 2898.6022f,
        73 => 3014.6029f,
        74 => 3128.3729f,
        75 => 3239.9758f,
        76 => 3349.4730f,
        77 => 3456.9236f,
        78 => 3562.3843f,
        79 => 3665.9099f,
        80 => 3767.5533f,
        _ => throw new InvalidOperationException("Unsupported Level.")
    };

    public CharacterInBattle? OnLeft { get; internal set; }
    public CharacterInBattle? OnRight { get; internal set; }
    public Battle Battle { get; }
}