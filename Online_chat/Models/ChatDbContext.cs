using Microsoft.EntityFrameworkCore;

namespace HelloApp
{
    public class ApplicationContext : DbContext
    {
        public DbSet<User> Users { get; set; }

        public ApplicationContext(DbContextOptions<ApplicationContext> options)
            : base(options)
        {
            Database.EnsureCreated();
        }
        var optionsBuilder = new DbContextOptionsBuilder<ApplicationContext>();
    }
}