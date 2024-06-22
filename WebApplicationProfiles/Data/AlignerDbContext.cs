using Microsoft.EntityFrameworkCore;
using WebApplicationProfiles.Models;

namespace WebApplicationProfiles.Data
{
    public class AlignerDbContext : DbContext
    {
        public AlignerDbContext(DbContextOptions<AlignerDbContext> options) : base(options) { }
        public DbSet<Aligner> Aligners { get; set; }
    }
}
    