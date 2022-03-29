using AelimorSheetCreator.Models;

namespace AelimorSheetCreator.Data.Repository
{
    public class AttributeSkillRepository : BaseEfRepository<AttributeSkill>, IAttributeSkillRepository
    {
        public AttributeSkillRepository(AelimorContext context) : base(context)
        {
        }
    }
}
