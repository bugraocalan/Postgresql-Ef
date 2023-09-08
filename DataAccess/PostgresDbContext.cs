using Domain;
using Microsoft.EntityFrameworkCore;

namespace DataAccess
{
    public class PostgresDbContext : DbContext
    {
        public PostgresDbContext(DbContextOptions<PostgresDbContext> options):base(options) { }
        public PostgresDbContext()
        {

        }
        public DbSet<Users> Users { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }

    }
}
