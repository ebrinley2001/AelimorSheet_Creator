using AelimorSheetCreator.Models;

namespace AelimorSheetCreator.Data.Repository
{
    public class RacialSkillRepository : BaseEfRepository<RacialSkill, AelimorContext>, IRacialSkillRepository
    {
        public RacialSkillRepository(AelimorContext context) : base(context)
        {
        }
    }
}
