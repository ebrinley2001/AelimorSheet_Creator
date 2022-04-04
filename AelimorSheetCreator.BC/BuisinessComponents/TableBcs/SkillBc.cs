using AelimorSheetCreator.BC.BuisinessComponents;
using AelimorSheetCreator.Data;
using AelimorSheetCreator.Data.Repository;
using AelimorSheetCreator.Models;

namespace AelimorSheetCreator.BC
{
    public class SkillBc : BaseEfBc<Skill, AelimorContext>, ISkillBc
    {
        public SkillBc(ISkillRepository repo) : base(repo)
        {
        }
    }
}
