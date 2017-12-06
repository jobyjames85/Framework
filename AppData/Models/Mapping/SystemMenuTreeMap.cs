using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace AppData.Models.Mapping
{
    public class SystemMenuTreeMap : EntityTypeConfiguration<SystemMenuTree>
    {
        public SystemMenuTreeMap()
        {
            // Primary Key
            this.HasKey(t => t.Id);

            // Properties
            // Table & Column Mappings
            this.ToTable("SystemMenuTrees");
            this.Property(t => t.Id).HasColumnName("Id");
            this.Property(t => t.PId).HasColumnName("PId");
            this.Property(t => t.DisplayIndex).HasColumnName("DisplayIndex");
            this.Property(t => t.SystemMenuItemId).HasColumnName("SystemMenuItemId");
        }
    }
}
