using System;
using System.Data.Entity.Migrations;
using AdventureWorksEntityFramework.DataAccess;

namespace WcfEntitiesSample.DataAccessTest
{
    public class ProductManagerTestData
    {
        public static void AddTestData(UnitOfWork unitOfWork)
        {
            unitOfWork.ProductRepository.Insert(new Product() { ProductID = 1, Name = "Adjustable Race" });
            unitOfWork.ProductRepository.Insert(new Product() { ProductID = 316, Name = "Blade" });
            unitOfWork.Save();
        }
    }
}
