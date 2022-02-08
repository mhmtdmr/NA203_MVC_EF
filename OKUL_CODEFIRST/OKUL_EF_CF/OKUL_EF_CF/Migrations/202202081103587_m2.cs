namespace OKUL_EF_CF.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class m2 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Ogrenciler", "OkulNumara", c => c.String(nullable: false, maxLength: 10));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Ogrenciler", "OkulNumara", c => c.String(nullable: false));
        }
    }
}
