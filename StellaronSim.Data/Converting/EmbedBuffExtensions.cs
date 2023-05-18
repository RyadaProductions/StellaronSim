using System.Diagnostics.Contracts;
using StellaronSim.Data.Models;
using StellaronSim.Data.Models.Generated;

namespace StellaronSim.Data.Converting;

internal static class EmbedBuffExtensions
{
    [Pure]
    internal static SkillTreeNode ToSkillTreeNode(this EmbedBuff skillElement)
    {
        return new SkillTreeNode
        {
            Name = skillElement.Name.ToString(),
            Type = SkillTreeNodeType.Buff,
            LevelRequirement = skillElement.LevelReq.ToInt(),
            PromotionRequirement = skillElement.PromotionReq.ToInt(),
            StatusList = skillElement.StatusList.ToDictionary(x=> x.Key.ToBuffEffect(), x=>x.Value)
        };
    }
}