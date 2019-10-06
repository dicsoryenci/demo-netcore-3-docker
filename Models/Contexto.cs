using Microsoft.EntityFrameworkCore;

namespace webmvc
{
    public class Contexto : DbContext
    {
        public Contexto(DbContextOptions<Contexto> options)
            : base(options)
        {
        }

        public DbSet<Regions> Regions { get; set; }
    }
}