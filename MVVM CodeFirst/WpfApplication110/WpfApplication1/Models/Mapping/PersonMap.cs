using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace WpfApplication1.Models.Mapping
{
    public class PersonMap : EntityTypeConfiguration<Person>
    {
        public PersonMap()
        {
            // Primary Key
            this.HasKey(t => t.PersonId);

            // Properties
            this.Property(t => t.Name)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.Role)
                .IsRequired()
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("Person");
            this.Property(t => t.PersonId).HasColumnName("PersonId");
            this.Property(t => t.Name).HasColumnName("Name");
            this.Property(t => t.EnrollmentDate).HasColumnName("EnrollmentDate");
            this.Property(t => t.HireDate).HasColumnName("HireDate");
            this.Property(t => t.Salary).HasColumnName("Salary");
            this.Property(t => t.Status).HasColumnName("Status");
            this.Property(t => t.Role).HasColumnName("Role");
        }
    }
}
