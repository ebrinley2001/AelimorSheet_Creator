using AelimorSheetCreator.Data.Repository;
using AelimorSheetCreator.Models;

namespace AelimorSheetCreator.Data
{
    public interface ISkillRepository : IBaseEfRepository<Skill, AelimorContext>
    {
    }
}
