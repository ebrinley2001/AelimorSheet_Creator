using AelimorSheetCreator.Models;

namespace AelimorSheetCreator.Data.Repository
{
    public class ClassRepository : BaseEfRepository<Class>, IClassRepository
    {
        public ClassRepository(AelimorContext context) : base(context)
        {
        }
    }
}
