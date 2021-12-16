namespace PhamThangWAD.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class add_ngayNopPhat_to_student : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Students", "NgayNopPhat", c => c.DateTime(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Students", "NgayNopPhat");
        }
    }
}
