using AelimorSheetCreator.Models;
using EthanFramework.BC;
using System.Threading.Tasks;

namespace AelimorSheetCreator.BC
{
    public interface ILevelBc : IBaseEfBc<Level>
    {
        public Task<Level> GetLevelByXp(int Xp);
    }
}
