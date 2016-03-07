using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using AdventureWorksEntityFramework.DataAccess;
using System.Diagnostics;
using System.Collections.Generic;

namespace WcfEntitiesSample.DataAccessTest
{
    [TestClass]
    public class DatabaseUnitTests
    {
        private ITestAdventureWorksDatabase _sqlServerDatabaseStrategy;
        private UnitOfWork _unitOfWork = null;

        [TestInitialize]
        public void SetupTest()
        {
            // create the test strategy.  This will initialise a new database
            _sqlServerDatabaseStrategy = CreateTestStrategy();

            // add test data to the database instance
            _unitOfWork = _sqlServerDatabaseStrategy.CreateUnitOfWork();
        }

        protected ITestAdventureWorksDatabase CreateTestStrategy()
        {
            return new SqlServerDatabaseContext();
        }

        [TestCleanup]
        public void CleanupTest()
        {
            // dispose of the database and connection
            _unitOfWork = null;
        }

        [TestMethod]
        public void GetProductsFromDatabase()
        {
            var listProducts = new List<Product>(_unitOfWork.ProductRepository.Get());
            Assert.IsTrue(listProducts.Count > 0);
        }

        [TestMethod]
        public void GetProductByIdFromDatabase()
        {

            var product = _unitOfWork.ProductRepository.GetByID(1);
            Assert.IsNotNull(product);
        }
    }
}
