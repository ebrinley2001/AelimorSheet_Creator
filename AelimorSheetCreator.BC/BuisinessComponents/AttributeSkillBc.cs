using AelimorSheetCreator.BC.BuisinessComponents;
using AelimorSheetCreator.Data;
using AelimorSheetCreator.Models;

namespace AelimorSheetCreator.BC
{
    public class AttributeSkillBc : BaseEfBc<AttributeSkill>, IAttributeSkillBc
    {
        public AttributeSkillBc(IAttributeSkillRepository repo) : base(repo)
        {
        }
    }
}
