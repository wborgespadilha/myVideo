using MyVideo.Data.Repository;
using MyVideo.Server.Entities;
using System.Data;

namespace MyVideo.Server.Repositories.Impl
{
    public class DefaultCategoryRepository : DefaultRepository<Category>
    {
        public DefaultCategoryRepository(IDbConnection dbConnection) : base(dbConnection)
        {
        }
    }
}
