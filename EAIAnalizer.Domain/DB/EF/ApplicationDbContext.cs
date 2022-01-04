using EAIAnalizer.Domain.DB.EF;
using EAIAnalizer.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace EAIAnalizer_Backend.DB
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<Operation> Operations { get; set; } = null!;
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
            Database.EnsureCreated();
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder = DBInitializator.Initialize(modelBuilder);
            /*modelBuilder.Entity<Currency>()
                .HasIndex(c => new { c.Name })
                .IsUnique(true);*/
            base.OnModelCreating(modelBuilder);
        }
    }
}
 