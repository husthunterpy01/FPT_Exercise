using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Storage;
using Mock_2.Data;
using Mock_2.Interface.IRepositories;
using Mock_2.Interface.IUOW;
using Mock_2.Repository.Base;

namespace Mock_2.Repository.UOW
{
    public class UnitOfWork : IUnitOfWork
    {
        // DbContext
        public HouseRentalDbContext _db { get; }
        // DbContextTransaction
        private IDbContextTransaction? _objecTrans;
        // Disposed(Used for dispose)
        private bool _disposed;
        // Error messasge
        private string _errorMessage = string.Empty;
        private bool disposedValue;

        public UnitOfWork(HouseRentalDbContext db)
        {
            _db = db;
        }

        // Create Db Transaction principles
        public void CreateTransaction()
        {
            _objecTrans = _db.Database.BeginTransaction();
        }
        // Commit if all transactions successful
        public void Commit()
        {
            _objecTrans?.Commit();
        }
        // Rollback if at least 1 Transaction Failed
        public void Rollback()
        {
            Dispose(disposing: true);
            GC.SuppressFinalize(this);
        }
        // SaveChange if all transactions is successful
        public async Task Save()
        {
            try
            {
                _db.SaveChanges();
            }
            catch (DbUpdateException dbEx)
            {
                throw new Exception(_errorMessage, dbEx);
            }
        }

        protected virtual void Dispose(bool disposing)
        {
            if (!disposedValue)
            {
                if (disposing)
                {
                    // TODO: dispose managed state (managed objects)
                }

                // TODO: free unmanaged resources (unmanaged objects) and override finalizer
                // TODO: set large fields to null
                disposedValue = true;
            }
        }

        // // TODO: override finalizer only if 'Dispose(bool disposing)' has code to free unmanaged resources
        // ~UnitOfWork()
        // {
        //     // Do not change this code. Put cleanup code in 'Dispose(bool disposing)' method
        //     Dispose(disposing: false);
        // }

        public void Dispose()
        {
            // Do not change this code. Put cleanup code in 'Dispose(bool disposing)' method
            Dispose(disposing: true);
            GC.SuppressFinalize(this);
        }
    }
}
