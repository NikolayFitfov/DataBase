using Microsoft.AspNetCore.Identity;

namespace MercedesChasti_ZvezdniChasti.Data
{
    public class User:IdentityUser
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public ICollection<Order> Orders { get; set; }
    }
}
