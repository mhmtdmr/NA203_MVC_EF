namespace OKUL_EF_CF.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class m1 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Ogrenciler",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        OkulNumara = c.String(nullable: false),
                        Sinif = c.String(),
                        OgretmenID = c.Int(nullable: false),
                        FullName = c.String(nullable: false, maxLength: 50),
                        Email = c.String(nullable: false, maxLength: 50),
                        Password = c.String(nullable: false),
                        Phone = c.String(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Ogretmenler", t => t.OgretmenID, cascadeDelete: true)
                .Index(t => t.OgretmenID);
            
            CreateTable(
                "dbo.Ogretmenler",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Maas = c.Double(nullable: false),
                        Alan = c.String(maxLength: 30),
                        FullName = c.String(nullable: false, maxLength: 50),
                        Email = c.String(nullable: false, maxLength: 50),
                        Password = c.String(nullable: false),
                        Phone = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Ogrenciler", "OgretmenID", "dbo.Ogretmenler");
            DropIndex("dbo.Ogrenciler", new[] { "OgretmenID" });
            DropTable("dbo.Ogretmenler");
            DropTable("dbo.Ogrenciler");
        }
    }
}
