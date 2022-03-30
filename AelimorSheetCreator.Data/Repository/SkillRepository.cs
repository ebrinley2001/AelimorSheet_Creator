using AelimorSheetCreator.Models;

namespace AelimorSheetCreator.Data.Repository
{
    public class SkillRepository : BaseEfRepository<Skill, AelimorContext>, ISkillRepository
    {
        public SkillRepository(AelimorContext context) : base(context)
        {
        }
    }
}
