using AelimorSheetCreator.Data;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace AelimorSheetCreator.BC.BuisinessComponents
{
    public abstract class BaseEfBc<TModel, TDbContext>
        where TModel : class
        where TDbContext : DbContext
    {
        private readonly IBaseEfRepository<TModel, TDbContext> _repo;
        public BaseEfBc(IBaseEfRepository<TModel, TDbContext> repo)
        {
            _repo = repo;
        }

        public Task<List<TModel>> GetCollectionAsync()
        {
            return _repo.GetCollectionAsync();
        }

        public Task<TModel> GetByIdAsync(int id)
        {
            return _repo.GetByIdAsync(id);
        }
        public Task<int> DeleteByIdAsync(TModel entity)
        {
            return _repo.DeleteByIdAsync(entity);
        }

        public Task<int> CreateAsync(TModel entity)
        {
            return _repo.CreateAsync(entity);
        }

        public Task<int> UpdateAsync(TModel entity)
        {
            return _repo.UpdateAsync(entity);
        }
    }
}
