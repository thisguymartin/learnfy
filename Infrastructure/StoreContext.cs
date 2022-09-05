using Microsoft.EntityFrameworkCore;
using Entity;


namespace Infrastructure
{
    public class StoreContext : DbContext
    {
        public StoreContext(DbContextOptions options) : base(options) { }

        public DbSet<Course> Courses { set; get; }

    }
}