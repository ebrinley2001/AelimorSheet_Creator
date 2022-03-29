using AelimorSheetCreator.Models;

namespace AelimorSheetCreator.Data.Repository
{
    public class SkillRepository : BaseEfRepository<Skill>, ISkillRepository
    {
        public SkillRepository(AelimorContext context) : base(context)
        {
        }
    }
}
