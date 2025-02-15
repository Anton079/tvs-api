using Microsoft.EntityFrameworkCore;
using tvs_api.Tvs.Models;

namespace tvs_api.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        public virtual DbSet<Tv> Tvs { get; set; }
    }
}
