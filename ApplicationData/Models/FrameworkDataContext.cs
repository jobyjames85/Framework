using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using ApplicationData.Models.Mapping;

namespace ApplicationData.Models
{
    public partial class FrameworkDataContext : DbContext
    {
        static FrameworkDataContext()
        {
            Database.SetInitializer<FrameworkDataContext>(null);
        }

        public FrameworkDataContext()
            : base("Name=FrameworkDataContext")
        {
        }

        public DbSet<SystemMenuItem1> SystemMenuItem1 { get; set; }
        public DbSet<SystemMenuTree1> SystemMenuTree1 { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new SystemMenuItem1Map());
            modelBuilder.Configurations.Add(new SystemMenuTree1Map());
        }
    }
}
