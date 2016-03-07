using System.Data.Common;
using AdventureWorksEntityFramework.DataAccess;

namespace WcfEntitiesSample.DataAccessTest
{
    public class SqlServerDatabaseContext : ITestAdventureWorksDatabase
    {
        public UnitOfWork CreateUnitOfWork()
        {
            var unitOfWork = new UnitOfWork(new AdventureWorksEntities());

            return unitOfWork;
        }
    }
}
