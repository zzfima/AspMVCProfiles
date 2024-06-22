using Microsoft.EntityFrameworkCore;
using WebApplicationProfiles.Models;

namespace WebApplicationProfiles.Data
{
    public class ProfilesDbContext : DbContext
    {
        public ProfilesDbContext(DbContextOptions<ProfilesDbContext> options) : base(options) { }
        public DbSet<Profile> Profiles { get; set; }
    }
}
