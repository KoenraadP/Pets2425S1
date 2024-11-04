namespace Pets.Dal.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class BrandValidation3 : DbMigration
    {
        public override void Up()
        {
            RenameColumn(table: "dbo.Products", name: "Brand_BrandId", newName: "BrandId");
            RenameIndex(table: "dbo.Products", name: "IX_Brand_BrandId", newName: "IX_BrandId");
        }
        
        public override void Down()
        {
            RenameIndex(table: "dbo.Products", name: "IX_BrandId", newName: "IX_Brand_BrandId");
            RenameColumn(table: "dbo.Products", name: "BrandId", newName: "Brand_BrandId");
        }
    }
}
