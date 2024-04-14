using Mock_2.Model.Entity;
using System.Linq.Expressions;

namespace Mock_2.Interface.IRepositories
{
    public interface IGenericRepo<T> where T : class
    {
        Task<List<T>> GetAsync(Expression<Func<T, bool>> filter = null, params Expression<Func<T, object>>[] properties);
        Task<T> GetByIDAsync(Expression<Func<T, bool>> filter = null, bool tracked = true, params Expression<Func<T, object>>[] properties);

        // CRUD Operations and Save
        Task CreateAsync(T entity);
        Task UpdateAsync(T entity);
        Task DeleteAsync(T entity);
        // In case we work seperately, we can use SaveAsynce()
        Task SaveAsync();
        Task<IEnumerable<Address>> GetAllAsync();
    }
}
