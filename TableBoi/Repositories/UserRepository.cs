using System.Linq;
using System.Text;
using TableBoi.Models;
using TableBoi.Providers;

namespace TableBoi.Repositories
{
    public class UserRepository : Repository
    {
        private string SqlInsertUserQuery(string login, string password)
        {
            StringBuilder sqlQuery = new StringBuilder();
            sqlQuery.Append("INSERT INTO UserModel(Login, Password) VALUES('");
            sqlQuery.Append(login);
            sqlQuery.Append("', '");
            sqlQuery.Append(password);
            sqlQuery.Append("')");

            return sqlQuery.ToString();
        }
        private string SqlGetUserByLoginQuery(string login)
        {
            StringBuilder sqlQuery = new StringBuilder();
            sqlQuery.Append("SELECT * FROM UserModel WHERE UserModel.Login = ");
            sqlQuery.Append(login);

            return sqlQuery.ToString();
        }

        public UserRepository(IDbConnectionProvider connectionProvider) :
            base(connectionProvider)
        { }

        public void AddUser(UserModel user)
        {
            string sql = SqlInsertUserQuery(user.Login, user.Password);
            ExecuteSqlWithoutReturn(sql);
        }

        public UserModel GetUserByLogin(string login)
        {
            string sql = SqlGetUserByLoginQuery(login);
            return ExecuteSqlReturnList<UserModel>(sql).FirstOrDefault<UserModel>();
        }
    }
}
