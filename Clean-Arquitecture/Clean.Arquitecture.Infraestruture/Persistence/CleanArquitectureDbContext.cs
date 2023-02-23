using Clean.Arquitecture.Domain;
using Microsoft.EntityFrameworkCore;

namespace Clean.Arquitecture.Infraestruture.Persistence
{
    public class CleanArquitectureDbContext : DbContext
    {
        public CleanArquitectureDbContext(DbContextOptions<CleanArquitectureDbContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<User>().HasData(CleanArquitectureDbContextSeed
                .GetConfigurationUser());
        }

        public DbSet<User> Users { get; set; }
    }
}
