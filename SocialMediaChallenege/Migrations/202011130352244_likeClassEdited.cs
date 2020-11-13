namespace SocialMediaChallenege.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class likeClassEdited : DbMigration
    {
        public override void Up()
        {
            DropPrimaryKey("dbo.Like");
            AddColumn("dbo.Like", "Id", c => c.Int(nullable: false, identity: true));
            AlterColumn("dbo.Like", "LikedPost", c => c.String(nullable: false));
            AddPrimaryKey("dbo.Like", "Id");
        }
        
        public override void Down()
        {
            DropPrimaryKey("dbo.Like");
            AlterColumn("dbo.Like", "LikedPost", c => c.String(nullable: false, maxLength: 128));
            DropColumn("dbo.Like", "Id");
            AddPrimaryKey("dbo.Like", "LikedPost");
        }
    }
}
