namespace SocialMediaChallenege.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class seconde : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Post", "Author", c => c.Guid(nullable: false));
            AddColumn("dbo.Like", "Author", c => c.Guid(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Like", "Author");
            DropColumn("dbo.Post", "Author");
        }
    }
}
