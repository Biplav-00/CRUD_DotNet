using Microsoft.EntityFrameworkCore;
using ToDo_DotNet.Models.Domain;

namespace ToDo_DotNet.Data
{
    public class MVCDemoDbContext : DbContext
    {
        public MVCDemoDbContext(DbContextOptions options) : base(options)
        {
            
        }
        public DbSet<Employee> Employee { get; set; }
    }
}
