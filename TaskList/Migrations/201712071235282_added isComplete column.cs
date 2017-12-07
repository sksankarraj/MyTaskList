namespace TaskList.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addedisCompletecolumn : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Tasks", "isCompleted", c => c.Boolean(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Tasks", "isCompleted");
        }
    }
}
