using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace AppData.Models.Mapping
{
    public class SystemMenuItemMap : EntityTypeConfiguration<SystemMenuItem>
    {
        public SystemMenuItemMap()
        {
            // Primary Key
            this.HasKey(t => t.Id);

            // Properties
            // Table & Column Mappings
            this.ToTable("SystemMenuItems");
            this.Property(t => t.Id).HasColumnName("Id");
            this.Property(t => t.NameEn).HasColumnName("NameEn");
            this.Property(t => t.NameJa).HasColumnName("NameJa");
            this.Property(t => t.NameTh).HasColumnName("NameTh");
            this.Property(t => t.NameCh).HasColumnName("NameCh");
            this.Property(t => t.NameMy).HasColumnName("NameMy");
            this.Property(t => t.NameClass).HasColumnName("NameClass");
            this.Property(t => t.ImageIcon).HasColumnName("ImageIcon");
            this.Property(t => t.PageUri).HasColumnName("PageUri");
        }
    }
}
