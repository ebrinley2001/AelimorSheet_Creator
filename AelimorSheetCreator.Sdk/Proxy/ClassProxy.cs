using AelimorSheetCreator.Models;
using EthanFramework.Sdk.Proxy;
using Microsoft.Extensions.Configuration;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace AelimorSheetCreator.Sdk.Proxy
{
    public class ClassProxy : BaseApiProxy<Class>, IClassProxy
    {
        public ClassProxy(IConfiguration config) :
            base(config,
                ProxyConstants.Controller,
                ProxyConstants.ClassEndpoint)
        {
        }

        public Task<IEnumerable<Class>> GetAllClasses()
        {
            return GetCollectionAsync();
        }

        public Task<Class> GetClassById(int Id)
        {
            return GetAsync(Id.ToString());
        }

        public Task<int> PostClass(Class newClass)
        {
            return PostAsync(newClass);
        }
        public Task<int> DeleteClassById(int Id)
        {
            return DeleteAsync(Id.ToString());
        }

        public Task<int> UpdateClassById(int id, Class newClass)
        {
            return UpdateAsync(id.ToString(), newClass);
        }
    }
}
