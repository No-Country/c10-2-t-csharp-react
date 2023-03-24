using Microsoft.AspNetCore.Identity;

namespace KeyZone.Models
{
    public class UserAplication :IdentityUser
    {

        public int Id { get; set; }

        public string Name { get; set; }


        public string LastName { get; set; }




    }
}