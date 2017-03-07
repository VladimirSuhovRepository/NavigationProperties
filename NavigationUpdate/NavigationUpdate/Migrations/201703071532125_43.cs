namespace NavigationUpdate.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class _43 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Permissions", "Usergroup_Id", "dbo.Usergroups");
            DropIndex("dbo.Permissions", new[] { "Usergroup_Id" });
            RenameColumn(table: "dbo.Permissions", name: "Usergroup_Id", newName: "UsergroupId");
            AlterColumn("dbo.Permissions", "UsergroupId", c => c.Int(nullable: false));
            CreateIndex("dbo.Permissions", "UsergroupId");
            AddForeignKey("dbo.Permissions", "UsergroupId", "dbo.Usergroups", "Id", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Permissions", "UsergroupId", "dbo.Usergroups");
            DropIndex("dbo.Permissions", new[] { "UsergroupId" });
            AlterColumn("dbo.Permissions", "UsergroupId", c => c.Int());
            RenameColumn(table: "dbo.Permissions", name: "UsergroupId", newName: "Usergroup_Id");
            CreateIndex("dbo.Permissions", "Usergroup_Id");
            AddForeignKey("dbo.Permissions", "Usergroup_Id", "dbo.Usergroups", "Id");
        }
    }
}
