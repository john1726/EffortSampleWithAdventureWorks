using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using AdventureWorksEntityFramework.DataAccess;
using System.Collections.Generic;

namespace WcfEntitiesSample.DataAccessTest
{
    [TestClass]
    public class EffortAdventureWorksUnitTests
    {
        private ITestAdventureWorksDatabase _effortDatabaseStrategy;
        private UnitOfWork _unitOfWork;

        [TestInitialize]
        public void SetupTest()
        {
            // create the test strategy.  This will initialise a new database
            _effortDatabaseStrategy = CreateTestStrategy();

            // add test data to the database instance
            _unitOfWork = _effortDatabaseStrategy.CreateUnitOfWork();
            ProductManagerTestData.AddTestData(_unitOfWork);
        }

        protected ITestAdventureWorksDatabase CreateTestStrategy()
        {
            return new EffortAdventureWorksDatabaseContext();
        }

        [TestCleanup]
        public void CleanupTest()
        {
            // dispose of the database and connection
            _unitOfWork.Dispose();
            _unitOfWork = null;
        }

        [TestMethod]
        public void GetProductsFromEffort()
        {
            var listProducts = new List<Product>(_unitOfWork.ProductRepository.Get());
            Assert.IsTrue(listProducts.Count > 0);
        }
    }
}
