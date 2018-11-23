using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;

namespace Abc.MvcWebUI.Identity
{
    public class IdentityInitializer: DropCreateDatabaseIfModelChanges<IdentityDataContext>
    {
        protected override void Seed(IdentityDataContext context)
        {
            //Rolleri
            if (!context.Roles.Any(i=>i.Name=="admin"))
            {
                var store = new RoleStore<ApplicationRole>(context);
                var manager = new RoleManager<ApplicationRole>(store);
                var role = new ApplicationRole()
                {
                    Name="admin",
                    Description = "Admin rolü"
                };
                manager.Create(role);
            }

            if (!context.Roles.Any(i => i.Name == "user"))
            {
                var store = new RoleStore<ApplicationRole>(context);
                var manager = new RoleManager<ApplicationRole>(store);
                var role = new ApplicationRole()
                {
                    Name = "user",
                    Description = "User rolü"
                };
                manager.Create(role);
            }

            //User

            if (!context.Users.Any(i => i.Name == "dogancanalptekin"))
            {
                var store = new UserStore<ApplicationUser>(context);
                var manager = new UserManager<ApplicationUser>(store);
                var user = new ApplicationUser()
                {
                    Name = "Doğancan",
                    Surname = "Alptekin",
                    UserName = "dogancanalptekin",
                    Email = "dogancanalptekin@gmail.com"
                };

                manager.Create(user,"qwe1234");
                manager.AddToRole(user.Id, "admin");
                manager.AddToRole(user.Id, "user");
            }

            if (!context.Users.Any(i => i.Name == "sadikturan"))
            {
                var store = new UserStore<ApplicationUser>(context);
                var manager = new UserManager<ApplicationUser>(store);
                var user = new ApplicationUser()
                {
                    Name = "Sadık",
                    Surname = "Turan",
                    UserName = "sadikturan",
                    Email = "sadikturan@gmail.com"
                };

                manager.Create(user, "qwe1234");
                manager.AddToRole(user.Id, "user");
            }

            base.Seed(context);
        }
    }
}