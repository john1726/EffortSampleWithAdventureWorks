using System.Data.Common;
using AdventureWorksEntityFramework.DataAccess;

namespace WcfEntitiesSample.DataAccessTest
{
    public class EffortAdventureWorksDatabaseContext : ConnectionProviderBase, ITestAdventureWorksDatabase
    {
        public UnitOfWork CreateUnitOfWork()
        {
            base.CreateConnection();
            var unitOfWork = new UnitOfWork(new AdventureWorksEntities(_connection));

            return unitOfWork;
        }
    }
}
