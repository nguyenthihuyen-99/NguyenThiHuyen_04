namespace NguyenThiHuyen_04.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Create_Table_NhanVien : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.NhanViens",
                c => new
                    {
                        MaNhanVien = c.String(nullable: false, maxLength: 128),
                        TenNhanVien = c.String(),
                        TinhThanhs_MaTinhThanh = c.Int(),
                    })
                .PrimaryKey(t => t.MaNhanVien)
                .ForeignKey("dbo.TinhThanhs", t => t.TinhThanhs_MaTinhThanh)
                .Index(t => t.TinhThanhs_MaTinhThanh);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.NhanViens", "TinhThanhs_MaTinhThanh", "dbo.TinhThanhs");
            DropIndex("dbo.NhanViens", new[] { "TinhThanhs_MaTinhThanh" });
            DropTable("dbo.NhanViens");
        }
    }
}
