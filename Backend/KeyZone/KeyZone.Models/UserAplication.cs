using Microsoft.AspNetCore.Identity;

namespace KeyZone.Models
{
    public class UserAplication :IdentityUser
    {
        public string Name { get; set; }
        public string LastName { get; set; }

    }
}