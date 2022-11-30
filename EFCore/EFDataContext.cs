using Microsoft.EntityFrameworkCore;

namespace postgres_dotnet.EFCore
{
    public class EFDataContext : DbContext
    {
        public EFDataContext(DbContextOptions<EFDataContext> options) : base(options) { }

        // public override void OnModelCreating(ModelBuilder modelBuilder)
        // {
        //     modelBuilder.UseSerialColumns();
        // }

        public DbSet<Product> Products { get; set; }

        public DbSet<Order> Orders { get; set; }

    }
}