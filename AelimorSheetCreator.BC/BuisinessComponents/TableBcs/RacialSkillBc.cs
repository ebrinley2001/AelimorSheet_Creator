using AelimorSheetCreator.BC.BuisinessComponents;
using AelimorSheetCreator.Data;
using AelimorSheetCreator.Data.Repository;
using AelimorSheetCreator.Models;

namespace AelimorSheetCreator.BC
{
    public class RacialSkillBc : BaseEfBc<RacialSkill, AelimorContext>, IRacialSkillBc
    {
        public RacialSkillBc(IRacialSkillRepository repo) : base(repo)
        {
        }
    }
}
