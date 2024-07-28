using System.Linq.Expressions;

namespace Cities.Core.IRepository
{
    public interface IGenericRepository <T> where T : class
    {
        Task<T> GetByIdAsync(int id);
        Task<IQueryable<T>> GetAll();
        Task<IQueryable<T>> Where(Expression<Func<T, bool>> expression);
        Task<bool> Any(Expression<Func<T, bool>> expression);
        Task AddAsync(T entity);
        void UpdateAsync(T entity);
        void DeleteAsync(T entity);
        void RemoveRange(IEnumerable<T> entities);
    }
}
