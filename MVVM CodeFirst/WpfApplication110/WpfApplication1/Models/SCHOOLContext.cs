using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using WpfApplication1.Models.Mapping;

namespace WpfApplication1.Models
{
    public partial class SCHOOLContext : DbContext
    {
        static SCHOOLContext()
        {
           
        }

        public SCHOOLContext(): base("Name=SCHOOLContext")
        {
        }

        public DbSet<Course> Courses { get; set; }
        public DbSet<DefaultFilter> DefaultFilters { get; set; }
        public DbSet<Enrollment> Enrollments { get; set; }
        public DbSet<Person> People { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            Database.SetInitializer<SCHOOLContext>(null);
            modelBuilder.Configurations.Add(new CourseMap());
            modelBuilder.Configurations.Add(new DefaultFilterMap());
            modelBuilder.Configurations.Add(new EnrollmentMap());
            modelBuilder.Configurations.Add(new PersonMap());
        }
    }
}
