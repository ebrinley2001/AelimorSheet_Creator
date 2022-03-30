using AelimorSheetCreator.BC.BuisinessComponents;
using AelimorSheetCreator.Data;
using AelimorSheetCreator.Data.Repository;
using AelimorSheetCreator.Models;

namespace AelimorSheetCreator.BC
{
    public class AttributeBc : BaseEfBc<Attribute, AelimorContext>, IAttributeBc
    {
        public AttributeBc(IAttributeRepository repo) : base(repo)
        {
        }
    }
}
