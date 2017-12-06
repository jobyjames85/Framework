using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace ApplicationData.Models.Mapping
{
    public class SystemMenuItem1Map : EntityTypeConfiguration<SystemMenuItem1>
    {
        public SystemMenuItem1Map()
        {
            // Primary Key
            this.HasKey(t => t.Id);

            // Properties
            // Table & Column Mappings
            this.ToTable("SystemMenuItem1");
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
