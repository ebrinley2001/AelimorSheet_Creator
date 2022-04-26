using AelimorSheetCreator.Models;
using EthanFramework.Data.Repository;

namespace AelimorSheetCreator.Data.Repository
{
    public class AttributeRepository : BaseEfRepository<Attribute, AelimorContext>, IAttributeRepository
    {
        public AttributeRepository(AelimorContext context) : base(context)
        {
        }
    }
}
