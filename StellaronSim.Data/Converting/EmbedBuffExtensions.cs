using System.Data;
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
            LevelRequirement = Convert.ToInt32(skillElement.LevelReq),
            PromotionRequirement = Convert.ToInt32(skillElement.PromotionReq),
            StatusList = skillElement.StatusList.ToDictionary(x=> x.Key.ToBuffEffect(), x=>x.Value)
        };
    }
}