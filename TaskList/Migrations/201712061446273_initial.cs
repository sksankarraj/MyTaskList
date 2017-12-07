namespace TaskList.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Apps",
                c => new
                    {
                        AppId = c.Int(nullable: false, identity: true),
                        AppName = c.String(maxLength: 50),
                    })
                .PrimaryKey(t => t.AppId);
            
            CreateTable(
                "dbo.Tasks",
                c => new
                    {
                        TaskId = c.Int(nullable: false, identity: true),
                        TaskTitle = c.String(),
                        TaskDesc = c.String(),
                        DeadLine = c.DateTime(nullable: false),
                        App_AppId = c.Int(),
                        Priority_PriorityId = c.Int(),
                    })
                .PrimaryKey(t => t.TaskId)
                .ForeignKey("dbo.Apps", t => t.App_AppId)
                .ForeignKey("dbo.PriorityLevels", t => t.Priority_PriorityId)
                .Index(t => t.App_AppId)
                .Index(t => t.Priority_PriorityId);
            
            CreateTable(
                "dbo.PriorityLevels",
                c => new
                    {
                        PriorityId = c.Int(nullable: false, identity: true),
                        PriorityName = c.String(maxLength: 15),
                    })
                .PrimaryKey(t => t.PriorityId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Tasks", "Priority_PriorityId", "dbo.PriorityLevels");
            DropForeignKey("dbo.Tasks", "App_AppId", "dbo.Apps");
            DropIndex("dbo.Tasks", new[] { "Priority_PriorityId" });
            DropIndex("dbo.Tasks", new[] { "App_AppId" });
            DropTable("dbo.PriorityLevels");
            DropTable("dbo.Tasks");
            DropTable("dbo.Apps");
        }
    }
}
