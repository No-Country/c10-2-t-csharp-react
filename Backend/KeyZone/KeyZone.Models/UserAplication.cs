using Microsoft.AspNet.Identity.EntityFramework;

namespace KeyZone.Models
{
    public class UserAplication :IdentityUser
    {

        public int Id { get; set; }

        public string Name { get; set; }


        public string LastName { get; set; }




    }
}