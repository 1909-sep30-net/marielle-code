using Microsoft.EntityFrameworkCore;

namespace Project2Prototype.Data.Entities
{
    public class Project2PrototypeContext : DbContext
    {
        public DbSet<Creator> Creator { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Creator>()
                  .Property(b => b.PhoneNumber)
                  .IsRequired();
        }

        public Project2PrototypeContext(DbContextOptions<Project2PrototypeContext> options)
            : base(options)
        {
        }
    }
}