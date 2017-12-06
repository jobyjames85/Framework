using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using AppData.Models.Mapping;

namespace AppData.Models
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

        public DbSet<SystemMenuItem> SystemMenuItems { get; set; }
        public DbSet<SystemMenuTree> SystemMenuTrees { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new SystemMenuItemMap());
            modelBuilder.Configurations.Add(new SystemMenuTreeMap());
        }
    }
}
