namespace ApplicationData.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddDatabase : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.SystemMenuItem1",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        NameEn = c.String(),
                        NameJa = c.String(),
                        NameTh = c.String(),
                        NameCh = c.String(),
                        NameMy = c.String(),
                        NameClass = c.String(),
                        ImageIcon = c.Binary(),
                        PageUri = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.SystemMenuTree1",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        PId = c.Int(nullable: false),
                        DisplayIndex = c.Int(nullable: false),
                        SystemMenuItemId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.SystemMenuTree1");
            DropTable("dbo.SystemMenuItem1");
        }
    }
}
