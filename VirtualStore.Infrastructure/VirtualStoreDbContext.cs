using Microsoft.EntityFrameworkCore;
using VirtualStore.Core.Entities;

namespace VirtualStore.Infrastructure
{
    public class VirtualStoreDbContext : DbContext
    {
        public VirtualStoreDbContext(DbContextOptions<VirtualStoreDbContext> options) : base(options)
        {
        }

        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }

    }
}
