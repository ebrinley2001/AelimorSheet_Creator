using AelimorSheetCreator.Data.Repository;
using AelimorSheetCreator.Models;

namespace AelimorSheetCreator.Data
{
    public interface IClassRepository : IBaseEfRepository<Class, AelimorContext>
    {
    }
}
