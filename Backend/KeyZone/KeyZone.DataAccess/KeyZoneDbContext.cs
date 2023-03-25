using KeyZone.Models.DataModels;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace KeyZone.DataAccess
{
    public class KeyZoneDbContext :IdentityDbContext
    {
        public KeyZoneDbContext(DbContextOptions<KeyZoneDbContext> options) : base(options) { }

        public DbSet<UserAplication> UsersAplication { get; set; }
        public DbSet<Game> Games { get; set; }
        public DbSet<Inventory> Inventories { get; set; }
        public DbSet<Platform> Platforms { get; set; }
        public DbSet<KeyGame> Keys { get; set; }
        public DbSet<Category> Categories { get; set; }



    }
}