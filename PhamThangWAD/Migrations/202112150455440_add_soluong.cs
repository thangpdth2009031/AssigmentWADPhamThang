namespace PhamThangWAD.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class add_soluong : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Students", "SoLuongChongDay", c => c.Int(nullable: true));
            AddColumn("dbo.Students", "SoLuongTienPhat", c => c.Int(nullable: true));
            DropColumn("dbo.Students", "SoLuong");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Students", "SoLuong", c => c.Int(nullable: true));
            DropColumn("dbo.Students", "SoLuongTienPhat");
            DropColumn("dbo.Students", "SoLuongChongDay");
        }
    }
}
