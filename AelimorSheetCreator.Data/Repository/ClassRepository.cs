using AelimorSheetCreator.Models;
using EthanFramework.Data.Repository;

namespace AelimorSheetCreator.Data.Repository
{
    public class ClassRepository : BaseEfRepository<Class, AelimorContext>, IClassRepository
    {
        public ClassRepository(AelimorContext context) : base(context)
        {
        }
    }
}
