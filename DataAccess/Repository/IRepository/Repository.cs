using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace Makyr.DataAccess.Repository.IRepository
{
    public class Repository<T> : IRepository<T> where T : class
    {
        private readonly ApplicationDbContext _db;
        internal DbSet<T> dbSet;

        public Repository(ApplicationDbContext db)
        {
            _db = db;
            dbSet = _db.Set<T>();
        }

        public void Add(T entity)
        {
            dbSet.Add(entity);

        }

        public async Task AddAsync(T entity)
        {
            await dbSet.AddAsync(entity);
        }

        public T Get(Expression<Func<T, bool>> filter)
        {
            return dbSet.SingleOrDefault(filter);
        }

        public async Task<T> GetAsync(Expression<Func<T, bool>> filter)
        {
            return await dbSet.SingleOrDefaultAsync(filter);
        }

        public IEnumerable<T> GetAll()
        {
            return dbSet.ToList();
        }

        public async Task<IEnumerable<T>> GetAllAsync()
        {
            return await dbSet.ToListAsync();
        }

        public void Remove(T entity)
        {
            dbSet.Remove(entity);
        }

        public void RemoveRange(IEnumerable<T> entities)
        {
            dbSet.RemoveRange(entities);
        }
    }
}
