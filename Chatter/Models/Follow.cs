using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Chatter.Models
{
    public class Follow
    {
      
        public string Person { get; set; }
        public string Password { get; set;}
        //need to find how to use hashset for password
        //HashSet<string> PasswordHashset = new HashSet<string> { get; set; }
        //var Password = new HashSet<int>(Password.Users.Select(char => c.UserID))    
        //Revisit for better variable type to store location
  

        //Navigation properties.... "virtual" means it can be overridden
        public virtual ICollection<User> UserID { get; set; }
        public virtual ICollection<Business> Businesses { get; set; }


    }
}