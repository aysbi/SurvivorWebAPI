namespace SurvivorWebAPI.Data.Entity
{
    public class Category
    {
        public int Id { get; set; }

        public DateTime CreatedTime { get; set; } = DateTime.UtcNow;

        public DateTime ModifiedTime { get; set; } = DateTime.UtcNow;

        public bool IsDeleted { get; set; } = false;

        public string Name { get; set; } = "";

        public List<Competitor>? Competitors { get; set; }
    }
}
