using AelimorSheetCreator.Models;

namespace AelimorSheetCreator.Data.Repository
{
    public class RacialSkillRepository : BaseEfRepository<RacialSkill>, IRacialSkillRepository
    {
        public RacialSkillRepository(AelimorContext context) : base(context)
        {
        }
    }
}
