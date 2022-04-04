using AelimorSheetCreator.BC.BuisinessComponents;
using AelimorSheetCreator.Data;
using AelimorSheetCreator.Data.Repository;
using AelimorSheetCreator.Models;

namespace AelimorSheetCreator.BC
{
    public class LevelBc : BaseEfBc<Level, AelimorContext>, ILevelBc
    {
        public LevelBc(ILevelRepository repo) : base(repo)
        {
        }
    }
}
