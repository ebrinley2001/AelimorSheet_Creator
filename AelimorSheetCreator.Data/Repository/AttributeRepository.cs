using AelimorSheetCreator.Models;

namespace AelimorSheetCreator.Data.Repository
{
    public class AttributeRepository : BaseEfRepository<Attribute, AelimorContext>, IAttributeRepository
    {
        public AttributeRepository(AelimorContext context) : base(context)
        {
        }
    }
}
