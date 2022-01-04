using EAIAnalizer.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace EAIAnalizer_Backend.DB
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<Incoming> Incomings { get; set; } = null!;
        public DbSet<Outcoming> Outcomings { get; set; } = null!;
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
            Database.EnsureCreated();
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
        }
    }
}
