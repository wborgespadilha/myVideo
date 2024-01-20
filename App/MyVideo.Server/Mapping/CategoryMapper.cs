using DapperExtensions.Mapper;
using MyVideo.Data.Entity;
using MyVideo.Server.Entities;

namespace MyVideo.Server.Mapping
{
    public class CategoryMapper : EntityClassMapper<Category>
    {
        public CategoryMapper() 
        {
            Schema("Video");
            Table("Category");
            Map(c => c.Id).Column("CategoryID").Key(KeyType.Identity);
            Map(c => c.Name).Column("Name");
        }
    }
}
