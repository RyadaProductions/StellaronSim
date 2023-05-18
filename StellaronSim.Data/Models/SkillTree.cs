namespace StellaronSim.Data.Models;

public class SkillTree
{
    public IReadOnlyList<SkillTreeNode> Nodes { get; set; }
}

public class SkillTreeNode
{
    public SkillTreeNodeType Type { get; init; }
    
    public IReadOnlyList<SkillTreeNode> ChildNodes { get; internal set; }
    
    public string Name { get; init; }
    
    public string Description { get; init; }
    
    public int LevelRequirement { get; init; }
    
    public int PromotionRequirement { get; init; }
    
    public IReadOnlyDictionary<int, double[]> ParametersByLevel { get; init; }
    
    public IReadOnlyDictionary<BuffEffect, double> StatusList { get; init; }

    public int UltimateCost { get; init; }
}