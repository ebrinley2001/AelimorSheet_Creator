using AelimorSheetCreator.BC.BuisinessComponents;
using AelimorSheetCreator.Data;
using AelimorSheetCreator.Models;

namespace AelimorSheetCreator.BC
{
    public class AttributeBc : BaseEfBc<Attribute>, IAttributeBc
    {
        public AttributeBc(IAttributeRepository repo) : base(repo)
        {
        }
    }
}
