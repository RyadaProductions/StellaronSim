using FluentAssertions;
using NUnit.Framework;
using StellaronSim.ulatedUniverse.Abilities;

namespace StellaronSim.ulatedUniverse.Tests;

public class SpeedTests
{
    [Test]
    public static void simple_speed_comparison()
    {
        var seeleChar = new Character(name: "Seele", level: 60, maxHP: 2166, currentHP: 2166, maxEnergy: 120, currentEnergy: 0, speed: 115, breakEffect: 0, toughness: null, weaknesses: null, eliteOrBoss: false, skills: Array.Empty<Skill>());
        var antibaryonChar = new Character(name: "Antibaryon", level: 52, maxHP: 1235, currentHP: 1235, maxEnergy: 0, currentEnergy: 0, speed: 83, breakEffect: 0, toughness: 30, weaknesses: new[] { Element.Physical, Element.Quantum }, eliteOrBoss: false, skills: Array.Empty<Skill>());
        var battle = new Battle(new[]
        {
            seeleChar
        },
        new[]
        {
            antibaryonChar
        });
        var seele = battle.PlayerCharacter.Single();
        var antibaryon = battle.EnemiesCharacter.Single();
        battle.MoveNext();
        seele.BaseActionValue.Should().BeLessThan(antibaryon.BaseActionValue);
    }

    [Test]
    public static void speed_lead_to_correct_action_order()
    {
        var seele = new Character(name: "Seele", level: 60, maxHP: 2166, currentHP: 2166, maxEnergy: 120, currentEnergy: 0, speed: 115, breakEffect: 0, toughness: null, weaknesses: null, eliteOrBoss: false, skills: Array.Empty<Skill>());
        var mc = new Character(name: "MC", level: 60, maxHP: 1631, currentHP: 1631, maxEnergy: 120, currentEnergy: 0, speed: 95 + 4, breakEffect: 0, toughness: null, weaknesses: null, eliteOrBoss: false, skills: Array.Empty<Skill>());
        var natasha = new Character(name: "Natasha", level: 60, maxHP: 5024, currentHP: 5024, maxEnergy: 90, currentEnergy: 0, speed: 98, breakEffect: 0, toughness: null, weaknesses: null, eliteOrBoss: false, skills: Array.Empty<Skill>());
        var himeko = new Character(name: "Himeko", level: 60, maxHP: 2428, currentHP: 2428, maxEnergy: 120, currentEnergy: 0, speed: 96 + 1, breakEffect: 0, toughness: null, weaknesses: null, eliteOrBoss: false, skills: Array.Empty<Skill>());
        var imaginaryWeaverA = new Character(name: "Imaginary Weaver A", level: 52, maxHP: 3912, currentHP: 3912, maxEnergy: 0, currentEnergy: 0, speed: 120, breakEffect: 0, toughness: 120, weaknesses: new[] { Element.Physical, Element.Lightning, Element.Quantum }, eliteOrBoss: false, skills: Array.Empty<Skill>());
        var imaginaryWeaverB = new Character(name: "Imaginary Weaver B", level: 52, maxHP: 3912, currentHP: 3912, maxEnergy: 0, currentEnergy: 0, speed: 120, breakEffect: 0, toughness: 120, weaknesses: new[] { Element.Physical, Element.Lightning, Element.Quantum }, eliteOrBoss: false, skills: Array.Empty<Skill>());
        var everwinterShadeWalker = new Character(name: "EverWinter Shade Walker", level: 52, maxHP: 3089, currentHP: 3089, maxEnergy: 0, currentEnergy: 0, speed: 100, breakEffect: 0, toughness: 100, weaknesses: new[] { Element.Physical, Element.Fire, Element.Quantum }, eliteOrBoss: false, skills: Array.Empty<Skill>());
        var battle = new Battle(new[]
        {
            mc, seele, natasha, himeko
        }, new[]
        {
            imaginaryWeaverA, imaginaryWeaverB, everwinterShadeWalker
        });

        var actions = battle.ComputeActionsOrder().ToArray();
        actions.Should().AllSatisfy(s => s.IsT1.Should().BeTrue());
        actions.Select(s => s.AsT1.Name).Should().ContainInOrder(new[]
        {
            imaginaryWeaverA.Name,
            imaginaryWeaverB.Name,
            seele.Name,
            everwinterShadeWalker.Name,
            mc.Name,
            natasha.Name,
            himeko.Name
        });
    }

    [Test]
    public static void break_enemy_slow_it()
    {
        var seeleChar = new Character(name: "Seele", level: 60, maxHP: 2166, currentHP: 2166, maxEnergy: 120, currentEnergy: 0, speed: 115, breakEffect: 0.093f, toughness: null, weaknesses: null, eliteOrBoss: false, skills: new[]
        {
            new DamageSingleEnemyAbility(Element.Quantum, 0, 30 )
        });
        var antibaryonChar = new Character(name: "Antibaryon", level: 52, maxHP: 1235, currentHP: 1235, maxEnergy: 0, currentEnergy: 0, speed: 83, breakEffect: 0, toughness: 30, weaknesses: new[] { Element.Physical, Element.Quantum }, eliteOrBoss: false, skills: Array.Empty<Skill>());
        var anotherUnit = new Character(name: "Another unit", level: 52, maxHP: 1235, currentHP: 1235, maxEnergy: 0, currentEnergy: 0, speed: 100, breakEffect: 0, toughness: 30, weaknesses: new[] { Element.Physical, Element.Quantum }, eliteOrBoss: false, skills: Array.Empty<Skill>());
        var battle = new Battle(new[]
        {
            seeleChar
        },
        new[]
        {
            antibaryonChar,
            anotherUnit
        });
        var seele = battle.PlayerCharacter.Single();
        var antibaryon = battle.EnemiesCharacter.First();
        battle.MoveNext();
        seele.ActionValue.Should().Be(0);
        antibaryon.DisplayActionValue.Should().Be(34);
        var seeleSkill = seele.Skills.Single();
        seele.RunAction(seeleSkill, new[] { antibaryon });
        battle.MoveNext();
        antibaryon.DisplayActionValue.Should().Be(77);
    }

    [Test]
    public static void replay_battle()
    {
        var seele = new Character(name: "Seele", level: 60, maxHP: 2166, currentHP: 2166, maxEnergy: 120, currentEnergy: 0, speed: 115, breakEffect: 0, toughness: null, weaknesses: null, eliteOrBoss: false, skills: Array.Empty<Skill>());
        var mc = new Character(name: "MC", level: 60, maxHP: 1631, currentHP: 1631, maxEnergy: 120, currentEnergy: 0, speed: 95 + 4, breakEffect: 0, toughness: null, weaknesses: null, eliteOrBoss: false, skills: Array.Empty<Skill>());
        var natasha = new Character(name: "Natasha", level: 60, maxHP: 5024, currentHP: 5024, maxEnergy: 90, currentEnergy: 0, speed: 98, breakEffect: 0, toughness: null, weaknesses: null, eliteOrBoss: false, skills: Array.Empty<Skill>());
        var himeko = new Character(name: "Himeko", level: 60, maxHP: 2428, currentHP: 2428, maxEnergy: 120, currentEnergy: 0, speed: 96 + 1, breakEffect: 0, toughness: null, weaknesses: null, eliteOrBoss: false, skills: Array.Empty<Skill>());
        var imaginaryWeaverA = new Character(name: "Imaginary Weaver A", level: 52, maxHP: 3912, currentHP: 3912, maxEnergy: 0, currentEnergy: 0, speed: 120, breakEffect: 0, toughness: 120, weaknesses: new[] { Element.Physical, Element.Lightning, Element.Quantum }, eliteOrBoss: false, skills: Array.Empty<Skill>());
        var imagineyWeaverB = new Character(name: "Imaginary Weaver B", level: 52, maxHP: 3912, currentHP: 3912, maxEnergy: 0, currentEnergy: 0, speed: 120, breakEffect: 0, toughness: 120, weaknesses: new[] { Element.Physical, Element.Lightning, Element.Quantum }, eliteOrBoss: false, skills: Array.Empty<Skill>());
        var everwinterShadeWalker = new Character(name: "EverWinter Shade Walker", level: 52, maxHP: 3089, currentHP: 3089, maxEnergy: 0, currentEnergy: 0, speed: 100, breakEffect: 0, toughness: 100, weaknesses: new[] { Element.Physical, Element.Fire, Element.Quantum }, eliteOrBoss: false, skills: Array.Empty<Skill>());
        var battle = new Battle(new[]
        {
            mc, seele, natasha, himeko
        }, new[]
        {
            imaginaryWeaverA, imagineyWeaverB, everwinterShadeWalker
        });

        //reverbeting carol x2 sur himeko
    }
}