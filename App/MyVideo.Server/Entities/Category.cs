using MyVideo.Data.Entity;

namespace MyVideo.Server.Entities
{
    public class Category : Entity
    {
        public int Id { get; set; }
        public string? Name { get; set; }
    }
}
