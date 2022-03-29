using AelimorSheetCreator.Models;

namespace AelimorSheetCreator.Data.Repository
{
    public class AttributeRepository : BaseEfRepository<Attribute>, IAttributeRepository
    {
        public AttributeRepository(AelimorContext context) : base(context)
        {
        }
    }
}
