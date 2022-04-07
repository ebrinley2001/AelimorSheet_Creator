using AelimorSheetCreator.Data;
using AelimorSheetCreator.Models;
using EthanFramework.BC.BuisinessComponents;

namespace AelimorSheetCreator.BC
{
    public class AttributeBc : BaseEfBc<Attribute, IAttributeRepository>, IAttributeBc
    {
        public AttributeBc(IAttributeRepository repo) : base(repo)
        {
        }
    }
}
