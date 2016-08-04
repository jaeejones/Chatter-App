using System.Data.Entity;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;

namespace Chatter.Models
{
    // You can add profile data for the user by adding more properties to your ApplicationUser class, please visit http://go.microsoft.com/fwlink/?LinkID=317594 to learn more.
    public class ApplicationUser : IdentityUser

    {
        public string UserID { get; set; }
        [MaxLength(50)]
        public string Username { get; set; }
        public string Name { get; set; }
        public string ProfilePicUrl { get; set; }
        //need to find how to use hashset for password
        //HashSet<string> PasswordHashset = new HashSet<string> { get; set; }
        //var Password = new HashSet<int>(Password.Users.Select(char => c.UserID));
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }
        //Revisit for better variable type to store location
        public string Description { get; set; }
        public string LastUpdate { get; set; }
        public int FollowerAccount { get; set; }     

        //Navigation properties.... "virtual" means it can be overridden
        public virtual ICollection<Rating> Ratings { get; set; }
        public virtual ICollection<Business> Businesses { get; set; }


        public async Task<ClaimsIdentity> GenerateUserIdentityAsync(UserManager<ApplicationUser> manager)
        {
            // Note the authenticationType must match the one defined in CookieAuthenticationOptions.AuthenticationType
            var userIdentity = await manager.CreateIdentityAsync(this, DefaultAuthenticationTypes.ApplicationCookie);
            // Add custom user claims here
            return userIdentity;
        }
    }

    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext()
            : base("DefaultConnection", throwIfV1Schema: false)
        {
        }

        public static ApplicationDbContext Create()
        {
            return new ApplicationDbContext();
        }
    }
}