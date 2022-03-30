using AelimorSheetCreator.Models;

namespace AelimorSheetCreator.Data.Repository
{
    public class LevelRepository : BaseEfRepository<Level, AelimorContext>, ILevelRepository
    {
        public LevelRepository(AelimorContext context) : base(context)
        {
        }
    }
}
