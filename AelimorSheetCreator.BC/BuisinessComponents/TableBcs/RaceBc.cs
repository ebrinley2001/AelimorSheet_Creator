using AelimorSheetCreator.Data;
using AelimorSheetCreator.Models;
using EthanFramework.BC.BuisinessComponents;

namespace AelimorSheetCreator.BC
{
    public class RaceBc : BaseEfBc<Race, IRaceRepository>, IRaceBc
    {
        public RaceBc(IRaceRepository repo) : base(repo)
        {
        }
    }
}
