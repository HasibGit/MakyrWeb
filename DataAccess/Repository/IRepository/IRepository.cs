using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Makyr.DataAccess.Repository.IRepository
{
    public interface IRepository<T> where T : class
    {
        IEnumerable<T> GetAll();
        Task<IEnumerable<T>> GetAllAsync();
        T Get(Expression<Func<T, bool>> filter);
        Task<T> GetAsync(Expression<Func<T, bool>> filter);
        void Add(T entity);
        Task AddAsync(T entity);
        void Remove(T entity);
        Task RemoveAsync(T entity);
        void RemoveRange(IEnumerable<T> entities);
        Task RemoveRangeAsync(IEnumerable<T> entities);
        

    }
}
