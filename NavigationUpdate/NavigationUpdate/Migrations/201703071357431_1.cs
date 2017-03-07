namespace NavigationUpdate.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class _1 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Permissions",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Usergroup_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Usergroups", t => t.Usergroup_Id)
                .Index(t => t.Usergroup_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Permissions", "Usergroup_Id", "dbo.Usergroups");
            DropIndex("dbo.Permissions", new[] { "Usergroup_Id" });
            DropTable("dbo.Permissions");
        }
    }
}
