namespace WAD_T2104E_NguyenHoangSon.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class productDBMigration : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.categories",
                c => new
                    {
                        categoryId = c.Int(nullable: false, identity: true),
                        categoryName = c.String(),
                        createTime = c.DateTime(nullable: false),
                        updateTime = c.DateTime(nullable: false),
                        createUser = c.String(),
                        updateUser = c.String(),
                    })
                .PrimaryKey(t => t.categoryId);
            
            CreateTable(
                "dbo.products",
                c => new
                    {
                        productId = c.Int(nullable: false, identity: true),
                        name = c.String(nullable: false, maxLength: 32),
                        price = c.Int(nullable: false),
                        quantity = c.Int(nullable: false),
                        releaseDate = c.DateTime(nullable: false),
                        createTime = c.DateTime(nullable: false),
                        updateTime = c.DateTime(nullable: false),
                        createUser = c.String(),
                        updateUser = c.String(),
                        categoryId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.productId)
                .ForeignKey("dbo.categories", t => t.categoryId, cascadeDelete: true)
                .Index(t => t.categoryId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.products", "categoryId", "dbo.categories");
            DropIndex("dbo.products", new[] { "categoryId" });
            DropTable("dbo.products");
            DropTable("dbo.categories");
        }
    }
}
