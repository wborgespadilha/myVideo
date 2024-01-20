using DapperExtensions.Predicate;

namespace MyVideo.Data.Repository
{
    public interface IDefaultRepository<TEntity> where TEntity : class
    {
        List<TEntity> Fetch(IPredicate predicate);
    }
}
