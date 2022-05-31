using Microsoft.EntityFrameworkCore;

namespace LinqConsoleApp.DbOperations
{
    public class LinqDbContext : DbContext {
        //public LinqDbContext(DbContextOptions<LinqDbContext> options) : base(options) { }
        public DbSet<Student> Students { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder){
            optionsBuilder.UseInMemoryDatabase(databaseName : "LinqDatabse");
        }
    }
}