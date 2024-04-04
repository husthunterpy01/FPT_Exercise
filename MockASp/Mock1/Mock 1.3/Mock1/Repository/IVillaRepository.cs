using Mock1.Model;
using System.Linq.Expressions;

namespace Mock1.Repository
{
    public interface IVillaRepository
    {
        Task<List<Villa>> GetAllAsync(Expression<Func<Villa,bool>> filter = null);
        Task<Villa> GetAsync(Expression<Func<Villa,bool>> filter = null, bool tracked = true);
        Task UpdateAsync(Villa entity);
        Task CreateAsync(Villa entity);
        Task RemoveAsync(Villa entity);
        Task SaveAsync();
    }
}
