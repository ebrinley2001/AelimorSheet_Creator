using AelimorSheetCreator.BC.BuisinessComponents;
using AelimorSheetCreator.Data;
using AelimorSheetCreator.Data.Repository;
using AelimorSheetCreator.Models;

namespace AelimorSheetCreator.BC
{
    public class RaceBc : BaseEfBc<Race, AelimorContext>, IRaceBc
    {
        public RaceBc(IRaceRepository repo) : base(repo)
        {
        }
    }
}
