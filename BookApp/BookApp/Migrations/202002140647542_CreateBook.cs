namespace BookApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CreateBook : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Author",
                c => new
                    {
                        aid = c.Int(nullable: false, identity: true),
                        name = c.String(),
                        address = c.String(),
                    })
                .PrimaryKey(t => t.aid);
            
            CreateTable(
                "dbo.Detail",
                c => new
                    {
                        aid = c.Int(nullable: false, identity: true),
                        bid = c.Int(nullable: false),
                        Author_aid = c.Int(),
                    })
                .PrimaryKey(t => t.aid)
                .ForeignKey("dbo.Author", t => t.Author_aid)
                .ForeignKey("dbo.Book", t => t.bid, cascadeDelete: true)
                .Index(t => t.bid)
                .Index(t => t.Author_aid);
            
            CreateTable(
                "dbo.Book",
                c => new
                    {
                        bid = c.Int(nullable: false, identity: true),
                        title = c.String(),
                        price = c.Double(nullable: false),
                    })
                .PrimaryKey(t => t.bid);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Detail", "bid", "dbo.Book");
            DropForeignKey("dbo.Detail", "Author_aid", "dbo.Author");
            DropIndex("dbo.Detail", new[] { "Author_aid" });
            DropIndex("dbo.Detail", new[] { "bid" });
            DropTable("dbo.Book");
            DropTable("dbo.Detail");
            DropTable("dbo.Author");
        }
    }
}
