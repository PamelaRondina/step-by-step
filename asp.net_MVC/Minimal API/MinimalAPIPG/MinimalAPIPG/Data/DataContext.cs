using Microsoft.EntityFrameworkCore;

namespace MinimalAPIPG.Data
{
    public class DataContext
    {
        public DataContext(DbContextOptions<DataContext>options) : base(options) { }
    }
}
