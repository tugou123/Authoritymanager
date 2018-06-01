namespace Base.EntityFramework.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Update_TableName : DbMigration
    {
        public override void Up()
        {
            RenameTable(name: "dbo.Manager_LoginLogs", newName: "Sys_LoginLogs");
            RenameTable(name: "dbo.Manager_TokenInfos", newName: "Sys_TokenInfos");
            RenameTable(name: "dbo.Manager_Userinfos", newName: "Userinfos");
            AddColumn("dbo.Sys_LoginLogs", "TokenId", c => c.Long(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Sys_LoginLogs", "TokenId");
            RenameTable(name: "dbo.Userinfos", newName: "Manager_Userinfos");
            RenameTable(name: "dbo.Sys_TokenInfos", newName: "Manager_TokenInfos");
            RenameTable(name: "dbo.Sys_LoginLogs", newName: "Manager_LoginLogs");
        }
    }
}
