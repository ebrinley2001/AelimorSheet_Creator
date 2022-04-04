using AelimorSheetCreator.BC.BuisinessComponents;
using AelimorSheetCreator.Data;
using AelimorSheetCreator.Data.Repository;
using AelimorSheetCreator.Models;

namespace AelimorSheetCreator.BC
{
    public class AttributeSkillBc : BaseEfBc<AttributeSkill, AelimorContext>, IAttributeSkillBc
    {
        public AttributeSkillBc(IAttributeSkillRepository repo) : base(repo)
        {
        }
    }
}
