using Microsoft.AspNetCore.Identity;

namespace KeyZone.Models.DataModels
{
    public class UserAplication :IdentityUser
    {
        public string Name { get; set; }
        public string LastName { get; set; }

    }
}