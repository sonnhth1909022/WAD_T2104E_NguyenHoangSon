namespace WAD_T2104E_NguyenHoangSon.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class productDBMigration2 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.categories", "createTime", c => c.DateTime());
            AlterColumn("dbo.categories", "updateTime", c => c.DateTime());
            AlterColumn("dbo.products", "releaseDate", c => c.DateTime());
            AlterColumn("dbo.products", "createTime", c => c.DateTime());
            AlterColumn("dbo.products", "updateTime", c => c.DateTime());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.products", "updateTime", c => c.DateTime(nullable: false));
            AlterColumn("dbo.products", "createTime", c => c.DateTime(nullable: false));
            AlterColumn("dbo.products", "releaseDate", c => c.DateTime(nullable: false));
            AlterColumn("dbo.categories", "updateTime", c => c.DateTime(nullable: false));
            AlterColumn("dbo.categories", "createTime", c => c.DateTime(nullable: false));
        }
    }
}
