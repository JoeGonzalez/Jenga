namespace Jenga.Data.Migrations
{
    using Jenga.Models;
    using Microsoft.AspNet.Identity;
    using Microsoft.AspNet.Identity.EntityFramework;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<Jenga.Data.ApplicationDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(Jenga.Data.ApplicationDbContext context)
        {
            var RoleStore = new RoleStore<IdentityRole>(context);
            var RoleManager = new RoleManager<IdentityRole>(RoleStore);

            if (!RoleManager.RoleExists("Admin"))
            {
                var Role = new IdentityRole();
                Role.Name = "Admin";
                RoleManager.Create(Role);
            }
            if (!RoleManager.RoleExists("User"))
            {
                var Role = new IdentityRole();
                Role.Name = "User";
                RoleManager.Create(Role);
            }
            var UserStore = new UserStore<ApplicationUser>(context);
            var UserManager = new UserManager<ApplicationUser>(UserStore);

            if (!UserManager.Users.Any(u => u.UserName == "Admin"))
            {
                ApplicationUser User = new ApplicationUser();
                User.UserName = "Admin";

                UserManager.Create(User, "123456");
                UserManager.AddToRole(User.Id, "Admin");
            }
            if (!context.Users.Any(u => u.UserName == "Boomer2142"))
            {
                ApplicationUser User = new ApplicationUser();
                User.UserName = "Boomer2142";
                UserManager.Create(User, "123456");
                UserManager.AddToRole(User.Id, "User");
            }
        }
    }
}
