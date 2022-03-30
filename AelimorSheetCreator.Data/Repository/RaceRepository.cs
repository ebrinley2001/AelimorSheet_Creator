using AelimorSheetCreator.Models;

namespace AelimorSheetCreator.Data.Repository
{
    public class RaceRepository : BaseEfRepository<Race, AelimorContext>, IRaceRepository
    {
        public RaceRepository(AelimorContext context) : base(context)
        {
        }
    }
}
