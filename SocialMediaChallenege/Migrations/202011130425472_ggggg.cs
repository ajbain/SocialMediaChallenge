namespace SocialMediaChallenege.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ggggg : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Post", "Like_Id", c => c.Int());
            CreateIndex("dbo.Post", "Like_Id");
            AddForeignKey("dbo.Post", "Like_Id", "dbo.Like", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Post", "Like_Id", "dbo.Like");
            DropIndex("dbo.Post", new[] { "Like_Id" });
            DropColumn("dbo.Post", "Like_Id");
        }
    }
}
