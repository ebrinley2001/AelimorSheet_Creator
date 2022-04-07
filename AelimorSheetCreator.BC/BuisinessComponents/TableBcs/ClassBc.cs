using AelimorSheetCreator.Data;
using AelimorSheetCreator.Models;
using EthanFramework.BC.BuisinessComponents;

namespace AelimorSheetCreator.BC
{
    public class ClassBc : BaseEfBc<Class, IClassRepository>, IClassBc
    {
        public ClassBc(IClassRepository repo) : base(repo)
        {
        }
    }
}
