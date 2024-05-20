using Chefaa.Core.Interfaces;
using Chefaa.EF.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Chefaa.EF.Repositories
{
    public class BaseRepository<T> : IBaseRepository<T> where T : class
    {
        private readonly ApplicationDbContext _context;
        private readonly DbSet<T> DbSet;

        public BaseRepository(ApplicationDbContext context) 
        {
            _context = context;
            DbSet = _context.Set<T>();
        }

        public Task<T> AddAsync(T entity)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<T>> AddRangeAsync(IEnumerable<T> entities)
        {
            throw new NotImplementedException();
        }

        public void DeActiveAndActive(IActivatable entity)
        {
            throw new NotImplementedException();
        }

        public T Delete(int id)
        {
            throw new NotImplementedException();
        }

        public void DeleteRange(IEnumerable<T> entities)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<T>> FindAllPaginatedAsync(System.Linq.Expressions.Expression<Func<T, bool>> criteria, int page = 1, int pageSize = 8)
        {
            IQueryable<T> query = DbSet;

            if(criteria is not null)
            {
                query = query.Where(criteria);
            }

            return await query.Skip((page-1) * pageSize).Take(pageSize).ToListAsync();
        }

        public async Task<T> FindAsync(Expression<Func<T, bool>> criteria)
        {
            return await DbSet.AsNoTracking().SingleOrDefaultAsync(criteria);
        }

        public async Task<IEnumerable<T>> GetAllAsync()
        {
            return await DbSet.ToListAsync();
        }

        public async Task<T> GetByIdAsync(int id)
        {
            return await DbSet.FindAsync(id);
        }

        public void Update(T entity)
        {
            throw new NotImplementedException();
        }
    }
}
