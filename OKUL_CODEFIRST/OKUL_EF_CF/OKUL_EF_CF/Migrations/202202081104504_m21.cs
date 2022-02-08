namespace OKUL_EF_CF.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class m21 : DbMigration
    {
        public override void Up()
        {
            CreateIndex("dbo.Ogrenciler", "OkulNumara");
        }
        
        public override void Down()
        {
            DropIndex("dbo.Ogrenciler", new[] { "OkulNumara" });
        }
    }
}
