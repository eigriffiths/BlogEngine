using BlogEngine.repo.Models;
using Microsoft.EntityFrameworkCore;

namespace BlogEngine.repo.DAL
{
    public class Context : DbContext
    {
        public Context(DbContextOptions<Context> options)
            : base(options)
        {
        }
        public DbSet<Story> Stories { get; set; }
    }
}
