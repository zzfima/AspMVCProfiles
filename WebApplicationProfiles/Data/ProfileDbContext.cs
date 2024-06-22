using Microsoft.EntityFrameworkCore;
using WebApplicationProfiles.Models;

namespace WebApplicationProfiles.Data
{
    public class ProfileDbContext : DbContext
    {
        public ProfileDbContext(DbContextOptions<ProfileDbContext> options) : base(options) { }
        public DbSet<Profile> Profiles { get; set; }
    }
}
