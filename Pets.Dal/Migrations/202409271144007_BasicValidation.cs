namespace Pets.Dal.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class BasicValidation : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Brands", "Name", c => c.String(nullable: false));
            AlterColumn("dbo.Products", "Name", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Products", "Name", c => c.String());
            AlterColumn("dbo.Brands", "Name", c => c.String());
        }
    }
}
