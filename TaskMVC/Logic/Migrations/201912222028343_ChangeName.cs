namespace Logic.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ChangeName : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Books", "Athor_AthorId", "dbo.Athors");
            DropIndex("dbo.Books", new[] { "Athor_AthorId" });
            CreateTable(
                "dbo.Authors",
                c => new
                    {
                        AuthorId = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false),
                        Surname = c.String(nullable: false),
                        MiddleName = c.String(nullable: false),
                        Phone = c.String(nullable: false),
                        Birthday = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.AuthorId);
            
            AddColumn("dbo.Books", "Genre", c => c.String(nullable: false));
            AddColumn("dbo.Books", "PageNumber", c => c.Int(nullable: false));
            AddColumn("dbo.Books", "FkAuthor", c => c.Int(nullable: false));
            AddColumn("dbo.Books", "Author_AuthorId", c => c.Int());
            CreateIndex("dbo.Books", "Author_AuthorId");
            AddForeignKey("dbo.Books", "Author_AuthorId", "dbo.Authors", "AuthorId");
            DropColumn("dbo.Books", "Ganre");
            DropColumn("dbo.Books", "NamPage");
            DropColumn("dbo.Books", "FkAthor");
            DropColumn("dbo.Books", "Athor_AthorId");
            DropTable("dbo.Athors");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.Athors",
                c => new
                    {
                        AthorId = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false),
                        Surname = c.String(nullable: false),
                        MiddleName = c.String(nullable: false),
                        Phone = c.String(nullable: false),
                        Birthday = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.AthorId);
            
            AddColumn("dbo.Books", "Athor_AthorId", c => c.Int(nullable: false));
            AddColumn("dbo.Books", "FkAthor", c => c.Int());
            AddColumn("dbo.Books", "NamPage", c => c.Int(nullable: false));
            AddColumn("dbo.Books", "Ganre", c => c.String(nullable: false));
            DropForeignKey("dbo.Books", "Author_AuthorId", "dbo.Authors");
            DropIndex("dbo.Books", new[] { "Author_AuthorId" });
            DropColumn("dbo.Books", "Author_AuthorId");
            DropColumn("dbo.Books", "FkAuthor");
            DropColumn("dbo.Books", "PageNumber");
            DropColumn("dbo.Books", "Genre");
            DropTable("dbo.Authors");
            CreateIndex("dbo.Books", "Athor_AthorId");
            AddForeignKey("dbo.Books", "Athor_AthorId", "dbo.Athors", "AthorId", cascadeDelete: true);
        }
    }
}
