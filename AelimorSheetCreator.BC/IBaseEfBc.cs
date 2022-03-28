using System.Collections.Generic;
using System.Threading.Tasks;

namespace AelimorSheetCreator.BC
{
    public interface IBaseEfBc<TModel> where TModel : class
    {
        public Task<List<TModel>> GetCollectionAsync();
        public Task<TModel> GetByIdAsync(int id);
    }
}
