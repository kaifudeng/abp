using Abp.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Acme.SimpleTaskApp.Tasks;
namespace Acme.SimpleTaskApp.EntityFrameworkCore
{
    public class SimpleTaskAppDbContext : AbpDbContext
    {
        public DbSet<Task> Tasks { get; set; }

        public SimpleTaskAppDbContext(DbContextOptions<SimpleTaskAppDbContext> options)
            : base(options)
        {

        }
    }
}
