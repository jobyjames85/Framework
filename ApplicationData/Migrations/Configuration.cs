namespace ApplicationData.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    //Enable-Migrations –EnableAutomaticMigrations
    //Add-Migration [name]
    //Update-Database [-verbose]
    //RolllBack Changes Update-Database -TargetMigration:"seedAdded"
    internal sealed class Configuration : DbMigrationsConfiguration<ApplicationData.Models.FrameworkDataContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }

        protected override void Seed(ApplicationData.Models.FrameworkDataContext context)
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
        }
    }
}
