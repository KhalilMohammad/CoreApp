using Microsoft.EntityFrameworkCore;

namespace CoreApp.Model
{
    public class ApplicatinoDbContext : DbContext
    {
        public ApplicatinoDbContext(DbContextOptions options) : base(options)
        {

        }

        public DbSet<User> User { get; set; }
    }
}
