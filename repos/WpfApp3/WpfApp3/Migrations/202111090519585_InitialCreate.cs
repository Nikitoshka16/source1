namespace WpfApp3.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Doljs",
                c => new
                    {
                        doljID = c.Int(nullable: false, identity: true),
                        obiz = c.String(),
                        zp = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.doljID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Doljs");
        }
    }
}
