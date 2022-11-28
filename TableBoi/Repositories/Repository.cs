using Dapper;
using System;
using System.Collections.Generic;
using System.Data;
using TableBoi.Providers;

namespace TableBoi.Repositories
{
    public abstract class Repository
    {
        private readonly IDbConnectionProvider _connectionProvider;

        public Repository(IDbConnectionProvider connectionProvider)
        {
            _connectionProvider = connectionProvider;
        }

        protected void ExecuteQueryWithoutReturn(string procedureName, DynamicParameters param = null)
        {
            using (var connection = _connectionProvider.Open())
                connection.Execute(procedureName, param, commandType: CommandType.StoredProcedure);
        }

        protected T ExecuteQueryReturnScalar<T>(string procedureName, DynamicParameters param = null)
        {
            using (var connection = _connectionProvider.Open())
                return (T)Convert.ChangeType(connection.ExecuteScalar(procedureName, param, commandType: CommandType.StoredProcedure), typeof(T));
        }

        protected IEnumerable<T> ExecuteQueryReturnList<T>(string procedureName, DynamicParameters param = null)
        {
            using (var connection = _connectionProvider.Open())
                return connection.Query<T>(procedureName, param, commandType: CommandType.StoredProcedure);
        }

        protected void ExecuteSqlWithoutReturn(string sql)
        {
            using (var connection = _connectionProvider.Open())
                connection.Execute(sql);
        }

        protected IEnumerable<T> ExecuteSqlReturnList<T>(string sql)
        {
            using (var connection = _connectionProvider.Open())
                return connection.Query<T>(sql);
        }
    }
}
