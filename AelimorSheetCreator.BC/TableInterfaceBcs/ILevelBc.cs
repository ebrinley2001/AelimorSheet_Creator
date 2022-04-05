using AelimorSheetCreator.Data.Repository;
using AelimorSheetCreator.Models;
using System.Threading.Tasks;

namespace AelimorSheetCreator.BC
{
    public interface ILevelBc : IBaseEfBc<Level, AelimorContext>
    {
        public Task<Level> GetLevelByXp(int Xp);
    }
}
