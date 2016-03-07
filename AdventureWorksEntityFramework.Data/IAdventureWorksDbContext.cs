using AdventureWorksEntityFramework.DataAccess;
using System;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;

namespace AdventureWorksEntityFramework.DataAccess
{
    public interface IAdventureWorksDbContext : IDisposable
    {
        DbContextConfiguration Configuration { get; }
        Database Database { get; }
        IDbSet<vProductProductInventory> vProductProductInventories { get; set; }
        IDbSet<Product> Products { get; set; }
        IDbSet<ProductInventory> ProductInventories { get; set; }
        IDbSet<TEntity> Set<TEntity>() where TEntity : class;
        DbEntityEntry Entry(object entity);

        int SaveChanges();
    }
}
