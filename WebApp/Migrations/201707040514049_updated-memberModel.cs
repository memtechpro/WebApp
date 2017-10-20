namespace WebApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class updatedmemberModel : DbMigration
    {
        public override void Up()
        {
            DropPrimaryKey("dbo.Members");
            DropColumn("dbo.Members", "id");
            AddColumn("dbo.Members", "member_id", c => c.Int(nullable: false, identity: true));
            AddColumn("dbo.Members", "member_full_name", c => c.String(nullable: false, maxLength: 30));
            AddColumn("dbo.Members", "member_nickname", c => c.String(maxLength: 30));
            AddColumn("dbo.Members", "member_email", c => c.String(maxLength: 30));
            AddColumn("dbo.Members", "member_age", c => c.String(maxLength: 50));
            AddColumn("dbo.Members", "member_address", c => c.String(maxLength: 50));
            AddColumn("dbo.Members", "member_city", c => c.String(maxLength: 50));
            AddColumn("dbo.Members", "member_country", c => c.String(maxLength: 50));
            AddColumn("dbo.Members", "member_postal_code", c => c.String(maxLength: 50));
            AddColumn("dbo.Members", "member_telephone", c => c.String(maxLength: 15));
            AddColumn("dbo.Members", "member_sex", c => c.String(maxLength: 10));
            AddColumn("dbo.Members", "member_additional_member_info", c => c.String(maxLength: 50));
            AddPrimaryKey("dbo.Members", "member_id");            
            DropColumn("dbo.Members", "firstName");
            DropColumn("dbo.Members", "lastName");
            DropColumn("dbo.Members", "Address");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Members", "Address", c => c.String(nullable: false, maxLength: 50));
            AddColumn("dbo.Members", "lastName", c => c.String(nullable: false, maxLength: 30));
            AddColumn("dbo.Members", "firstName", c => c.String(nullable: false, maxLength: 30));
            AddColumn("dbo.Members", "id", c => c.Int(nullable: false, identity: true));
            DropPrimaryKey("dbo.Members");
            DropColumn("dbo.Members", "member_additional_member_info");
            DropColumn("dbo.Members", "member_sex");
            DropColumn("dbo.Members", "member_telephone");
            DropColumn("dbo.Members", "member_postal_code");
            DropColumn("dbo.Members", "member_country");
            DropColumn("dbo.Members", "member_city");
            DropColumn("dbo.Members", "member_address");
            DropColumn("dbo.Members", "member_age");
            DropColumn("dbo.Members", "member_email");
            DropColumn("dbo.Members", "member_nickname");
            DropColumn("dbo.Members", "member_full_name");
            DropColumn("dbo.Members", "member_id");
            AddPrimaryKey("dbo.Members", "id");
        }
    }
}
