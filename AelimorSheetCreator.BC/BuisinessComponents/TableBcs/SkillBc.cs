using AelimorSheetCreator.Data;
using AelimorSheetCreator.Models;
using EthanFramework.BC.BuisinessComponents;

namespace AelimorSheetCreator.BC
{
    public class SkillBc : BaseEfBc<Skill, ISkillRepository>, ISkillBc
    {
        public SkillBc(ISkillRepository repo) : base(repo)
        {
        }
    }
}
