using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace NTier.Core.Repositories
{
    public interface IGenericRepository<T> where T : class
    {
        // Task is always Async
        Task<T> GetByIdAsync(int id);
        Task<IEnumerable<T>> GetAllAsync();
        // Expressions point the delegations.
        IQueryable<T> Where(Expression<Func<T, bool>> expression);
        Task<bool> AnyAsync(Expression<Func<T, bool>> expression);
        Task AddAsync(T entity);
        Task AddRangeAsync(IEnumerable<T> entities);
        void Update(T entity);
        void Remove(T entity);
        void RemoveRange(T entity);

    }
}
