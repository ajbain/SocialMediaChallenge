namespace SocialMediaChallenege.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddedReplyToComment : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Reply", "CommentID", c => c.Int(nullable: false));
            CreateIndex("dbo.Reply", "CommentID");
            AddForeignKey("dbo.Reply", "CommentID", "dbo.Comment", "Id", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Reply", "CommentID", "dbo.Comment");
            DropIndex("dbo.Reply", new[] { "CommentID" });
            DropColumn("dbo.Reply", "CommentID");
        }
    }
}
