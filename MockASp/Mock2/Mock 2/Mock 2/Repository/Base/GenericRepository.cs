using Microsoft.EntityFrameworkCore;
using Mock_2.Data;
using Mock_2.Interface.IRepositories;
using System.Linq.Expressions;

namespace Mock_2.Repository.Base
{
    public class GenericRepository<T> : IGenericRepo<T> where T : class
    {
        public readonly HouseRentalDbContext _db;
        public readonly DbSet<T> _dbSet;
        public GenericRepository(HouseRentalDbContext db)
        {
            _db = db;
            _dbSet = db.Set<T>();
        }
        public async Task CreateAsync(T entity)
        {
            await _dbSet.AddAsync(entity);
            await SaveAsync();
        }

        public async Task DeleteAsync(T entity)
        {
            _dbSet.Remove(entity);
            await SaveAsync();
        }

        public async Task<List<T>> GetAsync(Expression<Func<T, bool>> filter = null, params Expression<Func<T, object>>[] properties)
        {
            IQueryable<T> query = _dbSet;
            query = properties.Aggregate(query, (current, includedProperty) => current.Include(includedProperty));
            if (filter != null)
            {
                query = query.Where(filter);
            }
            return await query.ToListAsync();
        }

        public async Task<T> GetByIDAsync(Expression<Func<T, bool>> filter = null, bool tracked = true, params Expression<Func<T, object>>[] properties)
        {
            IQueryable<T> query = _dbSet;
            query = properties.Aggregate(query, (current, includedProperty) => current.Include(includedProperty));
            if (!tracked)
            {
                query = query.AsNoTracking();
            }
            if (filter != null)
            {
                query = query.Where(filter);
            }
            return await query.FirstOrDefaultAsync();
        }

        public async Task SaveAsync()
        {
            await _db.SaveChangesAsync();
        }

        public async Task UpdateAsync(T entity)
        {
            _dbSet.Update(entity);
            await SaveAsync();
        }
    }
}
