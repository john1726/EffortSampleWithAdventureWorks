using System;

namespace AdventureWorksEntityFramework.DataAccess
{
    public class UnitOfWork : IDisposable
    {
        private IAdventureWorksDbContext _context = null;
        private GenericRepository<Product> _productRepository;

        public UnitOfWork()
        {
            _context = new AdventureWorksEntities();
        }

        public UnitOfWork(IAdventureWorksDbContext context)
        {
            _context = context;
        }

        public GenericRepository<Product> ProductRepository
        {
            get
            {

                if (this._productRepository == null)
                {
                    this._productRepository = new GenericRepository<Product>(_context);
                }
                return _productRepository;
            }
        }

        public void Save()
        {
            _context.SaveChanges();
        }

        private bool disposed = false;

        protected virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    _context.Dispose();
                }
            }
            this.disposed = true;
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }
}