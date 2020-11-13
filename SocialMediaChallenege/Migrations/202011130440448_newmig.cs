namespace SocialMediaChallenege.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class newmig : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Post", "Like_Id", "dbo.Like");
            DropIndex("dbo.Post", new[] { "Like_Id" });
            DropColumn("dbo.Post", "CommentID");
            DropColumn("dbo.Post", "Like_Id");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Post", "Like_Id", c => c.Int());
            AddColumn("dbo.Post", "CommentID", c => c.Int(nullable: false));
            CreateIndex("dbo.Post", "Like_Id");
            AddForeignKey("dbo.Post", "Like_Id", "dbo.Like", "Id");
        }
    }
}
