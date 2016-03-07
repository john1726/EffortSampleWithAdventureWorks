using Effort;
using System;
using System.Data.Common;

namespace WcfEntitiesSample.DataAccessTest
{
    public class ConnectionProviderBase : IDisposable
    {
        protected DbConnection _connection;

        protected void CreateConnection()
        {
            if (_connection == null)
            {
                _connection = DbConnectionFactory.CreateTransient();
            }
        }

        public void Dispose()
        {
            if (_connection != null)
            {
                _connection.Dispose();
            }
        }
    }
}