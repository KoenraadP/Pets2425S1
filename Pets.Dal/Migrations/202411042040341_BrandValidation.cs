namespace Pets.Dal.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class BrandValidation : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Products", "Brand_BrandId", "dbo.Brands");
            DropIndex("dbo.Products", new[] { "Brand_BrandId" });
            AlterColumn("dbo.Products", "Brand_BrandId", c => c.Guid(nullable: false));
            CreateIndex("dbo.Products", "Brand_BrandId");
            AddForeignKey("dbo.Products", "Brand_BrandId", "dbo.Brands", "BrandId", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Products", "Brand_BrandId", "dbo.Brands");
            DropIndex("dbo.Products", new[] { "Brand_BrandId" });
            AlterColumn("dbo.Products", "Brand_BrandId", c => c.Guid());
            CreateIndex("dbo.Products", "Brand_BrandId");
            AddForeignKey("dbo.Products", "Brand_BrandId", "dbo.Brands", "BrandId");
        }
    }
}
