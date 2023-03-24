using KeyZone.Models;
using Microsoft.EntityFrameworkCore;

namespace KeyZone.DataAccess
{
    public class KeyZoneDbContext :DbContext
    {
        public KeyZoneDbContext(DbContextOptions<KeyZoneDbContext> options) : base(options)
        {

        }

        public DbSet<UserAplication> UsersAplication { get; set; }
    }
}