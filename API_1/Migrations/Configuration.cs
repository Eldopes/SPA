namespace API_1.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using API_1.Models;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<API_1.Models.API_1Context>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(API_1.Models.API_1Context context)
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

            context.Users.AddOrUpdate(x => x.Id,  // to add or update database entries 
                new User() { Id = 1, UserName = "johnny81" },
                new User() { Id = 2, UserName = "missmary" },
                new User() { Id = 3, UserName = "jijames" }
                );

        }
    }
}
