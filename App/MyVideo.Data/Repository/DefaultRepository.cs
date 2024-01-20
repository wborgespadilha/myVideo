using DapperExtensions;
using DapperExtensions.Predicate;
using System.Data;

namespace MyVideo.Data.Repository
{
    public class DefaultRepository<TEntity> : IDefaultRepository<TEntity> where TEntity : class
    {
        private readonly IDbConnection _dbConnection;

        public DefaultRepository(IDbConnection dbConnection)
        {
            _dbConnection = dbConnection;
        }

        public List<TEntity> Fetch(IPredicate predicate)
        {
            _dbConnection.Open();
            var result = _dbConnection.GetList<TEntity>(predicate);
            _dbConnection.Close();

            return result.ToList();
        }
    }
}
