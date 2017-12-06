using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace WpfApplication1.Models.Mapping
{
    public class CourseMap : EntityTypeConfiguration<Course>
    {
        public CourseMap()
        {
            // Primary Key
            this.HasKey(t => t.CourseId);

            // Properties
            this.Property(t => t.Title)
                .IsRequired()
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("Course");
            this.Property(t => t.CourseId).HasColumnName("CourseId");
            this.Property(t => t.Name).HasColumnName("Name");
            this.Property(t => t.InstructorId).HasColumnName("InstructorId");
            this.Property(t => t.Title).HasColumnName("Title");
            this.Property(t => t.StartDate).HasColumnName("StartDate");
            this.Property(t => t.EndDate).HasColumnName("EndDate");
            this.Property(t => t.ClassSize).HasColumnName("ClassSize");
        }
    }
}
