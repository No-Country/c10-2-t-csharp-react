using KeyZone.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace KeyZone.DataAccess
{
    public class KeyZoneDbContext :IdentityDbContext
    {
        public KeyZoneDbContext(DbContextOptions<KeyZoneDbContext> options) : base(options) { }

        public DbSet<UserAplication> UsersAplication { get; set; }
    }
}