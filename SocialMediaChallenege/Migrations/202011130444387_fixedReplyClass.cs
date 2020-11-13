namespace SocialMediaChallenege.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class fixedReplyClass : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Reply", "CommentId", "dbo.Comment");
            DropIndex("dbo.Reply", new[] { "CommentId" });
            DropColumn("dbo.Reply", "CommentId");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Reply", "CommentId", c => c.Int(nullable: false));
            CreateIndex("dbo.Reply", "CommentId");
            AddForeignKey("dbo.Reply", "CommentId", "dbo.Comment", "Id", cascadeDelete: true);
        }
    }
}
