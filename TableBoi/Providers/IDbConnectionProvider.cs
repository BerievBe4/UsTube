using System.Data;

namespace TableBoi.Providers
{
    public interface IDbConnectionProvider
    {
        IDbConnection Open();
    }
}
