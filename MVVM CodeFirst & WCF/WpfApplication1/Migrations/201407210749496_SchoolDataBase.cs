namespace WpfApplication1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SchoolDataBase : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Course",
                c => new
                    {
                        CourseId = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        InstructorId = c.Int(nullable: false),
                        Title = c.String(nullable: false, maxLength: 50),
                        StartDate = c.DateTime(),
                        EndDate = c.DateTime(),
                        ClassSize = c.Int(),
                        Address = c.String(),
                    })
                .PrimaryKey(t => t.CourseId);
            
            CreateTable(
                "dbo.DefaultFilter",
                c => new
                    {
                        ScreenName = c.String(nullable: false, maxLength: 50),
                        Filter = c.String(),
                    })
                .PrimaryKey(t => t.ScreenName);
            
            CreateTable(
                "dbo.Enrollment",
                c => new
                    {
                        EnrollmentId = c.Int(nullable: false, identity: true),
                        StudentId = c.Int(nullable: false),
                        CourseId = c.Int(nullable: false),
                        Paid = c.Boolean(nullable: false),
                        name = c.String(),
                    })
                .PrimaryKey(t => t.EnrollmentId);
            
            CreateTable(
                "dbo.Person",
                c => new
                    {
                        PersonId = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 50),
                        EnrollmentDate = c.DateTime(),
                        HireDate = c.DateTime(),
                        Salary = c.Decimal(precision: 18, scale: 2),
                        Status = c.Int(nullable: false),
                        Role = c.String(nullable: false, maxLength: 50),
                    })
                .PrimaryKey(t => t.PersonId);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Person");
            DropTable("dbo.Enrollment");
            DropTable("dbo.DefaultFilter");
            DropTable("dbo.Course");
        }
    }
}
