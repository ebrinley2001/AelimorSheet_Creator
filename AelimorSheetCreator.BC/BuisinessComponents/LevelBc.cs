using AelimorSheetCreator.BC.BuisinessComponents;
using AelimorSheetCreator.Data;
using AelimorSheetCreator.Models;

namespace AelimorSheetCreator.BC
{
    public class LevelBc : BaseEfBc<Level>, ILevelBc
    {
        public LevelBc(ILevelRepository repo) : base(repo)
        {
        }
    }
}
