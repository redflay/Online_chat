using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;

namespace HelloApp
{
    public class ApplicationContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public ApplicationContext(DbContextOptions <ApplicationContext> options)
            : base(options)
        {
            Database.EnsureCreated();
        }
    }
}