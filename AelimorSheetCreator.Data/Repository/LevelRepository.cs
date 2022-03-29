using AelimorSheetCreator.Models;

namespace AelimorSheetCreator.Data.Repository
{
    public class LevelRepository : BaseEfRepository<Level>, ILevelRepository
    {
        public LevelRepository(AelimorContext context) : base(context)
        {
        }
    }
}
