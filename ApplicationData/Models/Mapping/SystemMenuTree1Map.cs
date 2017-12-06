using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace ApplicationData.Models.Mapping
{
    public class SystemMenuTree1Map : EntityTypeConfiguration<SystemMenuTree1>
    {
        public SystemMenuTree1Map()
        {
            // Primary Key
            this.HasKey(t => t.Id);

            // Properties
            // Table & Column Mappings
            this.ToTable("SystemMenuTree1");
            this.Property(t => t.Id).HasColumnName("Id");
            this.Property(t => t.PId).HasColumnName("PId");
            this.Property(t => t.DisplayIndex).HasColumnName("DisplayIndex");
            this.Property(t => t.SystemMenuItemId).HasColumnName("SystemMenuItemId");
        }
    }
}
