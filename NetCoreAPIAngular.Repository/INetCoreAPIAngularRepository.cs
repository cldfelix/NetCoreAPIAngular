using System.Threading.Tasks;
using NetCoreAPIAngular.Domain.Entities;

namespace NetCoreAPIAngular.Repository
{
    public interface INetCoreAPIAngularRepository
    {
         void Add<T>(T entity) where T: class;
         void Update<T>(T entity) where T: class;
         void Delete<T>(T entity) where T: class;
        Task<bool> SaveChangesAsync();

    }
}