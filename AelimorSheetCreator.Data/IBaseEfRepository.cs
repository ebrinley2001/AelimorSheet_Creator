using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace AelimorSheetCreator.Data
{
    public interface IBaseEfRepository<TModel, TDbContext> 
        where TModel : class 
        where TDbContext : DbContext
    {
        public Task<List<TModel>> GetCollectionAsync();
        public Task<TModel> GetByIdAsync(int id);
        public Task<int> DeleteByIdAsync(TModel entity);
        public Task<int> CreateAsync(TModel entity);
        public Task<int> UpdateAsync(TModel entity);
    }
}
