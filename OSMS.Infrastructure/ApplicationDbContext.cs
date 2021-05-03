using Microsoft.EntityFrameworkCore;
using OSMS.Infrastructure.DataEntities;

namespace OSMS.Infrastructure
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) {  }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            _ = new StudentMapper(modelBuilder.Entity<Student>());

        }
    }
}
