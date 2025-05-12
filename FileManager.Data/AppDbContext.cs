
using FileManager.Data.Entities;
using Microsoft.EntityFrameworkCore;

namespace FileManager.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options)
        : base(options)
        {
        }

        public DbSet<Container> Containers { get; set; }
    }
}
