using AelimorSheetCreator.BC.BuisinessComponents;
using AelimorSheetCreator.Data;
using AelimorSheetCreator.Models;

namespace AelimorSheetCreator.BC
{
    public class RacialSkillBc : BaseEfBc<RacialSkill>, IRacialSkillBc
    {
        public RacialSkillBc(IRacialSkillRepository repo) : base(repo)
        {
        }
    }
}
