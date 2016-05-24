using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using Secret_Overt.Models;

namespace Secret_Overt.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<Secret_Overt.Models.ApplicationDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
            ContextKey = "Secret_Overt.Models.ApplicationDbContext";
        }

        protected override void Seed(Secret_Overt.Models.ApplicationDbContext context)
        {

            //if (!context.Users.Any(u => u.Email == "sallen@gmail.com"))
            //{
            //    var store = new UserStore<ApplicationUser>(context);
            //    var manager = new UserManager<ApplicationUser>(store);
            //    var user = new ApplicationUser {UserName = "", Email = "sallen@gmail.com"};

            //    manager.Create(user, "Password1234_");
            //}
            //var hasher = new PasswordHasher();
            //context.Users.AddOrUpdate(u => u.UserName,
            //    new ApplicationUser() {UserName = "sallen", PasswordHash = hasher.HashPassword("Sallen1234_") });


            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.
            //
            //    context.People.AddOrUpdate(
            //      p => p.FullName,
            //      new Person { FullName = "Andrew Peters" },
            //      new Person { FullName = "Brice Lambson" },
            //      new Person { FullName = "Rowan Miller" }
            //    );
            //
        }
    }
}
