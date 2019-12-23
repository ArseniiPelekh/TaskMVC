namespace Logic.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class MigrateDB : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Books", "FkAthor", c => c.Int());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Books", "FkAthor", c => c.Int(nullable: false));
        }
    }
}
