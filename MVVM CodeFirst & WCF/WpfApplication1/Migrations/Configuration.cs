namespace WpfApplication1.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<WpfApplication1.Models.SCHOOLContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }

        public void  Initialize()
        {

        }

        protected override void Seed(WpfApplication1.Models.SCHOOLContext context)
        {
            CourseSeed.CreateCourseSeeds(context);
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
