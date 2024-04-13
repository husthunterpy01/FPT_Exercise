using Mock_2.Data;
using Mock_2.Interface.IRepositories;

namespace Mock_2.Interface.IUOW
{
    public interface IUnitOfWork : IDisposable
    {
        HouseRentalDbContext _db { get; }
        IGenericRepo<T> GetGenericRepo<T>() where T : class;
        void CreateTransaction();
        void Commit();
        void Rollback();

        Task Save();
    }
}
