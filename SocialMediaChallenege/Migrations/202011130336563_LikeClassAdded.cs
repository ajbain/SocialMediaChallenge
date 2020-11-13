namespace SocialMediaChallenege.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class LikeClassAdded : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Like",
                c => new
                    {
                        LikedPost = c.String(nullable: false, maxLength: 128),
                        Liker = c.Guid(nullable: false),
                    })
                .PrimaryKey(t => t.LikedPost);
            
            CreateTable(
                "dbo.Reply",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        ReplyComment = c.String(nullable: false),
                        CommentId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Comment", t => t.CommentId, cascadeDelete: true)
                .Index(t => t.CommentId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Reply", "CommentId", "dbo.Comment");
            DropIndex("dbo.Reply", new[] { "CommentId" });
            DropTable("dbo.Reply");
            DropTable("dbo.Like");
        }
    }
}
