using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace WpfApplication1.Models.Mapping
{
    public class DefaultFilterMap : EntityTypeConfiguration<DefaultFilter>
    {
        public DefaultFilterMap()
        {
            // Primary Key
            this.HasKey(t => t.ScreenName);

            // Properties
            this.Property(t => t.ScreenName)
                .IsRequired()
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("DefaultFilter");
            this.Property(t => t.ScreenName).HasColumnName("ScreenName");
            this.Property(t => t.Filter).HasColumnName("Filter");
        }
    }
}
