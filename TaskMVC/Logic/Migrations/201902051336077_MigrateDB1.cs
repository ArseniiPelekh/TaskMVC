namespace Logic.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class MigrateDB1 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Books", "Athor_AthorId", "dbo.Athors");
            DropIndex("dbo.Books", new[] { "Athor_AthorId" });
            DropPrimaryKey("dbo.Athors");
            AlterColumn("dbo.Athors", "AthorId", c => c.Int(nullable: false, identity: true));
            AlterColumn("dbo.Books", "Athor_AthorId", c => c.Int(nullable: false));
            AddPrimaryKey("dbo.Athors", "AthorId");
            CreateIndex("dbo.Books", "Athor_AthorId");
            AddForeignKey("dbo.Books", "Athor_AthorId", "dbo.Athors", "AthorId", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Books", "Athor_AthorId", "dbo.Athors");
            DropIndex("dbo.Books", new[] { "Athor_AthorId" });
            DropPrimaryKey("dbo.Athors");
            AlterColumn("dbo.Books", "Athor_AthorId", c => c.String(nullable: false, maxLength: 128));
            AlterColumn("dbo.Athors", "AthorId", c => c.String(nullable: false, maxLength: 128));
            AddPrimaryKey("dbo.Athors", "AthorId");
            CreateIndex("dbo.Books", "Athor_AthorId");
            AddForeignKey("dbo.Books", "Athor_AthorId", "dbo.Athors", "AthorId", cascadeDelete: true);
        }
    }
}
