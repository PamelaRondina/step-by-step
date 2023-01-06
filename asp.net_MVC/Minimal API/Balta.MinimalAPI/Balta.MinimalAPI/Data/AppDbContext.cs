using Microsoft.EntityFrameworkCore;

namespace Balta.MinimalAPI.Data
{
    public class AppDbContext : DbContext
    {
        //criar propriedade
        public DbSet<Todo> Todos { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
            => options.UseSqlite("DataSource=app.db;Cache=Shared");
    }
}
