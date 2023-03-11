using Microsoft.EntityFrameworkCore;

namespace BlogAPIDemo.DataAccessLayer
{
    public class Context : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=(localdb)\\MSSQLLocalDB;database=CoreBlogApiDB;integrated security=true;");
        }

        public DbSet<Employee> Employees { get; set; }
    }
}
