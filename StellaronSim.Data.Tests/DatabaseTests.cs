namespace StellaronSim.Data.Tests;

public class Tests
{
    private string _json = "";

    [SetUp]
    public async Task Setup()
    {
        _json = await File.ReadAllTextAsync("main.json");
    }

    [Test]
    public void CanCreateDatabase()
    {
        var database = new Database(_json);
        Assert.That(database, Is.Not.Null);
    }

    [TestCase("seele")]
    [TestCase("kafka")]
    public void CharacterDataExists(string characterName)
    {
        var database = new Database(_json);
        Assert.That(database.GetCharacter(characterName), Is.Not.Null);
    }

    [TestCase("seele", 120)]
    [TestCase("danheng", 100)]
    [TestCase("playergirl2", 120)]
    public void CharacterContainsUltimateCostValue(string characterName, int ultimateCost)
    {
        var database = new Database(_json);
        var characterData = database.GetCharacter(characterName);
        Assert.That(characterData.UltimateCost, Is.EqualTo(ultimateCost));
    }

    [Test]
    public void InvalidCharacterNameThrowsError()
    {
        var database = new Database(_json);
        Assert.Throws<ArgumentException>(() => database.GetCharacter(string.Empty));
    }

    [TestCase(
        "himeko", 51, 4, 530.24400000000003, 305.90999999999997, 
        734.18399999999997, 96, 0.5, 0.050000000000000003, 75)]
    [TestCase(
        "seele", 31, 2, 291.85199999999998, 165.82499999999999, 
        424.512, 115, 0.5, 0.050000000000000003, 75)]
    public void CorrectLevelDataForCharacterIsGiven(
        string characterName, 
        int level,
        long expectedPromotion,
        double expectedAttack,
        double expectedDefence,
        double expectedHealth,
        double expectedSpeed,
        double expectedCritDmg,
        double expectedCritRate,
        long expectedAggro)
    {
        var database = new Database(_json);
        var stats = database.GetStatsAtLevel(characterName, level);
        Assert.Multiple(() =>
        {
            Assert.That(stats.Promotion, Is.EqualTo(expectedPromotion));
            Assert.That(stats.Attack, Is.EqualTo(expectedAttack));
            Assert.That(stats.Defence, Is.EqualTo(expectedDefence));
            Assert.That(stats.Health, Is.EqualTo(expectedHealth));
            Assert.That(stats.Speed, Is.EqualTo(expectedSpeed));
            Assert.That(stats.CritDamage, Is.EqualTo(expectedCritDmg));
            Assert.That(stats.CritRate, Is.EqualTo(expectedCritRate));
            Assert.That(stats.Aggro, Is.EqualTo(expectedAggro));
        });
    }

    [TestCase(-100)]
    [TestCase(0)]
    [TestCase(81)]
    public void GetStatsAtLevelThrowsOnInvalidLevel(int level)
    {
        var database = new Database(_json);
        var exception = Assert.Throws<ArgumentOutOfRangeException>(() => database.GetStatsAtLevel("hook", level));
        Assert.That(exception.ParamName, Is.EqualTo("level"));
    }
}