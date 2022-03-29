using System.Collections.Generic;
using System.Threading.Tasks;

namespace AelimorSheetCreator.Data
{
    public interface IBaseEfRepository<TModel> where TModel : class
    {
        public Task<List<TModel>> GetCollectionAsync();
        public Task<TModel> GetByIdAsync(int id);
        public Task DeleteByIdAsync(int id);
        public Task CreateAsync(TModel entity);
        public Task UpdateAsync(TModel entity);
    }
}
