using Microsoft.EntityFrameworkCore;

namespace Project2Prototype.Data.Entities
{
    public class Project2PrototypeContext : DbContext
    {
        public DbSet<Customer> Creator { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Customer>()
                  .Property(b => b.PhoneNumber)
                  .IsRequired();
        }

        public Project2PrototypeContext(DbContextOptions<Project2PrototypeContext> options)
            : base(options)
        {
        }
    }
}