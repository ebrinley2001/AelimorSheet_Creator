using AelimorSheetCreator.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace AelimorSheetCreator.Sdk
{
    public interface IClassProxy
    {
        public Task<IEnumerable<Class>> GetAllClasses();
        public Task<Class> GetClassById(int Id);
        public Task<int> PostClass(Class newClass);
        public Task<int> DeleteClassById(int Id);
        public Task<int> UpdateClassById(int id, Class newClass);

    }
}
