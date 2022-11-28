using ServiceStack.OrmLite;
using ServiceStack.OrmLite.Sqlite;
using System.Data;
using TableBoi.Providers;

namespace TableTests.Utils
{
    public class VirtualDatabaseProvider : IDbConnectionProvider
    {
        private readonly OrmLiteConnectionFactory dbFactory = new OrmLiteConnectionFactory(":memory:", SqliteOrmLiteDialectProvider.Instance);

        public IDbConnection Open()
        {
            return dbFactory.OpenDbConnection();
        }
    }
}
