namespace SocialMediaChallenege.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addedCommentClass : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Post", "CommentID", "dbo.Comment");
            DropIndex("dbo.Post", new[] { "CommentID" });
        }
        
        public override void Down()
        {
            CreateIndex("dbo.Post", "CommentID");
            AddForeignKey("dbo.Post", "CommentID", "dbo.Comment", "Id", cascadeDelete: true);
        }
    }
}
