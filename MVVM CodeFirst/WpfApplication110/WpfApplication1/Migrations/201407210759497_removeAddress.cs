namespace WpfApplication1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class removeAddress : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Course", "Address");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Course", "Address", c => c.String());
        }
    }
}
