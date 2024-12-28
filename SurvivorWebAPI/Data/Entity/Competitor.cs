using System.ComponentModel.DataAnnotations.Schema;

namespace SurvivorWebAPI.Data.Entity
{
    public class Competitor
    {
        public int Id { get; set; }

        public DateTime CreatedTime { get; set; } = DateTime.UtcNow;

        public DateTime ModifiedTime { get; set; } = DateTime.UtcNow;

        public bool IsDeleted { get; set; } = false;

        public string FirstName { get; set; } = "";

        public string LastName { get; set; } = "";

        [ForeignKey(nameof(CategoryId))]
        public int CategoryId { get; set; }

        public Category? Category { get; set; } 
    }
}
