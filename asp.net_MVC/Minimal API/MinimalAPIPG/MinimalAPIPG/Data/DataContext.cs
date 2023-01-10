global using Microsoft.EntityFrameworkCore;
using MinimalAPIPG.Models;

namespace MinimalAPIPG.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options) 
        {
        }

        public DbSet<SuperHero> SuperHeroes => Set<SuperHero>();
    }
}
