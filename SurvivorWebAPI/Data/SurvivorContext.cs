using Microsoft.EntityFrameworkCore;
using SurvivorWebAPI.Data.Entity;

namespace SurvivorWebAPI.Data
{
    public class SurvivorContext : DbContext
    {
        public SurvivorContext(DbContextOptions options) : base(options) 
        {

        }

        public DbSet<Category> Categories { get; set; }

        public DbSet<Competitor> Competitors { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>().HasData(BringCategories());
            modelBuilder.Entity<Competitor>().HasData(BringCompetitors());
            modelBuilder.Entity<Competitor>().HasOne(c => c.Category).WithMany(c => c.Competitors).HasForeignKey(c => c.CategoryId);
        }

        private List<Category> BringCategories()
        {
            return new List<Category>
             {
                new Category { Id = 1, Name = "Unluler" },
                new Category { Id = 2, Name = "Gonulluler" },
            };
        }

        private List<Competitor> BringCompetitors()
        {
            return new List<Competitor>
            {
                new Competitor { Id = 1, FirstName = "Acun", LastName = "Ilicali", CategoryId = 1 },
                new Competitor { Id = 2, FirstName = "Aleyna", LastName = "Avci", CategoryId = 1 },
                new Competitor { Id = 3, FirstName = "Hadise", LastName = "Acikgoz", CategoryId = 1 },
                new Competitor { Id = 4, FirstName = "Sertan", LastName = "Bozkus", CategoryId = 1 },
                new Competitor { Id = 5, FirstName = "Ozge", LastName = "Acik", CategoryId = 1 },
                new Competitor { Id = 6, FirstName = "Kivanc", LastName = "Tatlitug", CategoryId = 1 },
                new Competitor { Id = 7, FirstName = "Ahmet", LastName = "Yilmaz", CategoryId = 2 },
                new Competitor { Id = 8, FirstName = "Elif", LastName = "Demirtas", CategoryId = 2 },
                new Competitor { Id = 9, FirstName = "Cem", LastName = "Ozturk", CategoryId = 2 },
                new Competitor { Id = 10, FirstName = "Ayse", LastName = "Karaca", CategoryId = 2 }
             };
        }
    }
}
