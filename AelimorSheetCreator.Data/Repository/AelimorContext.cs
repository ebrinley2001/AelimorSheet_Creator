using AelimorSheetCreator.Models;
using Microsoft.EntityFrameworkCore;


namespace AelimorSheetCreator.Data.Repository
{
    public class AelimorContext : DbContext
    {
        public DbSet<Class> Class { get; set; }

        public AelimorContext(DbContextOptions<AelimorContext> options)
            : base(options)
        {
        }
    }
}
