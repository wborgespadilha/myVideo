using DapperExtensions.Mapper;

namespace MyVideo.Data.Entity
{
    public class EntityClassMapper<TEntity> : ClassMapper<TEntity> where TEntity : Entity
    {
        public EntityClassMapper() 
        {
            Map(c => c.CreatedBy).Column("CreatedBy");
            Map(c => c.CreatedAt).Column("CreatedDate");
            Map(c => c.UpdatedBy).Column("UpdatedBy");
            Map(c => c.UpdatedAt).Column("UpdatedAt");
        }
    }
}
