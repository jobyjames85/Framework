using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace WpfApplication1.Models.Mapping
{
    public class EnrollmentMap : EntityTypeConfiguration<Enrollment>
    {
        public EnrollmentMap()
        {
            // Primary Key
            this.HasKey(t => t.EnrollmentId);

            // Properties
            // Table & Column Mappings
            this.ToTable("Enrollment");
            this.Property(t => t.EnrollmentId).HasColumnName("EnrollmentId");
            this.Property(t => t.StudentId).HasColumnName("StudentId");
            this.Property(t => t.CourseId).HasColumnName("CourseId");
            this.Property(t => t.Paid).HasColumnName("Paid");
            this.Property(t => t.name).HasColumnName("name");
        }
    }
}
