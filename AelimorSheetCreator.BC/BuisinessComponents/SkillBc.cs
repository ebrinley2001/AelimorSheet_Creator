using AelimorSheetCreator.BC.BuisinessComponents;
using AelimorSheetCreator.Data;
using AelimorSheetCreator.Models;

namespace AelimorSheetCreator.BC
{
    public class SkillBc : BaseEfBc<Skill>, ISkillBc
    {
        public SkillBc(ISkillRepository repo) : base(repo)
        {
        }
    }
}
