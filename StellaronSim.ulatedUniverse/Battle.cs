using OneOf;

namespace StellaronSim.ulatedUniverse;

public class Battle
{
    public Battle(IReadOnlyList<Character> playerCharacter, IReadOnlyList<Character> enemiesCharacter)
    {
        PlayerCharacter = playerCharacter.Select(character => new CharacterInBattle(this, character)).ToArray();
        EnemiesCharacter = enemiesCharacter.Select(enemy => new CharacterInBattle(this, enemy)).ToArray();
        var previous = null as CharacterInBattle;
        foreach (var current in PlayerCharacter)
        {
            if (previous != null)
            {
                current.OnLeft = previous;
                previous.OnRight = current;
            }
        }
        previous = null;
        foreach (var current in EnemiesCharacter)
        {
            if (previous != null)
            {
                current.OnLeft = previous;
                previous.OnRight = current;
            }
        }
    }

    public OneOf<FollowUpAttack, CharacterInBattle> CurrentAction { get; private set; }

    public bool MoveNext()
    {
        if (_followUps.Count > 0)
        {
            var followUp = _followUps.Dequeue();
            CurrentAction = OneOf<FollowUpAttack, CharacterInBattle>.FromT0(followUp);
            return true;
        }
        if (CurrentAction.IsT1 && CurrentAction.AsT1.ActionValue == 0)
        {
            throw new InvalidOperationException("The character have to take an action.");
        }
        var currentChar = Everybody.MinBy(s => s.ActionValue)!;
        var advancement = currentChar.ActionValue;
        foreach (var character in Everybody)
        {
            character.AdvanceAction(advancement);
        }

        CurrentAction = OneOf<FollowUpAttack, CharacterInBattle>.FromT1(currentChar);
        return true; //Will return false when game ended.
    }

    public IReadOnlyList<CharacterInBattle> PlayerCharacter { get; }
    public IReadOnlyList<CharacterInBattle> EnemiesCharacter { get; }

    IEnumerable<CharacterInBattle> Everybody => PlayerCharacter.Concat(EnemiesCharacter);

    readonly Queue<FollowUpAttack> _followUps = new();
    public IEnumerable<OneOf<FollowUpAttack, CharacterInBattle>> ComputeActionsOrder() =>
        _followUps
            .Select(OneOf<FollowUpAttack, CharacterInBattle>.FromT0)
            .Concat(Everybody
                .OrderBy(s => s.ActionValue)
                .Select(OneOf<FollowUpAttack, CharacterInBattle>.FromT1)
        );
}
