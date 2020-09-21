using BGlobalSolutionsExam.Repositories.EntityFramework.Configuration;
using BGlobalSolutionsExam.Repositories.EntityFramework.Model;
using Microsoft.EntityFrameworkCore;

namespace BGlobalSolutionsExam.Repositories.EntityFramework
{
    public class BGlobalSolutionsContext : DbContext
    {
        public DbSet<Vehicle> Vehicles { get; set; }

        public BGlobalSolutionsContext(DbContextOptions<BGlobalSolutionsContext> options) : base(options)
        {
            ChangeTracker.LazyLoadingEnabled = false;
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new VehicleConfiguration());
        }
    }
}
