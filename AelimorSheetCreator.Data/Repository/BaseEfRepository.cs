using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace AelimorSheetCreator.Data.Repository
{
    public abstract class BaseEfRepository<TModel> where TModel : class
    {
        private readonly AelimorContext _context;

        public BaseEfRepository(AelimorContext context)
        {
            _context = context;
        }

        public Task<List<TModel>> GetCollectionAsync()
        {
            return _context.Set<TModel>().ToListAsync();
        }

        public Task<TModel> GetByIdAsync(int id)
        {
            return _context.Set<TModel>().FindAsync(id).AsTask();
        }

        public async Task DeleteByIdAsync(int id)
        {
            var entity = await GetByIdAsync(id);
            _context.Set<TModel>().Remove(entity);
            await _context.SaveChangesAsync();
        }

        public Task CreateAsync(TModel entity)
        {
              _context.Set<TModel>().AddAsync(entity);
             return _context.SaveChangesAsync();
        }

        public Task UpdateAsync(TModel entity)
        {
            _context.Set<TModel>().Update(entity);
            return _context.SaveChangesAsync();
        }
    }
}
