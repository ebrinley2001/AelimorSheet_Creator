using AelimorSheetCreator.BC.BuisinessComponents;
using AelimorSheetCreator.Data;
using AelimorSheetCreator.Models;

namespace AelimorSheetCreator.BC
{
    public class RaceBc : BaseEfBc<Race>, IRaceBc
    {
        public RaceBc(IRaceRepository repo) : base(repo)
        {
        }
    }
}
