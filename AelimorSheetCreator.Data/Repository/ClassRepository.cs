using AelimorSheetCreator.Models;

namespace AelimorSheetCreator.Data.Repository
{
    public class ClassRepository : BaseEfRepository<Class, AelimorContext>, IClassRepository
    {
        public ClassRepository(AelimorContext context) : base(context)
        {
        }
    }
}
