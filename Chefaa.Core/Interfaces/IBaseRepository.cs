using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Chefaa.Core.Interfaces
{
    public interface IBaseRepository<T> where T : class
    {
        Task<IEnumerable<T>> GetAllAsync();
        Task<T> GetByIdAsync(int id);
        Task<T> FindAsync(Expression<Func<T, bool>> criteria);
        Task<IEnumerable<T>> FindAllPaginatedAsync(Expression<Func<T, bool>> criteria, int page = 1, int pageSize = 8);
        Task<T> AddAsync(T entity);
        Task<IEnumerable<T>> AddRangeAsync(IEnumerable<T> entities);
        void Update(T entity);
        T Delete(int id);
        void DeleteRange(IEnumerable<T> entities);
        void DeActiveAndActive(IActivatable entity);
    }
}
