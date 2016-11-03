namespace API_2.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using API_2.Models;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<API_2.Models.API_2Context>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(API_2.Models.API_2Context context)
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

            context.Departments.AddOrUpdate(x => x.Id,  // to add or update database entries 
              new Department() { Id = 1, Title = "IT department" },
              new Department() { Id = 2, Title = "Marketing" }
              );

        }
    }
}
