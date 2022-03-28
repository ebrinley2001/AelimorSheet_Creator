using AelimorSheetCreator.Data;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace AelimorSheetCreator.BC.BuisinessComponents
{
    public abstract class BaseEfBc<TModel> where TModel : class
    {
        private readonly IBaseEfRepository<TModel> _repo;
        public BaseEfBc(IBaseEfRepository<TModel> repo)
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
    }
}
