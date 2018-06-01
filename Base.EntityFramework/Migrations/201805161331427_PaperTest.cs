namespace Base.EntityFramework.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PaperTest : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Manager_LoginLogs",
                c => new
                    {
                        Id = c.Long(nullable: false, identity: true),
                        Dns = c.String(nullable: false),
                        IpAddress = c.String(nullable: false),
                        Port = c.Int(nullable: false),
                        Proxyport = c.Int(nullable: false),
                        Endtime = c.DateTime(),
                        UserInfoId = c.Long(nullable: false),
                        CreateDate = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Manager_TokenInfos",
                c => new
                    {
                        Id = c.Long(nullable: false, identity: true),
                        SingToken = c.String(),
                        UserInfoId = c.Long(nullable: false),
                        ExpiryTime = c.DateTime(),
                        CreateDate = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Manager_Userinfos",
                c => new
                    {
                        Id = c.Long(nullable: false, identity: true),
                        UserName = c.String(nullable: false, maxLength: 100),
                        Password = c.String(nullable: false, maxLength: 100),
                        Email = c.String(maxLength: 100),
                        CellPhone = c.String(maxLength: 100),
                        QQ = c.String(maxLength: 100),
                        Address = c.String(maxLength: 100),
                        Type = c.Int(nullable: false),
                        LoginCount = c.Int(nullable: false),
                        IsActive = c.Boolean(nullable: false),
                        IsDelete = c.Boolean(nullable: false),
                        OperatorId = c.Long(nullable: false),
                        CreateDate = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Manager_Userinfos");
            DropTable("dbo.Manager_TokenInfos");
            DropTable("dbo.Manager_LoginLogs");
        }
    }
}
