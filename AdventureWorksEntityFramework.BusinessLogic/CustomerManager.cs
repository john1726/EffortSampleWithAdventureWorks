using AdventureWorksEntityFramework.DataAccess;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace AdventureWorksEntityFramework.BusinessLogic
{
    // The repository
    public class CustomerManager
    {
        private INorthwindDbContext _dbContext;

        public CustomerManager(INorthwindDbContext dbContext)
        {
            dbContext.Configuration.AutoDetectChangesEnabled = false;
            this._dbContext = dbContext;
        }

        public List<Customer> GetCustomers()
        {
            IEnumerable<Customer> products = null;

            products = (from p in _dbContext.Customers
                        select new { CustomerID = p.CustomerID, CompanyName = p.CompanyName }).ToList()
                    .Select(x => new Customer { CustomerID = x.CustomerID, CompanyName = x.CompanyName });

            return products.ToList();
        }
    }
}
