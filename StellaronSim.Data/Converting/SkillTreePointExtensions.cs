using System.Diagnostics.Contracts;
using StellaronSim.Data.Models;
using StellaronSim.Data.Models.Generated;

namespace StellaronSim.Data.Converting;

internal static class SkillTreePointExtensions
{
    [Pure]
    internal static SkillTree ToSkillTree(this SkillTreePoint[] skillTreePoints)
    {
        return new SkillTree
        {
            Nodes = skillTreePoints.ToSkillTreeNodes()
        };
    }

    [Pure]
    private static IReadOnlyList<SkillTreeNode> ToSkillTreeNodes(this IEnumerable<SkillTreePoint> skillTreePoints)
    {
        IList<SkillTreeNode> nodes = new List<SkillTreeNode>();

        foreach (var skillTreePoint in skillTreePoints)
        {
            var type = skillTreePoint.Type;
            if (type == 1)
            {
                var skillTreeNode = skillTreePoint.EmbedBonusSkill.ToSkillTreeNode();
                skillTreeNode.ChildNodes = skillTreePoint.Children.ToSkillTreeNodes();
                nodes.Add(skillTreeNode);
            }
            else
            {
                var skillTreeNode = skillTreePoint.EmbedBuff.ToSkillTreeNode();
                skillTreeNode.ChildNodes = skillTreePoint.Children.ToSkillTreeNodes();
                nodes.Add(skillTreeNode);
            }
        }

        return nodes.AsReadOnly();
    }
}