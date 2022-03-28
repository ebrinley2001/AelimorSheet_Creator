using AelimorSheetCreator.BC.BuisinessComponents;
using AelimorSheetCreator.Data;
using AelimorSheetCreator.Data.Repository;
using AelimorSheetCreator.Models;

namespace AelimorSheetCreator.BC
{
    public class ClassBc : BaseEfBc<Class>, IClassBc
    {
        public ClassBc(IClassRepository repo) : base(repo)
        {
        }
    }
}
