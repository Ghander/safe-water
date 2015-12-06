namespace SafeWater8.Migrations
{
    using Microsoft.AspNet.Identity.EntityFramework;
    using Domain.Models;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using Microsoft.AspNet.Identity;

    internal sealed class Configuration : DbMigrationsConfiguration<SafeWater8.Infrastructure.ApplicationDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(SafeWater8.Infrastructure.ApplicationDbContext context)
        {
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


            //Use this to create an admin
            context.Contaminants.AddOrUpdate(
                c => c.Name,
                new Contaminant { Name = "Arsenic", Source = "Skin damage or problems with circulatory systems, and may have increased risk of getting cancer.", HealthEffects = "Erosion of natural deposits; runoff from orchards, runoff from glass and electronicsproduction wastes" },
                new Contaminant { Name = "Lead", HealthEffects = "Infants and children: Delays in physical or mental development; children could show slight deficits in attention span and learning abilities", Source = "Corrosion of household plumbing systems; erosion of natural deposits" }
                );

            var userStore = new UserStore<ApplicationUser>(context);
            var userManager = new ApplicationUserManager(userStore);
            var roleStore = new RoleStore<IdentityRole>(context);
            var roleManager = new ApplicationRoleManager(roleStore);

            if (!roleManager.RoleExists("Admin")) {
                roleManager.Create(new IdentityRole("Admin"));

            }
            var user = userManager.FindByName("safewater8");
            if (user == null) {
                user = new ApplicationUser {
                    UserName = "safewater8",
                    Email = "cen254@gmail.com"
                };
                userManager.Create(user, "password08");
            }


        }
    }
}
