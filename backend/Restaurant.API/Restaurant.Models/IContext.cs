using Microsoft.EntityFrameworkCore;

namespace Restaurant.Models
{
    public interface IContext
    {
        public DbSet<Grade> Grades { get; set; }
        public DbSet<Menu> Menus { get; set; }
        public DbSet<Restaurants> Restaurants { get; set; }
        public DbSet<Score> Scores { get; set; }
        public DbSet<Cuisine> Cuisines { get; set; }
        public Task SaveAsync();

    }
}