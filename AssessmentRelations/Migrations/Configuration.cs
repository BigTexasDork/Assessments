using AssessmentRelations.Models;

namespace AssessmentRelations.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<AssessmentRelations.Models.AssessmentContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(AssessmentRelations.Models.AssessmentContext context)
        {
            context.Clients.AddOrUpdate(
                c => c.Name,
                new Client { Name = "Client1" }
            );

            context.Projects.AddOrUpdate(
                p => p.Name,
                new Project { Name = "Project 1" }
            );

            context.Questions.AddOrUpdate(
                q => q.Text,
                new Question
                    {
                        Text = "Products & Services",
                        Type = "GCCR",
                    }
            );
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
