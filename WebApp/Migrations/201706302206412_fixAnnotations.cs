namespace WebApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class fixAnnotations : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Members", "firstName", c => c.String(nullable: false, maxLength: 30));
            AlterColumn("dbo.Members", "Address", c => c.String());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Members", "Address", c => c.String(nullable: false, maxLength: 30));
            AlterColumn("dbo.Members", "firstName", c => c.String());
        }
    }
}
