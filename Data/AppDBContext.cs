
using IceTask2.Models;
using Microsoft.EntityFrameworkCore;

namespace IceTask2.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<Student> Students { get; set; }
    }
}
