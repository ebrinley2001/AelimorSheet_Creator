using AelimorSheetCreator.Data.Repository;
using AelimorSheetCreator.Models;

namespace AelimorSheetCreator.Data
{
    public interface IAttributeRepository : IBaseEfRepository<Attribute, AelimorContext>
    {
    }
}
