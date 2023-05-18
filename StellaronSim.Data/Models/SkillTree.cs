namespace StellaronSim.Data.Models;

public class SkillTree
{
    public IReadOnlyList<SkillTreeNode> Nodes { get; set; }
}

public class SkillTreeNode
{
    public SkillTreeNodeType Type { get; set; }
    
    public IReadOnlyList<SkillTreeNode> ChildNodes { get; set; }
    
    public string Name { get; set; }
    
    public string Description { get; set; }
    
    public int LevelRequirement { get; set; }
    
    public int PromotionRequirement { get; set; }
    
    public IReadOnlyDictionary<int, double[]> ParametersByLevel { get; set; }
    
    public IReadOnlyDictionary<BuffEffect, double> StatusList { get; set; }

    public int UltimateCost { get; set; }
    
    public SkillType SkillType { get; set; }
    
    public AbilityType AbilityType { get; set; }
}