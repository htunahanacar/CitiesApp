using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Cities.Core.IServices
{
    public interface IService<T> where T: class
    {
        Task<T> GetByIdAsync(int id);
        Task<IQueryable<T>> GetAllAsync();
        Task<IQueryable<T>> WhereAsync(Expression<Func<T, bool>> expression);
        Task<bool> AnyAsync(Expression<Func<T, bool>> expression);
        Task AddAsync(T entity);
        Task UpdateAsync(T entity);
        Task DeleteAsync(T entity);
        Task RemoveRangeAsync(IEnumerable<T> entities);
    }
}
