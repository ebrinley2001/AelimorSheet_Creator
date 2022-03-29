using AelimorSheetCreator.Models;
using Microsoft.EntityFrameworkCore;


namespace AelimorSheetCreator.Data.Repository
{
    public class AelimorContext : DbContext
    {
        public DbSet<Attribute> Attribute { get; set; }
        public DbSet<AttributeSkill> AttributeSkill { get; set; }
        public DbSet<Class> Class { get; set; }
        public DbSet<Level> Level { get; set; }
        public DbSet<Race> Race { get; set; }
        public DbSet<RacialSkill> RacialSkill { get; set; }
        public DbSet<Skill> Skill { get; set; }

        public AelimorContext(DbContextOptions<AelimorContext> options)
            : base(options)
        {
        }
    }
}
