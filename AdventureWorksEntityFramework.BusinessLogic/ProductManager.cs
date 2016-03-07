using AdventureWorksEntityFramework.DataAccess;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace AdventureWorksEntityFramework.BusinessLogic
{
    // The repository
    public class ProductManager
    {
        private GenericRepository<Product> _productRepository;

        public ProductManager()
        {
            this._productRepository = new GenericRepository<Product>(new AdventureWorksEntities());
        }

        public ProductManager(GenericRepository<Product> productRepository)
        {
            this._productRepository = productRepository;
        }

        public List<Product> GetProducts()
        {
            IEnumerable<Product> products = null;

            products = (from p in _productRepository.Get()
                    select new  { ProductID = p.ProductID, Name = p.Name }).ToList()
                    .Select(x => new Product { ProductID = x.ProductID, Name = x.Name });

            return products.ToList();
        }
    }
}
