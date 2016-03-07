using System;
using AdventureWorksEntityFramework.DataAccess;

namespace WcfEntitiesSample.DataAccessTest
{
    public interface ITestAdventureWorksDatabase
    {
        UnitOfWork CreateUnitOfWork();
    }
}
