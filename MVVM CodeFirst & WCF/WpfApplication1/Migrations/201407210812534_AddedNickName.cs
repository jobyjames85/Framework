namespace WpfApplication1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddedNickName : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Course", "NickName", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Course", "NickName");
        }
    }
}
