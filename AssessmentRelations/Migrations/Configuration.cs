namespace AssessmentRelations.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using AssessmentRelations.Models;

    internal sealed class Configuration : DbMigrationsConfiguration<AssessmentRelations.Models.AssessmentContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(AssessmentRelations.Models.AssessmentContext context)
        {
            var client = new Client { Name = "Client 1" };
            var proj = new Project { Name = "Project 1" };

            context.Projects.AddOrUpdate(
                p => p.Name,
                proj
            );

            client.AddProject(proj);

            context.Clients.AddOrUpdate(
                c => c.Name,
                client
            );

            context.SaveChanges();
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
