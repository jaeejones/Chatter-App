namespace Chatter.Migrations
{
    using Chatter.Models;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<Chatter.Models.ApplicationDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(Chatter.Models.ApplicationDbContext context)
        {
            context.Users.AddOrUpdate(p => p.UserName,
      new ApplicationUser
      {
          UserName = "Debra Garcia",
          Email = "debra@example.com",
          Post = "hello testing",
          PasswordHash = "Te$t13"
      }

       );
            //
        }
    }
}
