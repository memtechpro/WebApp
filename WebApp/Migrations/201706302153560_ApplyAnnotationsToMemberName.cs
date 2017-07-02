namespace WebApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ApplyAnnotationsToMemberName : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Members", "lastName", c => c.String(nullable: false, maxLength: 30));
            AlterColumn("dbo.Members", "Address", c => c.String(nullable: false, maxLength: 30));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Members", "Address", c => c.String());
            AlterColumn("dbo.Members", "lastName", c => c.String());
        }
    }
}
