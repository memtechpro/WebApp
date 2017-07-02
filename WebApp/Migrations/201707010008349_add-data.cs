namespace WebApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class adddata : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Members", "Member_id", "dbo.Members");
            DropIndex("dbo.Members", new[] { "Member_id" });
            DropColumn("dbo.Members", "Member_id");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Members", "Member_id", c => c.Int());
            CreateIndex("dbo.Members", "Member_id");
            AddForeignKey("dbo.Members", "Member_id", "dbo.Members", "id");
        }
    }
}
