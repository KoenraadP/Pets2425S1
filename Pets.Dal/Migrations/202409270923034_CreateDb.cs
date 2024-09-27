namespace Pets.Dal.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CreateDb : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Brands",
                c => new
                    {
                        BrandId = c.Guid(nullable: false),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.BrandId);
            
            CreateTable(
                "dbo.Products",
                c => new
                    {
                        ProductId = c.Guid(nullable: false),
                        Name = c.String(),
                        Description = c.String(),
                        Price = c.Decimal(nullable: false, precision: 18, scale: 2),
                        AmountInStock = c.Int(nullable: false),
                        InStock = c.Boolean(nullable: false),
                        AnimalType = c.Int(nullable: false),
                        Weight = c.Double(),
                        AgeCategory = c.Int(),
                        Discriminator = c.String(nullable: false, maxLength: 128),
                        Brand_BrandId = c.Guid(),
                    })
                .PrimaryKey(t => t.ProductId)
                .ForeignKey("dbo.Brands", t => t.Brand_BrandId)
                .Index(t => t.Brand_BrandId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Products", "Brand_BrandId", "dbo.Brands");
            DropIndex("dbo.Products", new[] { "Brand_BrandId" });
            DropTable("dbo.Products");
            DropTable("dbo.Brands");
        }
    }
}
